namespace CabinetMedical.Forms
{
    partial class FormPrincipal
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
            this.cabinetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reteteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cabinetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(974, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cabinetToolStripMenuItem
            // 
            this.cabinetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mediciToolStripMenuItem,
            this.pacientiToolStripMenuItem,
            this.programariToolStripMenuItem,
            this.reteteToolStripMenuItem,
            this.iesireToolStripMenuItem});
            this.cabinetToolStripMenuItem.Name = "cabinetToolStripMenuItem";
            this.cabinetToolStripMenuItem.Size = new System.Drawing.Size(103, 38);
            this.cabinetToolStripMenuItem.Text = "Meniu";
            // 
            // mediciToolStripMenuItem
            // 
            this.mediciToolStripMenuItem.Name = "mediciToolStripMenuItem";
            this.mediciToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.mediciToolStripMenuItem.Text = "Medici";
            this.mediciToolStripMenuItem.Click += new System.EventHandler(this.mediciToolStripMenuItem_Click);
            // 
            // pacientiToolStripMenuItem
            // 
            this.pacientiToolStripMenuItem.Name = "pacientiToolStripMenuItem";
            this.pacientiToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.pacientiToolStripMenuItem.Text = "Pacienti";
            this.pacientiToolStripMenuItem.Click += new System.EventHandler(this.pacientiToolStripMenuItem_Click);
            // 
            // programariToolStripMenuItem
            // 
            this.programariToolStripMenuItem.Name = "programariToolStripMenuItem";
            this.programariToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.programariToolStripMenuItem.Text = "Programari";
            this.programariToolStripMenuItem.Click += new System.EventHandler(this.programariToolStripMenuItem_Click);
            // 
            // reteteToolStripMenuItem
            // 
            this.reteteToolStripMenuItem.Name = "reteteToolStripMenuItem";
            this.reteteToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.reteteToolStripMenuItem.Text = "Retete";
            this.reteteToolStripMenuItem.Click += new System.EventHandler(this.reteteToolStripMenuItem_Click);
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.iesireToolStripMenuItem.Text = "Iesire";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(974, 579);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cabinet medical";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cabinetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reteteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
    }
}

