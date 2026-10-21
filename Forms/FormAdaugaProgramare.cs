using CabinetMedical.Models;
using CabinetMedical.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CabinetMedical.Forms
{
    public partial class FormAdaugaProgramare : Form
    {
        private Programare programareDeEditat;
        public Programare ProgramareRezultat { get; set; }
        public FormAdaugaProgramare(Programare programare)
        {
            InitializeComponent();
            programareDeEditat = programare;
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool ok = true;

            if (cmbPacient.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbPacient, "Selectati un pacient");
                ok = false;
            }

            if (cmbMedic.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbMedic, "Selectati un medic");
                ok = false;
            }

            if (!ok) { return; }

            int id = 0;
            if (programareDeEditat != null)
            {
                id = programareDeEditat.Id;
            }

            ProgramareRezultat = new Programare
            {
                Id = id,
                IdPacient = ((Pacient)cmbPacient.SelectedItem).Id,
                IdMedic = ((Medic)cmbMedic.SelectedItem).Id,
                DataProgramarii = dtpDataProgramarii.Value,
                Diagnostic = txtDiagnostic.Text.Trim(),
                Observatii = txtObservatii.Text.Trim(),
                NumePacient = ((Pacient)cmbPacient.SelectedItem).NumeComplet,
                NumeMedic = ((Medic)cmbMedic.SelectedItem).NumeComplet,
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnAnuleaza_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void FormAdaugaProgramare_Load(object sender, EventArgs e)
        {
            PacientiRepository pacientiRepository = new PacientiRepository();
            MediciRepository mediciRepository = new MediciRepository();

            cmbPacient.DataSource = pacientiRepository.GetAll();
            cmbPacient.DisplayMember = "NumeComplet";
            cmbPacient.ValueMember = "Id";

            cmbMedic.DataSource = mediciRepository.GetAll();
            cmbMedic.DisplayMember = "NumeComplet";
            cmbMedic.ValueMember = "Id";

            cmbPacient.SelectedIndex = -1;
            cmbMedic.SelectedIndex = -1;

            if (programareDeEditat != null)
            {
                dtpDataProgramarii.Value = programareDeEditat.DataProgramarii;

                txtDiagnostic.Text = programareDeEditat.Diagnostic;
                txtObservatii.Text = programareDeEditat.Observatii;

                cmbPacient.SelectedValue = programareDeEditat.IdPacient;
                cmbMedic.SelectedValue = programareDeEditat.IdMedic;
            }
        }
    }
}
