using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace SkladovySystemApp
{
    public partial class FormNovaObjednavka : Form
    {
        decimal celkovaCena = 0;
        public FormNovaObjednavka()
        {
            InitializeComponent();
            NacistProdukty();
            InicializujTabulku();
        }

        private void NacistProdukty()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT Nazev FROM Produkty", conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbProdukt.Items.Add(reader.GetString(0));
                }
            }
        }

        private void InicializujTabulku()
        {
            dgvPolozky.Columns.Add("Nazev", "Produkt");
            dgvPolozky.Columns.Add("Cena", "Cena");
            dgvPolozky.Columns.Add("Mnozstvi", "Množství");
            dgvPolozky.Columns.Add("Celkem", "Celkem");
        }

        private void btnPridatPolozku_Click(object sender, EventArgs e)
        {
            string nazev = cmbProdukt.Text;
            int mnozstvi = (int)numMnozstvi.Value;

            using (var conn = DatabaseHelper.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT ID, Cena, Mnozstvi FROM Produkty WHERE Nazev = @nazev", conn);
                cmd.Parameters.AddWithValue("@nazev", nazev);
                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    decimal cena = reader.GetDecimal(1);
                    int dostupneMnozstvi = reader.GetInt32(2);

                    if (mnozstvi > dostupneMnozstvi)
                    {
                        MessageBox.Show($"Na skladě je pouze {dostupneMnozstvi} ks tohoto produktu.", "Nedostatek zásob", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    decimal celkem = cena * mnozstvi;
                    dgvPolozky.Rows.Add(nazev, cena, mnozstvi, celkem);
                    celkovaCena += celkem;
                    lblCelkovaCena.Text = $"Celková cena: {celkovaCena} Kč";
                }
                else
                {
                    MessageBox.Show("Produkt nebyl nalezen.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUlozit_Click(object sender, EventArgs e)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Vložení do Objednavky
                        var cmd = new SQLiteCommand("INSERT INTO Objednavky (Datum, Zakaznik, CelkovaCena) VALUES (@datum, @zakaznik, @cena); SELECT last_insert_rowid();", conn, transaction);
                        cmd.Parameters.AddWithValue("@datum", DateTime.Now.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@zakaznik", txtZakaznik.Text);
                        cmd.Parameters.AddWithValue("@cena", celkovaCena);
                        long objednavkaId = (long)cmd.ExecuteScalar();

                        // Vložení položek
                        foreach (DataGridViewRow row in dgvPolozky.Rows)
                        {
                            if (row.IsNewRow || row.Cells[0].Value == null)
                                continue;

                            string produktNazev = row.Cells[0].Value.ToString();
                            decimal cenaZaKus = Convert.ToDecimal(row.Cells[1].Value);
                            int mnozstvi = Convert.ToInt32(row.Cells[2].Value);

                            int produktId;

                            using (var cmdProdukt = new SQLiteCommand("SELECT ID FROM Produkty WHERE Nazev = @nazev", conn, transaction))
                            {
                                cmdProdukt.Parameters.AddWithValue("@nazev", produktNazev);
                                object result = cmdProdukt.ExecuteScalar();

                                if (result == null)
                                    throw new Exception($"Produkt '{produktNazev}' nebyl nalezen.");

                                produktId = Convert.ToInt32(result);
                            }

                            using (var cmdPolozka = new SQLiteCommand("INSERT INTO ObjednavkaPolozky (ObjednavkaID, ProduktID, Mnozstvi, CenaZaKus) VALUES (@oid, @pid, @mnozstvi, @cena)", conn, transaction))
                            {
                                cmdPolozka.Parameters.AddWithValue("@oid", objednavkaId);
                                cmdPolozka.Parameters.AddWithValue("@pid", produktId);
                                cmdPolozka.Parameters.AddWithValue("@mnozstvi", mnozstvi);
                                cmdPolozka.Parameters.AddWithValue("@cena", cenaZaKus);
                                cmdPolozka.ExecuteNonQuery();
                                var cmdUpdate = new SQLiteCommand("UPDATE Produkty SET Mnozstvi = Mnozstvi - @odebrat WHERE ID = @pid", conn);
                                cmdUpdate.Parameters.AddWithValue("@odebrat", mnozstvi);
                                cmdUpdate.Parameters.AddWithValue("@pid", produktId);
                                cmdUpdate.ExecuteNonQuery();

                            }
                        }

                        transaction.Commit();
                        MessageBox.Show("Objednávka uložena.");
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Chyba při ukládání: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void btnZrusit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
