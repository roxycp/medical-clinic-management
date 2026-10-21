using CabinetMedical.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CabinetMedical.Forms
{
    public partial class FormAdaugaMedic : Form
    {
        private Medic medicDeEditat;
        public Medic MedicRezultat {  get; set; }
        public FormAdaugaMedic(Medic medic)
        {
            InitializeComponent();
            medicDeEditat = medic;
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool ok = true;

            if (string.IsNullOrWhiteSpace(txtNume.Text))
            {
                errorProvider1.SetError(txtNume, "Numele este obligatoriu");
                ok = false;
            }

            if (string.IsNullOrWhiteSpace(txtPrenume.Text))
            {
                errorProvider1.SetError(txtPrenume, "Prenumele este obligatoriu");
                ok = false;
            }

            if (string.IsNullOrWhiteSpace(txtSpecialitate.Text))
            {
                errorProvider1.SetError(txtSpecialitate, "Specialitatea este obligatorie");
                ok = false;
            }

            if (!ok) { return; }

            int id = 0;
            if (medicDeEditat != null) 
            {
                id= medicDeEditat.Id;
            }

            MedicRezultat = new Medic
            {
                Id = id,
                Nume = txtNume.Text.Trim(),
                Prenume = txtPrenume.Text.Trim(),
                Specialitate = txtSpecialitate.Text.Trim(),
                Telefon=txtTelefon.Text.Trim(),
                Email=txtEmail.Text.Trim()
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnAnuleaza_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void FormAdaugaMedic_Load(object sender, EventArgs e)
        {
            if (medicDeEditat != null)
            {
                txtNume.Text = medicDeEditat.Nume;
                txtPrenume.Text= medicDeEditat.Prenume;
                txtSpecialitate.Text= medicDeEditat.Specialitate;
                txtTelefon.Text=medicDeEditat.Telefon;
                txtEmail.Text=medicDeEditat.Email;
            }
        }
    }
}
