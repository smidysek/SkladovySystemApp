namespace SkladovySystemApp
{
    partial class FormObjednavky
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
            this.btnSmazatObjednavku = new System.Windows.Forms.Button();
            this.btnNovaObjednavka = new System.Windows.Forms.Button();
            this.dgvObjednavky = new System.Windows.Forms.DataGridView();
            this.txtVyhledat = new System.Windows.Forms.TextBox();
            this.btnVyhledat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjednavky)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSmazatObjednavku
            // 
            this.btnSmazatObjednavku.BackColor = System.Drawing.Color.Red;
            this.btnSmazatObjednavku.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSmazatObjednavku.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSmazatObjednavku.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSmazatObjednavku.Location = new System.Drawing.Point(381, 299);
            this.btnSmazatObjednavku.Name = "btnSmazatObjednavku";
            this.btnSmazatObjednavku.Size = new System.Drawing.Size(94, 37);
            this.btnSmazatObjednavku.TabIndex = 16;
            this.btnSmazatObjednavku.Text = "Smazat";
            this.btnSmazatObjednavku.UseVisualStyleBackColor = false;
            this.btnSmazatObjednavku.Click += new System.EventHandler(this.btnSmazatObjednavku_Click);
            // 
            // btnNovaObjednavka
            // 
            this.btnNovaObjednavka.BackColor = System.Drawing.Color.GreenYellow;
            this.btnNovaObjednavka.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNovaObjednavka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNovaObjednavka.Location = new System.Drawing.Point(12, 299);
            this.btnNovaObjednavka.Name = "btnNovaObjednavka";
            this.btnNovaObjednavka.Size = new System.Drawing.Size(135, 37);
            this.btnNovaObjednavka.TabIndex = 15;
            this.btnNovaObjednavka.Text = "Vytvořit novou";
            this.btnNovaObjednavka.UseVisualStyleBackColor = false;
            this.btnNovaObjednavka.Click += new System.EventHandler(this.btnNovaObjednavka_Click);
            // 
            // dgvObjednavky
            // 
            this.dgvObjednavky.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvObjednavky.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvObjednavky.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObjednavky.Location = new System.Drawing.Point(12, 42);
            this.dgvObjednavky.Name = "dgvObjednavky";
            this.dgvObjednavky.ReadOnly = true;
            this.dgvObjednavky.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvObjednavky.Size = new System.Drawing.Size(463, 233);
            this.dgvObjednavky.TabIndex = 14;
            this.dgvObjednavky.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvObjednavky_CellDoubleClick);
            // 
            // txtVyhledat
            // 
            this.txtVyhledat.Location = new System.Drawing.Point(12, 369);
            this.txtVyhledat.Name = "txtVyhledat";
            this.txtVyhledat.Size = new System.Drawing.Size(193, 20);
            this.txtVyhledat.TabIndex = 17;
            // 
            // btnVyhledat
            // 
            this.btnVyhledat.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnVyhledat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVyhledat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnVyhledat.Location = new System.Drawing.Point(12, 395);
            this.btnVyhledat.Name = "btnVyhledat";
            this.btnVyhledat.Size = new System.Drawing.Size(110, 34);
            this.btnVyhledat.TabIndex = 18;
            this.btnVyhledat.Text = "Vyhledat";
            this.btnVyhledat.UseVisualStyleBackColor = false;
            this.btnVyhledat.Click += new System.EventHandler(this.btnVyhledat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Jméno zákazníka";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(12, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 26);
            this.label6.TabIndex = 20;
            this.label6.Text = "Správa objednávek";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(153, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 37);
            this.button1.TabIndex = 21;
            this.button1.Text = "Zobrazit detail objednávky";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormObjednavky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVyhledat);
            this.Controls.Add(this.txtVyhledat);
            this.Controls.Add(this.btnSmazatObjednavku);
            this.Controls.Add(this.btnNovaObjednavka);
            this.Controls.Add(this.dgvObjednavky);
            this.Name = "FormObjednavky";
            this.Text = "FormObjednavky";
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjednavky)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSmazatObjednavku;
        private System.Windows.Forms.Button btnNovaObjednavka;
        private System.Windows.Forms.DataGridView dgvObjednavky;
        private System.Windows.Forms.TextBox txtVyhledat;
        private System.Windows.Forms.Button btnVyhledat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}