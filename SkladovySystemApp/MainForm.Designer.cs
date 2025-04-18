namespace SkladovySystemApp
{
    partial class MainForm
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
            this.btnObjednavky = new System.Windows.Forms.Button();
            this.btnProdukty = new System.Windows.Forms.Button();
            this.btnKonec = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObjednavky
            // 
            this.btnObjednavky.BackColor = System.Drawing.Color.GreenYellow;
            this.btnObjednavky.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnObjednavky.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObjednavky.Location = new System.Drawing.Point(96, 177);
            this.btnObjednavky.Name = "btnObjednavky";
            this.btnObjednavky.Size = new System.Drawing.Size(100, 36);
            this.btnObjednavky.TabIndex = 0;
            this.btnObjednavky.Text = "Objednávky";
            this.btnObjednavky.UseVisualStyleBackColor = false;
            this.btnObjednavky.Click += new System.EventHandler(this.btnObjednavky_Click_1);
            // 
            // btnProdukty
            // 
            this.btnProdukty.BackColor = System.Drawing.Color.LimeGreen;
            this.btnProdukty.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProdukty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProdukty.Location = new System.Drawing.Point(201, 177);
            this.btnProdukty.Name = "btnProdukty";
            this.btnProdukty.Size = new System.Drawing.Size(100, 36);
            this.btnProdukty.TabIndex = 1;
            this.btnProdukty.Text = "Produkty";
            this.btnProdukty.UseVisualStyleBackColor = false;
            this.btnProdukty.Click += new System.EventHandler(this.btnProdukty_Click_1);
            // 
            // btnKonec
            // 
            this.btnKonec.BackColor = System.Drawing.Color.Red;
            this.btnKonec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKonec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKonec.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKonec.Location = new System.Drawing.Point(306, 177);
            this.btnKonec.Name = "btnKonec";
            this.btnKonec.Size = new System.Drawing.Size(100, 36);
            this.btnKonec.TabIndex = 2;
            this.btnKonec.Text = "Konec";
            this.btnKonec.UseVisualStyleBackColor = false;
            this.btnKonec.Click += new System.EventHandler(this.btnKonec_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::SkladovySystemApp.Properties.Resources.cancel_1_;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Location = new System.Drawing.Point(306, 71);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 100);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::SkladovySystemApp.Properties.Resources.product;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(201, 71);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SkladovySystemApp.Properties.Resources.order;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(96, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(141, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Skladový Systém";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 264);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnKonec);
            this.Controls.Add(this.btnProdukty);
            this.Controls.Add(this.btnObjednavky);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObjednavky;
        private System.Windows.Forms.Button btnProdukty;
        private System.Windows.Forms.Button btnKonec;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
    }
}

