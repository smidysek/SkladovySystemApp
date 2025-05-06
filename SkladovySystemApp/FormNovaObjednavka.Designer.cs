namespace SkladovySystemApp
{
    partial class FormNovaObjednavka
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblZakaznik = new System.Windows.Forms.Label();
            this.txtZakaznik = new System.Windows.Forms.TextBox();
            this.lblDatum = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.cmbProdukt = new System.Windows.Forms.ComboBox();
            this.numMnozstvi = new System.Windows.Forms.NumericUpDown();
            this.btnPridatPolozku = new System.Windows.Forms.Button();
            this.dgvPolozky = new System.Windows.Forms.DataGridView();
            this.nazev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnozstvi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaCelkem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCelkovaCena = new System.Windows.Forms.Label();
            this.btnUlozit = new System.Windows.Forms.Button();
            this.btnZrusit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numMnozstvi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolozky)).BeginInit();
            this.SuspendLayout();
            // 
            // lblZakaznik
            // 
            this.lblZakaznik.AutoSize = true;
            this.lblZakaznik.Location = new System.Drawing.Point(17, 10);
            this.lblZakaznik.Name = "lblZakaznik";
            this.lblZakaznik.Size = new System.Drawing.Size(53, 13);
            this.lblZakaznik.TabIndex = 0;
            this.lblZakaznik.Text = "Zákazník";
            // 
            // txtZakaznik
            // 
            this.txtZakaznik.Location = new System.Drawing.Point(17, 26);
            this.txtZakaznik.Name = "txtZakaznik";
            this.txtZakaznik.Size = new System.Drawing.Size(203, 20);
            this.txtZakaznik.TabIndex = 1;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(14, 57);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(38, 13);
            this.lblDatum.TabIndex = 2;
            this.lblDatum.Text = "Datum";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(17, 73);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(200, 20);
            this.dtpDatum.TabIndex = 3;
            // 
            // cmbProdukt
            // 
            this.cmbProdukt.FormattingEnabled = true;
            this.cmbProdukt.Location = new System.Drawing.Point(276, 25);
            this.cmbProdukt.Name = "cmbProdukt";
            this.cmbProdukt.Size = new System.Drawing.Size(155, 21);
            this.cmbProdukt.TabIndex = 4;
            // 
            // numMnozstvi
            // 
            this.numMnozstvi.Location = new System.Drawing.Point(276, 73);
            this.numMnozstvi.Name = "numMnozstvi";
            this.numMnozstvi.Size = new System.Drawing.Size(155, 20);
            this.numMnozstvi.TabIndex = 5;
            // 
            // btnPridatPolozku
            // 
            this.btnPridatPolozku.BackColor = System.Drawing.Color.GreenYellow;
            this.btnPridatPolozku.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPridatPolozku.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPridatPolozku.Location = new System.Drawing.Point(276, 99);
            this.btnPridatPolozku.Name = "btnPridatPolozku";
            this.btnPridatPolozku.Size = new System.Drawing.Size(155, 34);
            this.btnPridatPolozku.TabIndex = 6;
            this.btnPridatPolozku.Text = "Přidat položku";
            this.btnPridatPolozku.UseVisualStyleBackColor = false;
            this.btnPridatPolozku.Click += new System.EventHandler(this.btnPridatPolozku_Click);
            // 
            // dgvPolozky
            // 
            this.dgvPolozky.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPolozky.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPolozky.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazev,
            this.cena,
            this.mnozstvi,
            this.cenaCelkem});
            this.dgvPolozky.Location = new System.Drawing.Point(15, 150);
            this.dgvPolozky.Name = "dgvPolozky";
            this.dgvPolozky.Size = new System.Drawing.Size(443, 150);
            this.dgvPolozky.TabIndex = 7;
            // 
            // nazev
            // 
            this.nazev.HeaderText = "Název produktu";
            this.nazev.Name = "nazev";
            // 
            // cena
            // 
            this.cena.HeaderText = "Cena za kus";
            this.cena.Name = "cena";
            // 
            // mnozstvi
            // 
            this.mnozstvi.HeaderText = "Množství";
            this.mnozstvi.Name = "mnozstvi";
            // 
            // cenaCelkem
            // 
            this.cenaCelkem.HeaderText = "Celková cena";
            this.cenaCelkem.Name = "cenaCelkem";
            // 
            // lblCelkovaCena
            // 
            this.lblCelkovaCena.AutoSize = true;
            this.lblCelkovaCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCelkovaCena.ForeColor = System.Drawing.Color.Red;
            this.lblCelkovaCena.Location = new System.Drawing.Point(12, 317);
            this.lblCelkovaCena.Name = "lblCelkovaCena";
            this.lblCelkovaCena.Size = new System.Drawing.Size(147, 17);
            this.lblCelkovaCena.TabIndex = 8;
            this.lblCelkovaCena.Text = "Celková cena: 0 Kč";
            // 
            // btnUlozit
            // 
            this.btnUlozit.BackColor = System.Drawing.Color.LimeGreen;
            this.btnUlozit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUlozit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUlozit.Location = new System.Drawing.Point(15, 353);
            this.btnUlozit.Name = "btnUlozit";
            this.btnUlozit.Size = new System.Drawing.Size(98, 34);
            this.btnUlozit.TabIndex = 9;
            this.btnUlozit.Text = "Uložit";
            this.btnUlozit.UseVisualStyleBackColor = false;
            this.btnUlozit.Click += new System.EventHandler(this.btnUlozit_Click);
            // 
            // btnZrusit
            // 
            this.btnZrusit.BackColor = System.Drawing.Color.Red;
            this.btnZrusit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnZrusit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZrusit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnZrusit.Location = new System.Drawing.Point(119, 353);
            this.btnZrusit.Name = "btnZrusit";
            this.btnZrusit.Size = new System.Drawing.Size(98, 34);
            this.btnZrusit.TabIndex = 10;
            this.btnZrusit.Text = "Zrušit";
            this.btnZrusit.UseVisualStyleBackColor = false;
            this.btnZrusit.Click += new System.EventHandler(this.btnZrusit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Výběr produktu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Počet kusů";
            // 
            // FormNovaObjednavka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 405);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnZrusit);
            this.Controls.Add(this.btnUlozit);
            this.Controls.Add(this.lblCelkovaCena);
            this.Controls.Add(this.dgvPolozky);
            this.Controls.Add(this.btnPridatPolozku);
            this.Controls.Add(this.numMnozstvi);
            this.Controls.Add(this.cmbProdukt);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.txtZakaznik);
            this.Controls.Add(this.lblZakaznik);
            this.Name = "FormNovaObjednavka";
            this.Text = "FormNovaObjednavka";
            ((System.ComponentModel.ISupportInitialize)(this.numMnozstvi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolozky)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblZakaznik;
        private System.Windows.Forms.TextBox txtZakaznik;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.ComboBox cmbProdukt;
        private System.Windows.Forms.NumericUpDown numMnozstvi;
        private System.Windows.Forms.Button btnPridatPolozku;
        private System.Windows.Forms.DataGridView dgvPolozky;
        private System.Windows.Forms.Label lblCelkovaCena;
        private System.Windows.Forms.Button btnUlozit;
        private System.Windows.Forms.Button btnZrusit;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazev;
        private System.Windows.Forms.DataGridViewTextBoxColumn cena;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnozstvi;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaCelkem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}