using CabinetMedical.Models;
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
    public partial class FormAdaugaPacient : Form
    {
        private Pacient pacientDeEditat;
        public Pacient PacientRezultat { get; set; }
        public FormAdaugaPacient(Pacient pacient)
        {
            InitializeComponent();
            pacientDeEditat = pacient;
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

            if (string.IsNullOrWhiteSpace(txtCNP.Text))
            {
                errorProvider1.SetError(txtCNP, "CNP-ul este obligatoriu");
                ok = false;
            }
            else if (txtCNP.Text.Trim().Length != 13 || !txtCNP.Text.Trim().All(char.IsDigit))
            {
                errorProvider1.SetError(txtCNP, "CNP-ul trebuie să conțină exact 13 cifre");
                ok = false;
            }

            if (string.IsNullOrWhiteSpace(txtTelefon.Text))
            {
                errorProvider1.SetError(txtTelefon, "Nr de telefon este obligatoriu");
                ok = false;
            }

            if (!ok) { return; }

            int id = 0;
            if (pacientDeEditat != null)
            {
                id = pacientDeEditat.Id;
            }

            PacientRezultat = new Pacient
            {
                Id = id,
                Nume = txtNume.Text.Trim(),
                Prenume = txtPrenume.Text.Trim(),
                CNP = txtCNP.Text.Trim(),
                DataNasterii=dtpDataNasterii.Value,
                Telefon = txtTelefon.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Adresa = txtAdresa.Text.Trim(),
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnAnuleaza_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void FormAdaugaPacient_Load(object sender, EventArgs e)
        {
            if (pacientDeEditat != null)
            {
                txtNume.Text = pacientDeEditat.Nume;
                txtPrenume.Text = pacientDeEditat.Prenume;
                txtCNP.Text = pacientDeEditat.CNP;
                dtpDataNasterii.Value = pacientDeEditat.DataNasterii;
                txtTelefon.Text = pacientDeEditat.Telefon;
                txtEmail.Text = pacientDeEditat.Email;
                txtAdresa.Text = pacientDeEditat.Adresa;
            }
        }
    }
}
