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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void mediciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Form formDeschis in MdiChildren)
            {
                if(formDeschis is FormMedici)
                {
                    formDeschis.Activate();
                    return;
                }
            }
            FormMedici form = new FormMedici();
            form.MdiParent = this;
            form.Show();
        }

        private void pacientiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form formDeschis in MdiChildren)
            {
                if (formDeschis is FormPacienti)
                {
                    formDeschis.Activate();
                    return;
                }
            }
            FormPacienti form = new FormPacienti();
            form.MdiParent = this;
            form.Show();
        }

        private void programariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form formDeschis in MdiChildren)
            {
                if (formDeschis is FormProgramari)
                {
                    formDeschis.Activate();
                    return;
                }
            }
            FormProgramari form = new FormProgramari();
            form.MdiParent = this;
            form.Show();
        }

        private void reteteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form formDeschis in MdiChildren)
            {
                if (formDeschis is FormRetete)
                {
                    formDeschis.Activate();
                    return;
                }
            }
            FormRetete form = new FormRetete();
            form.MdiParent = this;
            form.Show();
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
