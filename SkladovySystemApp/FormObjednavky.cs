using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace SkladovySystemApp
{
    public partial class FormObjednavky : Form
    {
        public FormObjednavky()
        {
            InitializeComponent();
            NacistObjednavky();
        }

        private void NacistObjednavky()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT * FROM Objednavky";

                // Pokud je zadán text pro vyhledávání
                if (!string.IsNullOrEmpty(txtVyhledat.Text))
                {
                    query += " WHERE Zakaznik LIKE @zakaznik";
                }

                var cmd = new SQLiteCommand(query, conn);

                // Pokud je vyhledávání aktivní, přidáme parametr pro jméno zákazníka
                if (!string.IsNullOrEmpty(txtVyhledat.Text))
                {
                    cmd.Parameters.AddWithValue("@zakaznik", "%" + txtVyhledat.Text + "%");
                }

                var adapter = new SQLiteDataAdapter(cmd);
                var dt = new DataTable();
                adapter.Fill(dt);
                dgvObjednavky.DataSource = dt;
            }
        }


        private void btnNovaObjednavka_Click(object sender, EventArgs e)
        {
            var nova = new FormNovaObjednavka();
            if (nova.ShowDialog() == DialogResult.OK)
            {
                NacistObjednavky();
            }
        }

        private void btnSmazatObjednavku_Click(object sender, EventArgs e)
        {
            if (dgvObjednavky.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvObjednavky.SelectedRows[0].Cells["ID"].Value);

                using (var conn = DatabaseHelper.GetConnection())
                {

                    // Nejdříve smaž položky dané objednávky
                    var cmdPolozky = new SQLiteCommand("DELETE FROM ObjednavkaPolozky WHERE ObjednavkaID = @id", conn);
                    cmdPolozky.Parameters.AddWithValue("@id", id);
                    cmdPolozky.ExecuteNonQuery();

                    // Poté smaž samotnou objednávku
                    var cmdObjednavka = new SQLiteCommand("DELETE FROM Objednavky WHERE ID = @id", conn);
                    cmdObjednavka.Parameters.AddWithValue("@id", id);
                    cmdObjednavka.ExecuteNonQuery();
                }

                NacistObjednavky();
                MessageBox.Show("Objednávka byla úspěšně smazána.");
            }
        }

        private void btnVyhledat_Click(object sender, EventArgs e)
        {
            NacistObjednavky(); // Zavoláme funkci pro načtení objednávek podle zadaného filtru
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvObjednavky.SelectedRows.Count > 0)
            {
                int objednavkaId = Convert.ToInt32(dgvObjednavky.SelectedRows[0].Cells["ID"].Value);
                var detailForm = new DetailObjednavky(objednavkaId);
                detailForm.ShowDialog();
            }
        }

        private void dgvObjednavky_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int objednavkaId = Convert.ToInt32(dgvObjednavky.Rows[e.RowIndex].Cells["ID"].Value);
                var detailForm = new DetailObjednavky(objednavkaId);
                detailForm.ShowDialog();
            }
        }
    }
}
