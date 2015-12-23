namespace A_Star_Path_Finding_Implementation
{
    partial class frmGame
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oyunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametreAyarlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parametreAyarlaToolStripMenuItem,
            this.oyunToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(719, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oyunToolStripMenuItem
            // 
            this.oyunToolStripMenuItem.Name = "oyunToolStripMenuItem";
            this.oyunToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.oyunToolStripMenuItem.Text = "Harita Oluştur";
            this.oyunToolStripMenuItem.Click += new System.EventHandler(this.oyunToolStripMenuItem_Click);
            // 
            // parametreAyarlaToolStripMenuItem
            // 
            this.parametreAyarlaToolStripMenuItem.Name = "parametreAyarlaToolStripMenuItem";
            this.parametreAyarlaToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.parametreAyarlaToolStripMenuItem.Text = "Parametre Ayarla";
            this.parametreAyarlaToolStripMenuItem.Click += new System.EventHandler(this.parametreAyarlaToolStripMenuItem_Click);
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 474);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmGame";
            this.Text = "frmGame";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oyunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametreAyarlaToolStripMenuItem;
    }
}