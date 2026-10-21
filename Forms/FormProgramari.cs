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
    public partial class FormProgramari : Form
    {
        private ProgramariRepository _repository = new ProgramariRepository();
        private BindingList<Programare> programari;
        public FormProgramari()
        {
            InitializeComponent();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            using (FormAdaugaProgramare f = new FormAdaugaProgramare(null))
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    _repository.Add(f.ProgramareRezultat);
                    RefreshLista();
                }
            }
        }

        private void btnEditeaza_Click(object sender, EventArgs e)
        {
            if (dgvProgramari.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectati o programare pentru editare!",
                    "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int index = dgvProgramari.SelectedRows[0].Index;
            Programare selectat = programari[index];
            using (FormAdaugaProgramare f = new FormAdaugaProgramare(selectat))
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    _repository.Update(f.ProgramareRezultat);
                    RefreshLista();
                }
            }
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            if (dgvProgramari.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectati o programare pentru stergere!",
                    "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int index = dgvProgramari.SelectedRows[0].Index;
            Programare selectat = programari[index];
            var rezultat = MessageBox.Show(
                "Sigur vrei sa stergi aceasta programare?","Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rezultat == DialogResult.Yes)
            {
                try
                {
                    _repository.Delete(selectat.Id);
                    RefreshLista();
                }
                catch (Exception)
                {
                    MessageBox.Show("Nu se poate sterge programarea deoarece are retete asociate.",
                        "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void RefreshLista()
        {
            programari = new BindingList<Programare>(_repository.GetAll());
            dgvProgramari.DataSource = null;
            dgvProgramari.DataSource = programari;
            dgvProgramari.Columns["IdPacient"].Visible = false;
            dgvProgramari.Columns["IdMedic"].Visible = false;
        }
            
        private void FormProgramari_Load(object sender, EventArgs e)
        {
            RefreshLista();
        }
    }
}
