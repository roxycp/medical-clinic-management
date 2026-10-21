namespace CabinetMedical.Forms
{
    partial class FormAdaugaReteta
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
            this.lblIdProgramare = new System.Windows.Forms.Label();
            this.lblDataEliberare = new System.Windows.Forms.Label();
            this.lblNumePacient = new System.Windows.Forms.Label();
            this.lblNumeMedic = new System.Windows.Forms.Label();
            this.lblMedicamente = new System.Windows.Forms.Label();
            this.lblObservatii = new System.Windows.Forms.Label();
            this.cmbIdProgramare = new System.Windows.Forms.ComboBox();
            this.dtpDataEliberarii = new System.Windows.Forms.DateTimePicker();
            this.txtNumePacient = new System.Windows.Forms.TextBox();
            this.txtNumeMedic = new System.Windows.Forms.TextBox();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.btnAnuleaza = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.rtbMedicamente = new System.Windows.Forms.RichTextBox();
            this.rtbObservatii = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdProgramare
            // 
            this.lblIdProgramare.AutoSize = true;
            this.lblIdProgramare.Location = new System.Drawing.Point(51, 28);
            this.lblIdProgramare.Name = "lblIdProgramare";
            this.lblIdProgramare.Size = new System.Drawing.Size(145, 25);
            this.lblIdProgramare.TabIndex = 0;
            this.lblIdProgramare.Text = "Id programare";
            // 
            // lblDataEliberare
            // 
            this.lblDataEliberare.AutoSize = true;
            this.lblDataEliberare.Location = new System.Drawing.Point(51, 84);
            this.lblDataEliberare.Name = "lblDataEliberare";
            this.lblDataEliberare.Size = new System.Drawing.Size(145, 25);
            this.lblDataEliberare.TabIndex = 1;
            this.lblDataEliberare.Text = "Data eliberarii";
            // 
            // lblNumePacient
            // 
            this.lblNumePacient.AutoSize = true;
            this.lblNumePacient.Location = new System.Drawing.Point(51, 140);
            this.lblNumePacient.Name = "lblNumePacient";
            this.lblNumePacient.Size = new System.Drawing.Size(144, 25);
            this.lblNumePacient.TabIndex = 2;
            this.lblNumePacient.Text = "Nume pacient";
            // 
            // lblNumeMedic
            // 
            this.lblNumeMedic.AutoSize = true;
            this.lblNumeMedic.Location = new System.Drawing.Point(51, 196);
            this.lblNumeMedic.Name = "lblNumeMedic";
            this.lblNumeMedic.Size = new System.Drawing.Size(131, 25);
            this.lblNumeMedic.TabIndex = 3;
            this.lblNumeMedic.Text = "Nume medic";
            // 
            // lblMedicamente
            // 
            this.lblMedicamente.AutoSize = true;
            this.lblMedicamente.Location = new System.Drawing.Point(51, 252);
            this.lblMedicamente.Name = "lblMedicamente";
            this.lblMedicamente.Size = new System.Drawing.Size(141, 25);
            this.lblMedicamente.TabIndex = 4;
            this.lblMedicamente.Text = "Medicamente";
            // 
            // lblObservatii
            // 
            this.lblObservatii.AutoSize = true;
            this.lblObservatii.Location = new System.Drawing.Point(51, 308);
            this.lblObservatii.Name = "lblObservatii";
            this.lblObservatii.Size = new System.Drawing.Size(109, 25);
            this.lblObservatii.TabIndex = 5;
            this.lblObservatii.Text = "Observatii";
            // 
            // cmbIdProgramare
            // 
            this.cmbIdProgramare.FormattingEnabled = true;
            this.cmbIdProgramare.Location = new System.Drawing.Point(285, 28);
            this.cmbIdProgramare.Name = "cmbIdProgramare";
            this.cmbIdProgramare.Size = new System.Drawing.Size(361, 33);
            this.cmbIdProgramare.TabIndex = 6;
            // 
            // dtpDataEliberarii
            // 
            this.dtpDataEliberarii.Location = new System.Drawing.Point(285, 85);
            this.dtpDataEliberarii.Name = "dtpDataEliberarii";
            this.dtpDataEliberarii.Size = new System.Drawing.Size(361, 31);
            this.dtpDataEliberarii.TabIndex = 7;
            // 
            // txtNumePacient
            // 
            this.txtNumePacient.Location = new System.Drawing.Point(285, 140);
            this.txtNumePacient.Name = "txtNumePacient";
            this.txtNumePacient.ReadOnly = true;
            this.txtNumePacient.Size = new System.Drawing.Size(361, 31);
            this.txtNumePacient.TabIndex = 8;
            // 
            // txtNumeMedic
            // 
            this.txtNumeMedic.Location = new System.Drawing.Point(285, 195);
            this.txtNumeMedic.Name = "txtNumeMedic";
            this.txtNumeMedic.ReadOnly = true;
            this.txtNumeMedic.Size = new System.Drawing.Size(361, 31);
            this.txtNumeMedic.TabIndex = 9;
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalveaza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSalveaza.Location = new System.Drawing.Point(74, 371);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(175, 60);
            this.btnSalveaza.TabIndex = 12;
            this.btnSalveaza.Text = "Salveaza";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // btnAnuleaza
            // 
            this.btnAnuleaza.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnuleaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnuleaza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAnuleaza.Location = new System.Drawing.Point(428, 371);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(175, 60);
            this.btnAnuleaza.TabIndex = 13;
            this.btnAnuleaza.Text = "Anuleaza";
            this.btnAnuleaza.UseVisualStyleBackColor = true;
            this.btnAnuleaza.Click += new System.EventHandler(this.btnAnuleaza_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // rtbMedicamente
            // 
            this.rtbMedicamente.Location = new System.Drawing.Point(285, 239);
            this.rtbMedicamente.Name = "rtbMedicamente";
            this.rtbMedicamente.Size = new System.Drawing.Size(361, 33);
            this.rtbMedicamente.TabIndex = 14;
            this.rtbMedicamente.Text = "";
            // 
            // rtbObservatii
            // 
            this.rtbObservatii.Location = new System.Drawing.Point(285, 299);
            this.rtbObservatii.Name = "rtbObservatii";
            this.rtbObservatii.Size = new System.Drawing.Size(361, 33);
            this.rtbObservatii.TabIndex = 15;
            this.rtbObservatii.Text = "";
            // 
            // FormAdaugaReteta
            // 
            this.AcceptButton = this.btnSalveaza;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnuleaza;
            this.ClientSize = new System.Drawing.Size(674, 479);
            this.Controls.Add(this.rtbObservatii);
            this.Controls.Add(this.rtbMedicamente);
            this.Controls.Add(this.btnAnuleaza);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.txtNumeMedic);
            this.Controls.Add(this.txtNumePacient);
            this.Controls.Add(this.dtpDataEliberarii);
            this.Controls.Add(this.cmbIdProgramare);
            this.Controls.Add(this.lblObservatii);
            this.Controls.Add(this.lblMedicamente);
            this.Controls.Add(this.lblNumeMedic);
            this.Controls.Add(this.lblNumePacient);
            this.Controls.Add(this.lblDataEliberare);
            this.Controls.Add(this.lblIdProgramare);
            this.Name = "FormAdaugaReteta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAdaugaReteta";
            this.Load += new System.EventHandler(this.FormAdaugaReteta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdProgramare;
        private System.Windows.Forms.Label lblDataEliberare;
        private System.Windows.Forms.Label lblNumePacient;
        private System.Windows.Forms.Label lblNumeMedic;
        private System.Windows.Forms.Label lblMedicamente;
        private System.Windows.Forms.Label lblObservatii;
        private System.Windows.Forms.ComboBox cmbIdProgramare;
        private System.Windows.Forms.DateTimePicker dtpDataEliberarii;
        private System.Windows.Forms.TextBox txtNumePacient;
        private System.Windows.Forms.TextBox txtNumeMedic;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.Button btnAnuleaza;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.RichTextBox rtbObservatii;
        private System.Windows.Forms.RichTextBox rtbMedicamente;
    }
}