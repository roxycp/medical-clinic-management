namespace CabinetMedical.Forms
{
    partial class FormAdaugaProgramare
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
            this.lblPacient = new System.Windows.Forms.Label();
            this.lblMedic = new System.Windows.Forms.Label();
            this.lblDataProgramarii = new System.Windows.Forms.Label();
            this.lblDiagnostic = new System.Windows.Forms.Label();
            this.lblObservatii = new System.Windows.Forms.Label();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.btnAnuleaza = new System.Windows.Forms.Button();
            this.txtDiagnostic = new System.Windows.Forms.TextBox();
            this.txtObservatii = new System.Windows.Forms.TextBox();
            this.dtpDataProgramarii = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbPacient = new System.Windows.Forms.ComboBox();
            this.cmbMedic = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPacient
            // 
            this.lblPacient.AutoSize = true;
            this.lblPacient.Location = new System.Drawing.Point(54, 73);
            this.lblPacient.Name = "lblPacient";
            this.lblPacient.Size = new System.Drawing.Size(84, 25);
            this.lblPacient.TabIndex = 0;
            this.lblPacient.Text = "Pacient";
            // 
            // lblMedic
            // 
            this.lblMedic.AutoSize = true;
            this.lblMedic.Location = new System.Drawing.Point(54, 122);
            this.lblMedic.Name = "lblMedic";
            this.lblMedic.Size = new System.Drawing.Size(70, 25);
            this.lblMedic.TabIndex = 1;
            this.lblMedic.Text = "Medic";
            // 
            // lblDataProgramarii
            // 
            this.lblDataProgramarii.AutoSize = true;
            this.lblDataProgramarii.Location = new System.Drawing.Point(54, 171);
            this.lblDataProgramarii.Name = "lblDataProgramarii";
            this.lblDataProgramarii.Size = new System.Drawing.Size(173, 25);
            this.lblDataProgramarii.TabIndex = 2;
            this.lblDataProgramarii.Text = "Data Programarii";
            // 
            // lblDiagnostic
            // 
            this.lblDiagnostic.AutoSize = true;
            this.lblDiagnostic.Location = new System.Drawing.Point(54, 220);
            this.lblDiagnostic.Name = "lblDiagnostic";
            this.lblDiagnostic.Size = new System.Drawing.Size(113, 25);
            this.lblDiagnostic.TabIndex = 3;
            this.lblDiagnostic.Text = "Diagnostic";
            // 
            // lblObservatii
            // 
            this.lblObservatii.AutoSize = true;
            this.lblObservatii.Location = new System.Drawing.Point(54, 269);
            this.lblObservatii.Name = "lblObservatii";
            this.lblObservatii.Size = new System.Drawing.Size(109, 25);
            this.lblObservatii.TabIndex = 4;
            this.lblObservatii.Text = "Observatii";
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalveaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalveaza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSalveaza.Location = new System.Drawing.Point(100, 386);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(175, 60);
            this.btnSalveaza.TabIndex = 7;
            this.btnSalveaza.Text = "Salveaza";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // btnAnuleaza
            // 
            this.btnAnuleaza.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnuleaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnuleaza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAnuleaza.Location = new System.Drawing.Point(410, 386);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(175, 60);
            this.btnAnuleaza.TabIndex = 8;
            this.btnAnuleaza.Text = "Anuleaza";
            this.btnAnuleaza.UseVisualStyleBackColor = true;
            this.btnAnuleaza.Click += new System.EventHandler(this.btnAnuleaza_Click);
            // 
            // txtDiagnostic
            // 
            this.txtDiagnostic.Location = new System.Drawing.Point(254, 222);
            this.txtDiagnostic.Multiline = true;
            this.txtDiagnostic.Name = "txtDiagnostic";
            this.txtDiagnostic.Size = new System.Drawing.Size(392, 31);
            this.txtDiagnostic.TabIndex = 11;
            // 
            // txtObservatii
            // 
            this.txtObservatii.Location = new System.Drawing.Point(254, 273);
            this.txtObservatii.Multiline = true;
            this.txtObservatii.Name = "txtObservatii";
            this.txtObservatii.Size = new System.Drawing.Size(392, 31);
            this.txtObservatii.TabIndex = 12;
            // 
            // dtpDataProgramarii
            // 
            this.dtpDataProgramarii.Location = new System.Drawing.Point(254, 171);
            this.dtpDataProgramarii.Name = "dtpDataProgramarii";
            this.dtpDataProgramarii.Size = new System.Drawing.Size(392, 31);
            this.dtpDataProgramarii.TabIndex = 15;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cmbPacient
            // 
            this.cmbPacient.FormattingEnabled = true;
            this.cmbPacient.Location = new System.Drawing.Point(254, 65);
            this.cmbPacient.Name = "cmbPacient";
            this.cmbPacient.Size = new System.Drawing.Size(392, 33);
            this.cmbPacient.TabIndex = 16;
            // 
            // cmbMedic
            // 
            this.cmbMedic.FormattingEnabled = true;
            this.cmbMedic.Location = new System.Drawing.Point(254, 118);
            this.cmbMedic.Name = "cmbMedic";
            this.cmbMedic.Size = new System.Drawing.Size(392, 33);
            this.cmbMedic.TabIndex = 17;
            // 
            // FormAdaugaProgramare
            // 
            this.AcceptButton = this.btnSalveaza;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnuleaza;
            this.ClientSize = new System.Drawing.Size(674, 479);
            this.Controls.Add(this.cmbMedic);
            this.Controls.Add(this.cmbPacient);
            this.Controls.Add(this.dtpDataProgramarii);
            this.Controls.Add(this.txtObservatii);
            this.Controls.Add(this.txtDiagnostic);
            this.Controls.Add(this.btnAnuleaza);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.lblObservatii);
            this.Controls.Add(this.lblDiagnostic);
            this.Controls.Add(this.lblDataProgramarii);
            this.Controls.Add(this.lblMedic);
            this.Controls.Add(this.lblPacient);
            this.Name = "FormAdaugaProgramare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Adauga Programare";
            this.Load += new System.EventHandler(this.FormAdaugaProgramare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPacient;
        private System.Windows.Forms.Label lblMedic;
        private System.Windows.Forms.Label lblDataProgramarii;
        private System.Windows.Forms.Label lblDiagnostic;
        private System.Windows.Forms.Label lblObservatii;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.Button btnAnuleaza;
        private System.Windows.Forms.TextBox txtDiagnostic;
        private System.Windows.Forms.TextBox txtObservatii;
        private System.Windows.Forms.DateTimePicker dtpDataProgramarii;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cmbMedic;
        private System.Windows.Forms.ComboBox cmbPacient;
    }
}