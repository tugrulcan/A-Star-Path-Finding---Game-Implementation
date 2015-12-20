namespace A_Star_Path_Finding_Implementation
{
    partial class frmBoard
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
            this.components = new System.ComponentModel.Container();
            this.dtgBoard = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgBoard
            // 
            this.dtgBoard.AllowUserToAddRows = false;
            this.dtgBoard.AllowUserToDeleteRows = false;
            this.dtgBoard.AllowUserToResizeColumns = false;
            this.dtgBoard.AllowUserToResizeRows = false;
            this.dtgBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgBoard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgBoard.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgBoard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgBoard.CausesValidation = false;
            this.dtgBoard.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dtgBoard.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgBoard.ColumnHeadersHeight = 20;
            this.dtgBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgBoard.ColumnHeadersVisible = false;
            this.dtgBoard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtgBoard.EnableHeadersVisualStyles = false;
            this.dtgBoard.Location = new System.Drawing.Point(23, 22);
            this.dtgBoard.Name = "dtgBoard";
            this.dtgBoard.ReadOnly = true;
            this.dtgBoard.RowHeadersVisible = false;
            this.dtgBoard.RowHeadersWidth = 22;
            this.dtgBoard.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Tan;
            this.dtgBoard.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dtgBoard.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Chocolate;
            this.dtgBoard.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtgBoard.RowTemplate.Height = 40;
            this.dtgBoard.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dtgBoard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgBoard.ShowCellErrors = false;
            this.dtgBoard.ShowCellToolTips = false;
            this.dtgBoard.ShowEditingIcon = false;
            this.dtgBoard.ShowRowErrors = false;
            this.dtgBoard.Size = new System.Drawing.Size(556, 369);
            this.dtgBoard.TabIndex = 0;
            this.dtgBoard.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgBoard_CellContentClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 412);
            this.Controls.Add(this.dtgBoard);
            this.Name = "frmBoard";
            this.Text = "frmBoard";
            this.Load += new System.EventHandler(this.frmBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgBoard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgBoard;
        private System.Windows.Forms.Timer timer1;
    }
}