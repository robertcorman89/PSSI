namespace PSSI
{
    partial class PozitiiSpatialeJos
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
            this.Sus = new System.Windows.Forms.PictureBox();
            this.Jos = new System.Windows.Forms.PictureBox();
            this.Stanga = new System.Windows.Forms.PictureBox();
            this.Dreapta = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.square = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Sus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stanga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dreapta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.square)).BeginInit();
            this.SuspendLayout();
            // 
            // Sus
            // 
            this.Sus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Sus.BackColor = System.Drawing.Color.Transparent;
            this.Sus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sus.Image = global::PSSI.Properties.Resources.symbol_arrow_up_blue_direction_5121;
            this.Sus.Location = new System.Drawing.Point(582, 157);
            this.Sus.Name = "Sus";
            this.Sus.Size = new System.Drawing.Size(90, 90);
            this.Sus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Sus.TabIndex = 0;
            this.Sus.TabStop = false;
            this.Sus.Click += new System.EventHandler(this.Sus_Click);
            // 
            // Jos
            // 
            this.Jos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Jos.BackColor = System.Drawing.Color.Transparent;
            this.Jos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Jos.Image = global::PSSI.Properties.Resources.Download1;
            this.Jos.Location = new System.Drawing.Point(956, 157);
            this.Jos.Name = "Jos";
            this.Jos.Size = new System.Drawing.Size(90, 90);
            this.Jos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Jos.TabIndex = 1;
            this.Jos.TabStop = false;
            this.Jos.Click += new System.EventHandler(this.Jos_Click);
            // 
            // Stanga
            // 
            this.Stanga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Stanga.BackColor = System.Drawing.Color.Transparent;
            this.Stanga.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Stanga.Image = global::PSSI.Properties.Resources.Download_Left_Arrow_PNG_HD1;
            this.Stanga.Location = new System.Drawing.Point(582, 495);
            this.Stanga.Name = "Stanga";
            this.Stanga.Size = new System.Drawing.Size(90, 90);
            this.Stanga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Stanga.TabIndex = 2;
            this.Stanga.TabStop = false;
            this.Stanga.Click += new System.EventHandler(this.Stanga_Click);
            // 
            // Dreapta
            // 
            this.Dreapta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Dreapta.BackColor = System.Drawing.Color.Transparent;
            this.Dreapta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dreapta.Image = global::PSSI.Properties.Resources.arrow_right_yellow1;
            this.Dreapta.Location = new System.Drawing.Point(956, 495);
            this.Dreapta.Name = "Dreapta";
            this.Dreapta.Size = new System.Drawing.Size(90, 90);
            this.Dreapta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dreapta.TabIndex = 3;
            this.Dreapta.TabStop = false;
            this.Dreapta.Click += new System.EventHandler(this.Dreapta_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::PSSI.Properties.Resources._11077901;
            this.pictureBox5.Location = new System.Drawing.Point(721, 237);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(200, 200);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // square
            // 
            this.square.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.square.BackColor = System.Drawing.Color.Transparent;
            this.square.Image = global::PSSI.Properties.Resources.red_square_hi1;
            this.square.Location = new System.Drawing.Point(778, 443);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(80, 80);
            this.square.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.square.TabIndex = 5;
            this.square.TabStop = false;
            // 
            // PozitiiSpatialeJos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PSSI.Properties.Resources._11c2b9c85b9574959226cdebea278a17;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.square);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.Dreapta);
            this.Controls.Add(this.Stanga);
            this.Controls.Add(this.Jos);
            this.Controls.Add(this.Sus);
            this.DoubleBuffered = true;
            this.Name = "PozitiiSpatialeJos";
            this.Text = "PozitiiSpatialeJos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.Sus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stanga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dreapta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.square)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Sus;
        private System.Windows.Forms.PictureBox Jos;
        private System.Windows.Forms.PictureBox Stanga;
        private System.Windows.Forms.PictureBox Dreapta;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox square;
    }
}