namespace CabinetMedical.Forms
{
    partial class FormRetete
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
            this.dgvRetete = new System.Windows.Forms.DataGridView();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnEditeaza = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRetete)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRetete
            // 
            this.dgvRetete.AllowUserToAddRows = false;
            this.dgvRetete.AllowUserToDeleteRows = false;
            this.dgvRetete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRetete.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRetete.ColumnHeadersHeight = 46;
            this.dgvRetete.Location = new System.Drawing.Point(5, 12);
            this.dgvRetete.MultiSelect = false;
            this.dgvRetete.Name = "dgvRetete";
            this.dgvRetete.ReadOnly = true;
            this.dgvRetete.RowHeadersWidth = 82;
            this.dgvRetete.RowTemplate.Height = 33;
            this.dgvRetete.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRetete.Size = new System.Drawing.Size(957, 403);
            this.dgvRetete.TabIndex = 0;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAdauga.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdauga.Location = new System.Drawing.Point(104, 444);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(204, 45);
            this.btnAdauga.TabIndex = 1;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnEditeaza
            // 
            this.btnEditeaza.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEditeaza.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnEditeaza.Location = new System.Drawing.Point(378, 444);
            this.btnEditeaza.Name = "btnEditeaza";
            this.btnEditeaza.Size = new System.Drawing.Size(204, 45);
            this.btnEditeaza.TabIndex = 2;
            this.btnEditeaza.Text = "Editeaza";
            this.btnEditeaza.UseVisualStyleBackColor = true;
            this.btnEditeaza.Click += new System.EventHandler(this.btnEditeaza_Click);
            // 
            // btnSterge
            // 
            this.btnSterge.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSterge.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSterge.Location = new System.Drawing.Point(655, 444);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(204, 45);
            this.btnSterge.TabIndex = 3;
            this.btnSterge.Text = "Sterge";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // FormRetete
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(974, 579);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnEditeaza);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.dgvRetete);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "FormRetete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Retete";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormRetete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRetete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRetete;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnEditeaza;
        private System.Windows.Forms.Button btnSterge;
    }
}