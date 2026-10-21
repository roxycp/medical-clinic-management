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
    
    public partial class FormAdaugaReteta : Form
    {
        private Reteta retetaDeEditat;
        public Reteta RetetaRezultat { get; set; }

        private ProgramariRepository _programariRepository = new ProgramariRepository();
        private List<Programare> programari;

        public FormAdaugaReteta(Reteta reteta)
        {
            InitializeComponent();
            retetaDeEditat = reteta;
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool ok = true;

            if (cmbIdProgramare.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbIdProgramare, "Selectati o programare");
                ok = false;
            }

            if (string.IsNullOrWhiteSpace(rtbMedicamente.Text))
            {
                errorProvider1.SetError(rtbMedicamente, "Completează medicamentele prescrise.");
                ok = false;
            }

            if (!ok) { return; }

            int id = 0;
            if (retetaDeEditat != null)
            {
                id = retetaDeEditat.Id;
            }

            RetetaRezultat = new Reteta
            {
                Id = id,
                IdProgramare = ((Programare)cmbIdProgramare.SelectedItem).Id,
                DataEliberarii = dtpDataEliberarii.Value,
                NumePacient = ((Programare)cmbIdProgramare.SelectedItem).NumePacient,
                NumeMedic = ((Programare)cmbIdProgramare.SelectedItem).NumeMedic,
                Medicamente = rtbMedicamente.Text.Trim(),
                Observatii = rtbObservatii.Text.Trim(),
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnAnuleaza_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void FormAdaugaReteta_Load(object sender, EventArgs e)
        {
            programari = _programariRepository.GetAll();
            cmbIdProgramare.DataSource = programari;

            if (retetaDeEditat == null)
            {
                dtpDataEliberarii.Value = DateTime.Now;
                if (programari.Count > 0)
                {
                    cmbIdProgramare.SelectedIndex = -1;
                }
            }
            else
            {
                cmbIdProgramare.SelectedItem = programari.FirstOrDefault(p => p.Id == retetaDeEditat.IdProgramare);
                dtpDataEliberarii.Value = retetaDeEditat.DataEliberarii;
                rtbMedicamente.Text = retetaDeEditat.Medicamente;
                rtbObservatii.Text = retetaDeEditat.Observatii;
            }
        }
    }
}
