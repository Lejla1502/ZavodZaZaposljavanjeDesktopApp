namespace ZZZ_MIS_UI
{
    partial class Frm_Main
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
            this.kandidatiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kompanijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.oglasiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvještajiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oglasiTotalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aplikacijeTotalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kandidatiToolStripMenuItem,
            this.kompanijeToolStripMenuItem,
            this.oglasiToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.izvještajiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(478, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kandidatiToolStripMenuItem
            // 
            this.kandidatiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem});
            this.kandidatiToolStripMenuItem.Name = "kandidatiToolStripMenuItem";
            this.kandidatiToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.kandidatiToolStripMenuItem.Text = "Kandidati";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // kompanijeToolStripMenuItem
            // 
            this.kompanijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem1});
            this.kompanijeToolStripMenuItem.Name = "kompanijeToolStripMenuItem";
            this.kompanijeToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.kompanijeToolStripMenuItem.Text = "Kompanije";
            // 
            // searchToolStripMenuItem1
            // 
            this.searchToolStripMenuItem1.Name = "searchToolStripMenuItem1";
            this.searchToolStripMenuItem1.Size = new System.Drawing.Size(109, 22);
            this.searchToolStripMenuItem1.Text = "Search";
            this.searchToolStripMenuItem1.Click += new System.EventHandler(this.searchToolStripMenuItem1_Click);
            // 
            // oglasiToolStripMenuItem
            // 
            this.oglasiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem2});
            this.oglasiToolStripMenuItem.Name = "oglasiToolStripMenuItem";
            this.oglasiToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.oglasiToolStripMenuItem.Text = "Oglasi";
            // 
            // searchToolStripMenuItem2
            // 
            this.searchToolStripMenuItem2.Name = "searchToolStripMenuItem2";
            this.searchToolStripMenuItem2.Size = new System.Drawing.Size(109, 22);
            this.searchToolStripMenuItem2.Text = "Search";
            this.searchToolStripMenuItem2.Click += new System.EventHandler(this.searchToolStripMenuItem2_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // izvještajiToolStripMenuItem
            // 
            this.izvještajiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oglasiTotalToolStripMenuItem,
            this.aplikacijeTotalToolStripMenuItem});
            this.izvještajiToolStripMenuItem.Name = "izvještajiToolStripMenuItem";
            this.izvještajiToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.izvještajiToolStripMenuItem.Text = "Izvještaji";
            // 
            // oglasiTotalToolStripMenuItem
            // 
            this.oglasiTotalToolStripMenuItem.Name = "oglasiTotalToolStripMenuItem";
            this.oglasiTotalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.oglasiTotalToolStripMenuItem.Text = "Oglasi total ";
            this.oglasiTotalToolStripMenuItem.Click += new System.EventHandler(this.oglasiTotalToolStripMenuItem_Click);
            // 
            // aplikacijeTotalToolStripMenuItem
            // 
            this.aplikacijeTotalToolStripMenuItem.Name = "aplikacijeTotalToolStripMenuItem";
            this.aplikacijeTotalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aplikacijeTotalToolStripMenuItem.Text = "Aplikacije total";
            this.aplikacijeTotalToolStripMenuItem.Click += new System.EventHandler(this.aplikacijeTotalToolStripMenuItem_Click);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 276);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kandidatiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kompanijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem oglasiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izvještajiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oglasiTotalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aplikacijeTotalToolStripMenuItem;
    }
}