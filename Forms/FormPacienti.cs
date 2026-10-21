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
    public partial class FormPacienti : Form
    {
        private PacientiRepository _repository = new PacientiRepository();
        private BindingList<Pacient> pacienti;
        public FormPacienti()
        {
            InitializeComponent();
            
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            using (FormAdaugaPacient f = new FormAdaugaPacient(null))
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    _repository.Add(f.PacientRezultat);
                    RefreshLista();
                }
            }
        }

        private void btnEditeaza_Click(object sender, EventArgs e)
        {
            if (dgvPacienti.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectati un pacient pentru editare!",
                    "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int index = dgvPacienti.SelectedRows[0].Index;
            Pacient selectat = pacienti[index];
            using (FormAdaugaPacient f = new FormAdaugaPacient(selectat))
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    _repository.Update(f.PacientRezultat);
                    RefreshLista();
                }
            }
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            if (dgvPacienti.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectati un pacient pentru stergere!",
                    "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int index = dgvPacienti.SelectedRows[0].Index;
            Pacient selectat = pacienti[index];
            var rezultat = MessageBox.Show(
                "Sigur vrei sa stergi acest pacient?",
                "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rezultat == DialogResult.Yes)
            {
                try
                {
                    _repository.Delete(selectat.Id);
                    RefreshLista();
                }
                catch (Exception)
                {
                    MessageBox.Show("Nu se poate șterge pacientul deoarece are programări asociate.",
                        "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void RefreshLista()
        {
            pacienti = new BindingList<Pacient>(_repository.GetAll());
            dgvPacienti.DataSource = null;
            dgvPacienti.DataSource = pacienti;
            dgvPacienti.Columns["NumeComplet"].Visible = false;
        }

        private void FormPacienti_Load(object sender, EventArgs e)
        {
            RefreshLista();
        }
    }
}
