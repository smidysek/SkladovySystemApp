using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace SkladovySystemApp
{
    internal class DatabaseHelper
    {
        private static string dbPath = "sklad.db";
        private static string connStr = $"Data Source={dbPath};Version=3;";

        public static void InicializujDatabazi()
        {
            if (!File.Exists(dbPath))
            {
                SQLiteConnection.CreateFile(dbPath);

                using (var conn = new SQLiteConnection(connStr))
                {
                    conn.Open();

                    // Povol foreign keys + WAL
                    new SQLiteCommand("PRAGMA foreign_keys = ON;", conn).ExecuteNonQuery();
                    new SQLiteCommand("PRAGMA journal_mode = WAL;", conn).ExecuteNonQuery();

                    var cmd = conn.CreateCommand();
                    cmd.CommandText = @"
                        CREATE TABLE Produkty (
                            ID INTEGER PRIMARY KEY AUTOINCREMENT,
                            Nazev TEXT,
                            Popis TEXT,
                            Cena REAL,
                            Mnozstvi INTEGER,
                            Dodavatel TEXT
                        );

                        CREATE TABLE Objednavky (
                            ID INTEGER PRIMARY KEY AUTOINCREMENT,
                            Datum TEXT,
                            Zakaznik TEXT,
                            CelkovaCena REAL
                        );

                        CREATE TABLE ObjednavkaPolozky (
                            ID INTEGER PRIMARY KEY AUTOINCREMENT,
                            ObjednavkaID INTEGER,
                            ProduktID INTEGER,
                            Mnozstvi INTEGER,
                            CenaZaKus REAL,
                            FOREIGN KEY (ObjednavkaID) REFERENCES Objednavky(ID),
                            FOREIGN KEY (ProduktID) REFERENCES Produkty(ID)
                        );
                    ";
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Databáze a tabulky byly vytvořeny.");
            }
        }

        public static void EnableWAL(SQLiteConnection conn)
        {
            using (var cmd = new SQLiteCommand("PRAGMA journal_mode=WAL;", conn))
            {
                cmd.ExecuteNonQuery();
            }
        }


        public static SQLiteConnection GetConnection()
        {
            var conn = new SQLiteConnection(connStr);
            conn.Open();

            EnableWAL(conn); // aktivace WAL

            // Automatické nastavení každého připojení
            new SQLiteCommand("PRAGMA foreign_keys = ON;", conn).ExecuteNonQuery();
            new SQLiteCommand("PRAGMA journal_mode = WAL;", conn).ExecuteNonQuery();

            return conn;
        }
    }
}
