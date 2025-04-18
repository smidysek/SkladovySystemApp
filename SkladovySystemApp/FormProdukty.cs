using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace SkladovySystemApp
{
    public partial class FormProdukty : Form
    {

        private string connectionString = "Data Source=sklad.db;Version=3;";

        public FormProdukty()
        {
            InitializeComponent();
            NacistProdukty();
        }

        private void NacistProdukty()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                var adapter = new SQLiteDataAdapter("SELECT * FROM Produkty", conn);
                var dt = new DataTable();
                adapter.Fill(dt);
                dgvProdukty.DataSource = dt;
            }
        }

        private void VymazatPole()
        {
            txtNazev.Clear();
            txtPopis.Clear();
            txtDodavatel.Clear();
            numCena.Value = 0;
            numMnozstvi.Value = 0;
        }


        private void btnLoad_Click(object sender, EventArgs e)
        {
            NacistProdukty();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                var cmd = new SQLiteCommand("INSERT INTO Produkty (Nazev, Popis, Cena, Mnozstvi, Dodavatel) VALUES (@nazev, @popis, @cena, @mnozstvi, @dodavatel)", conn);
                cmd.Parameters.AddWithValue("@nazev", txtNazev.Text);
                cmd.Parameters.AddWithValue("@popis", txtPopis.Text);
                cmd.Parameters.AddWithValue("@cena", numCena.Value);
                cmd.Parameters.AddWithValue("@mnozstvi", numMnozstvi.Value);
                cmd.Parameters.AddWithValue("@dodavatel", txtDodavatel.Text);
                cmd.ExecuteNonQuery();
            }

            NacistProdukty();
            MessageBox.Show("Produkt přidán.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProdukty.SelectedRows.Count == 0) return;

            int id = Convert.ToInt32(dgvProdukty.SelectedRows[0].Cells["ID"].Value);

            using (var conn = DatabaseHelper.GetConnection())
            {
                var cmd = new SQLiteCommand("DELETE FROM Produkty WHERE ID=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }

            VymazatPole();
            NacistProdukty();
            MessageBox.Show("Produkt smazán.");
        }

        private void btnUpravit_Click(object sender, EventArgs e)
        {
            if (dgvProdukty.SelectedRows.Count == 0) return;

            int id = Convert.ToInt32(dgvProdukty.SelectedRows[0].Cells["ID"].Value);

            using (var conn = DatabaseHelper.GetConnection())
            {
                var cmd = new SQLiteCommand("UPDATE Produkty SET Nazev=@nazev, Popis=@popis, Cena=@cena, Mnozstvi=@mnozstvi, Dodavatel=@dodavatel WHERE ID=@id", conn);
                cmd.Parameters.AddWithValue("@nazev", txtNazev.Text);
                cmd.Parameters.AddWithValue("@popis", txtPopis.Text);
                cmd.Parameters.AddWithValue("@cena", numCena.Value);
                cmd.Parameters.AddWithValue("@mnozstvi", numMnozstvi.Value);
                cmd.Parameters.AddWithValue("@dodavatel", txtDodavatel.Text);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }

            VymazatPole();
            NacistProdukty();
            MessageBox.Show("Produkt upraven.");
        }

        private void dgvProdukty_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvProdukty.Rows[e.RowIndex];
                txtNazev.Text = row.Cells["Nazev"].Value.ToString();
                txtPopis.Text = row.Cells["Popis"].Value.ToString();
                txtDodavatel.Text = row.Cells["Dodavatel"].Value.ToString();
                numCena.Value = Convert.ToDecimal(row.Cells["Cena"].Value);
                numMnozstvi.Value = Convert.ToDecimal(row.Cells["Mnozstvi"].Value);
            }
        }
    }
}
