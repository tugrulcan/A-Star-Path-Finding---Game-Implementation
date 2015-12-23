namespace A_Star_Path_Finding_Implementation
{
    partial class frmParametre
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
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBaslangicX = new System.Windows.Forms.TextBox();
            this.txtBaslangicY = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBitisY = new System.Windows.Forms.TextBox();
            this.txtBitisX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoyut = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKaydet.Location = new System.Drawing.Point(41, 239);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.txtBaslangicY);
            this.groupBox1.Controls.Add(this.txtBaslangicX);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(131, 77);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fare Konumu";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y";
            // 
            // txtBaslangicX
            // 
            this.txtBaslangicX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBaslangicX.Location = new System.Drawing.Point(56, 19);
            this.txtBaslangicX.Name = "txtBaslangicX";
            this.txtBaslangicX.Size = new System.Drawing.Size(59, 20);
            this.txtBaslangicX.TabIndex = 3;
            // 
            // txtBaslangicY
            // 
            this.txtBaslangicY.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBaslangicY.Location = new System.Drawing.Point(56, 45);
            this.txtBaslangicY.Name = "txtBaslangicY";
            this.txtBaslangicY.Size = new System.Drawing.Size(59, 20);
            this.txtBaslangicY.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.txtBitisY);
            this.groupBox2.Controls.Add(this.txtBitisX);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(131, 77);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Peynir Konumu";
            // 
            // txtBitisY
            // 
            this.txtBitisY.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBitisY.Location = new System.Drawing.Point(56, 45);
            this.txtBitisY.Name = "txtBitisY";
            this.txtBitisY.Size = new System.Drawing.Size(59, 20);
            this.txtBitisY.TabIndex = 4;
            // 
            // txtBitisX
            // 
            this.txtBitisX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBitisX.Location = new System.Drawing.Point(56, 19);
            this.txtBitisX.Name = "txtBitisX";
            this.txtBitisX.Size = new System.Drawing.Size(59, 20);
            this.txtBitisX.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Y";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "X";
            // 
            // txtBoyut
            // 
            this.txtBoyut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoyut.Location = new System.Drawing.Point(68, 194);
            this.txtBoyut.Name = "txtBoyut";
            this.txtBoyut.Size = new System.Drawing.Size(59, 20);
            this.txtBoyut.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Boyut";
            // 
            // frmParametre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(155, 274);
            this.Controls.Add(this.txtBoyut);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnKaydet);
            this.Name = "frmParametre";
            this.Text = "Parametreler";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBaslangicY;
        private System.Windows.Forms.TextBox txtBaslangicX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBitisY;
        private System.Windows.Forms.TextBox txtBitisX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoyut;
        private System.Windows.Forms.Label label5;
    }
}