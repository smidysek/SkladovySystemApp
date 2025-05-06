namespace SkladovySystemApp
{
    partial class DetailObjednavky
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
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblCelkovaCena = new System.Windows.Forms.Label();
            this.dgvPolozky = new System.Windows.Forms.DataGridView();
            this.btnZavrit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolozky)).BeginInit();
            this.SuspendLayout();
            // 
            // lblZakaznik
            // 
            this.lblZakaznik.AutoSize = true;
            this.lblZakaznik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblZakaznik.Location = new System.Drawing.Point(31, 59);
            this.lblZakaznik.Name = "lblZakaznik";
            this.lblZakaznik.Size = new System.Drawing.Size(73, 17);
            this.lblZakaznik.TabIndex = 0;
            this.lblZakaznik.Text = "Zákazník";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDatum.Location = new System.Drawing.Point(31, 87);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(54, 17);
            this.lblDatum.TabIndex = 1;
            this.lblDatum.Text = "Datum";
            // 
            // lblCelkovaCena
            // 
            this.lblCelkovaCena.AutoSize = true;
            this.lblCelkovaCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCelkovaCena.Location = new System.Drawing.Point(31, 115);
            this.lblCelkovaCena.Name = "lblCelkovaCena";
            this.lblCelkovaCena.Size = new System.Drawing.Size(105, 17);
            this.lblCelkovaCena.TabIndex = 2;
            this.lblCelkovaCena.Text = "Celková cena";
            // 
            // dgvPolozky
            // 
            this.dgvPolozky.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPolozky.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPolozky.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPolozky.Location = new System.Drawing.Point(34, 145);
            this.dgvPolozky.Name = "dgvPolozky";
            this.dgvPolozky.ReadOnly = true;
            this.dgvPolozky.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPolozky.Size = new System.Drawing.Size(462, 150);
            this.dgvPolozky.TabIndex = 3;
            // 
            // btnZavrit
            // 
            this.btnZavrit.BackColor = System.Drawing.Color.Red;
            this.btnZavrit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnZavrit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZavrit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnZavrit.Location = new System.Drawing.Point(34, 315);
            this.btnZavrit.Name = "btnZavrit";
            this.btnZavrit.Size = new System.Drawing.Size(89, 33);
            this.btnZavrit.TabIndex = 4;
            this.btnZavrit.Text = "Zavřít";
            this.btnZavrit.UseVisualStyleBackColor = false;
            this.btnZavrit.Click += new System.EventHandler(this.btnZavrit_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Detail objednávky";
            // 
            // DetailObjednavky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 364);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnZavrit);
            this.Controls.Add(this.dgvPolozky);
            this.Controls.Add(this.lblCelkovaCena);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblZakaznik);
            this.Name = "DetailObjednavky";
            this.Text = "DetailObjednavky";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolozky)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblZakaznik;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblCelkovaCena;
        private System.Windows.Forms.DataGridView dgvPolozky;
        private System.Windows.Forms.Button btnZavrit;
        private System.Windows.Forms.Label label1;
    }
}