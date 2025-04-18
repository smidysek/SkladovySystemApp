namespace SkladovySystemApp
{
    partial class FormProdukty
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
            this.dgvProdukty = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtNazev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPopis = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDodavatel = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpravit = new System.Windows.Forms.Button();
            this.numMnozstvi = new System.Windows.Forms.NumericUpDown();
            this.numCena = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdukty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMnozstvi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCena)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProdukty
            // 
            this.dgvProdukty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdukty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdukty.Location = new System.Drawing.Point(12, 44);
            this.dgvProdukty.Name = "dgvProdukty";
            this.dgvProdukty.Size = new System.Drawing.Size(689, 150);
            this.dgvProdukty.TabIndex = 0;
            this.dgvProdukty.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdukty_CellClick_1);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.LightGreen;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLoad.Location = new System.Drawing.Point(12, 200);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(689, 34);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Načíst";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtNazev
            // 
            this.txtNazev.Location = new System.Drawing.Point(12, 273);
            this.txtNazev.Name = "txtNazev";
            this.txtNazev.Size = new System.Drawing.Size(170, 20);
            this.txtNazev.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(9, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Název produktu";
            // 
            // txtPopis
            // 
            this.txtPopis.Location = new System.Drawing.Point(360, 272);
            this.txtPopis.Name = "txtPopis";
            this.txtPopis.Size = new System.Drawing.Size(341, 76);
            this.txtPopis.TabIndex = 4;
            this.txtPopis.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(357, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Popis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(185, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cena";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(185, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Množství";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(9, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Dodavatel";
            // 
            // txtDodavatel
            // 
            this.txtDodavatel.Location = new System.Drawing.Point(12, 329);
            this.txtDodavatel.Name = "txtDodavatel";
            this.txtDodavatel.Size = new System.Drawing.Size(170, 20);
            this.txtDodavatel.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.GreenYellow;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdd.Location = new System.Drawing.Point(12, 372);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 37);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Přidat";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(214, 372);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 37);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Smazat";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpravit
            // 
            this.btnUpravit.BackColor = System.Drawing.Color.LimeGreen;
            this.btnUpravit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpravit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUpravit.Location = new System.Drawing.Point(113, 372);
            this.btnUpravit.Name = "btnUpravit";
            this.btnUpravit.Size = new System.Drawing.Size(94, 37);
            this.btnUpravit.TabIndex = 14;
            this.btnUpravit.Text = "Upravit";
            this.btnUpravit.UseVisualStyleBackColor = false;
            this.btnUpravit.Click += new System.EventHandler(this.btnUpravit_Click);
            // 
            // numMnozstvi
            // 
            this.numMnozstvi.Location = new System.Drawing.Point(188, 329);
            this.numMnozstvi.Name = "numMnozstvi";
            this.numMnozstvi.Size = new System.Drawing.Size(120, 20);
            this.numMnozstvi.TabIndex = 15;
            // 
            // numCena
            // 
            this.numCena.Location = new System.Drawing.Point(188, 273);
            this.numCena.Name = "numCena";
            this.numCena.Size = new System.Drawing.Size(120, 20);
            this.numCena.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(12, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 26);
            this.label6.TabIndex = 17;
            this.label6.Text = "Produkty";
            // 
            // FormProdukty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numCena);
            this.Controls.Add(this.numMnozstvi);
            this.Controls.Add(this.btnUpravit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDodavatel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPopis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNazev);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dgvProdukty);
            this.Name = "FormProdukty";
            this.Text = "FormProdukty";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdukty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMnozstvi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdukty;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtNazev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtPopis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDodavatel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpravit;
        private System.Windows.Forms.NumericUpDown numMnozstvi;
        private System.Windows.Forms.NumericUpDown numCena;
        private System.Windows.Forms.Label label6;
    }
}