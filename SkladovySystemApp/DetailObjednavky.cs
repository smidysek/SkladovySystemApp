using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace SkladovySystemApp
{
    public partial class DetailObjednavky : Form
    {
        private int objednavkaId;

        public DetailObjednavky(int id)
        {
            InitializeComponent();
            objednavkaId = id;
            NacistDetail();
        }

        private void NacistDetail()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                // Získání údajů o objednávce
                var cmd = new SQLiteCommand("SELECT Datum, Zakaznik, CelkovaCena FROM Objednavky WHERE ID = @id", conn);
                cmd.Parameters.AddWithValue("@id", objednavkaId);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        lblDatum.Text = $"Datum: {reader["Datum"]}";
                        lblZakaznik.Text = $"Zákazník: {reader["Zakaznik"]}";
                        lblCelkovaCena.Text = $"Celková cena: {reader["CelkovaCena"]} Kč";
                    }
                }

                // Získání položek objednávky
                var adapter = new SQLiteDataAdapter(@"
                    SELECT p.Nazev AS Produkt, op.Mnozstvi, op.CenaZaKus, 
                           (op.Mnozstvi * op.CenaZaKus) AS Celkem
                    FROM ObjednavkaPolozky op
                    JOIN Produkty p ON op.ProduktID = p.ID
                    WHERE op.ObjednavkaID = @id", conn);
                adapter.SelectCommand.Parameters.AddWithValue("@id", objednavkaId);

                var dt = new DataTable();
                adapter.Fill(dt);
                dgvPolozky.DataSource = dt;
            }
        }

        private void btnZavrit_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
