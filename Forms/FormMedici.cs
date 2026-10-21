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
    public partial class FormMedici : Form
    {
        private MediciRepository _repository = new MediciRepository();
        private BindingList<Medic> medici;
        public FormMedici()
        {
            InitializeComponent();
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {

            if (dgvMedici.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectati un medic pentru stergere!",
                    "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int index = dgvMedici.SelectedRows[0].Index;
            Medic selectat = medici[index];
            var rezultat = MessageBox.Show(
                "Sigur vrei sa stergi acest medic?",
                "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rezultat == DialogResult.Yes)
            {
                try
                {
                    _repository.Delete(selectat.Id);
                    RefreshLista();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nu se poate șterge medicul deoarece are programări asociate.",
                        "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            using (FormAdaugaMedic f = new FormAdaugaMedic(null))
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    _repository.Add(f.MedicRezultat);
                    RefreshLista();
                }
            }
        }

        private void btnEditeaza_Click(object sender, EventArgs e)
        {
            if (dgvMedici.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectati un medic pentru editare!",
                    "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int index = dgvMedici.SelectedRows[0].Index;
            Medic selectat = medici[index];
            using (FormAdaugaMedic f = new FormAdaugaMedic(selectat))
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    _repository.Update(f.MedicRezultat);
                    RefreshLista();
                }
            }
        }

        private void FormMedici_Load(object sender, EventArgs e)
        {
            RefreshLista();
        }

        private void RefreshLista()
        {
            medici = new BindingList<Medic>(_repository.GetAll());
            dgvMedici.DataSource = null;
            dgvMedici.DataSource = medici;
            dgvMedici.Columns["NumeComplet"].Visible = false;
        }
    }
}
