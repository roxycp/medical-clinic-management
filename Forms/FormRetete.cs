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
    public partial class FormRetete : Form
    {

        private ReteteRepository _repository = new ReteteRepository();
        private BindingList<Reteta> retete;
        public FormRetete()
        {
            InitializeComponent();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            using (FormAdaugaReteta f = new FormAdaugaReteta(null))
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    _repository.Add(f.RetetaRezultat);
                    RefreshLista();
                }
            }
        }

        private void btnEditeaza_Click(object sender, EventArgs e)
        {
            if (dgvRetete.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectati o reteta pentru editare!",
                    "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int index = dgvRetete.SelectedRows[0].Index;
            Reteta selectat = retete[index];
            using (FormAdaugaReteta f = new FormAdaugaReteta(selectat))
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    _repository.Update(f.RetetaRezultat);
                    RefreshLista();
                }
            }
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            if (dgvRetete.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectati o reteta pentru stergere!",
                    "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int index = dgvRetete.SelectedRows[0].Index;
            Reteta selectat = retete[index];
            var rezultat = MessageBox.Show(
                "Sigur vrei sa stergi aceasta reteta?",
                "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rezultat == DialogResult.Yes)
            {
                _repository.Delete(selectat.Id);
                RefreshLista();
            }
        }
        private void RefreshLista()
        {
            retete = new BindingList<Reteta>(_repository.GetAll());
            dgvRetete.DataSource = null;
            dgvRetete.DataSource = retete;
            dgvRetete.Columns["IdProgramare"].Visible = false;
        }
        private void FormRetete_Load(object sender, EventArgs e)
        {
            RefreshLista();
        }
    }
}
