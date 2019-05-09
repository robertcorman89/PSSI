namespace PSSI
{
    partial class Anotimpuri_Vara
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
            this.Primavara = new System.Windows.Forms.PictureBox();
            this.Toamna = new System.Windows.Forms.PictureBox();
            this.Iarna = new System.Windows.Forms.PictureBox();
            this.Vara = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Primavara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Toamna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Iarna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vara)).BeginInit();
            this.SuspendLayout();
            // 
            // Primavara
            // 
            this.Primavara.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Primavara.Image = global::PSSI.Properties.Resources.spring_season_clipart_8;
            this.Primavara.Location = new System.Drawing.Point(690, 313);
            this.Primavara.Name = "Primavara";
            this.Primavara.Size = new System.Drawing.Size(170, 170);
            this.Primavara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Primavara.TabIndex = 0;
            this.Primavara.TabStop = false;
            this.Primavara.Click += new System.EventHandler(this.Primavara_Click);
            // 
            // Toamna
            // 
            this.Toamna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Toamna.Image = global::PSSI.Properties.Resources._899798;
            this.Toamna.Location = new System.Drawing.Point(318, 313);
            this.Toamna.Name = "Toamna";
            this.Toamna.Size = new System.Drawing.Size(170, 170);
            this.Toamna.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Toamna.TabIndex = 1;
            this.Toamna.TabStop = false;
            this.Toamna.Click += new System.EventHandler(this.Toamna_Click);
            // 
            // Iarna
            // 
            this.Iarna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Iarna.Image = global::PSSI.Properties.Resources.winter1;
            this.Iarna.Location = new System.Drawing.Point(318, 67);
            this.Iarna.Name = "Iarna";
            this.Iarna.Size = new System.Drawing.Size(170, 170);
            this.Iarna.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Iarna.TabIndex = 2;
            this.Iarna.TabStop = false;
            this.Iarna.Click += new System.EventHandler(this.Iarna_Click);
            // 
            // Vara
            // 
            this.Vara.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Vara.Image = global::PSSI.Properties.Resources._104561_yana;
            this.Vara.Location = new System.Drawing.Point(690, 67);
            this.Vara.Name = "Vara";
            this.Vara.Size = new System.Drawing.Size(170, 170);
            this.Vara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Vara.TabIndex = 3;
            this.Vara.TabStop = false;
            this.Vara.Click += new System.EventHandler(this.Vara_Click);
            // 
            // Anotimpuri_Vara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PSSI.Properties.Resources.anotimpuri_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.Vara);
            this.Controls.Add(this.Iarna);
            this.Controls.Add(this.Toamna);
            this.Controls.Add(this.Primavara);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Anotimpuri_Vara";
            this.Text = "Anotimpuri_Vara";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.Primavara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Toamna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Iarna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vara)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Primavara;
        private System.Windows.Forms.PictureBox Toamna;
        private System.Windows.Forms.PictureBox Iarna;
        private System.Windows.Forms.PictureBox Vara;
    }
}