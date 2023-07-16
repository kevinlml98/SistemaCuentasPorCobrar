using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackOffice.Menu
{
    public partial class frmPanelPrincipal : Form
    {
        public frmPanelPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenForm<frmPrueba>();
        }

        private void OpenForm<Forms>() where Forms : Form, new()
        {

            Form frm;
            frm = panelMain.Controls.OfType<Forms>().FirstOrDefault();

            if (frm == null)
            {

                frm = new Forms();
                frm.TopLevel = false;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                panelMain.Controls.Add(frm);
                panelMain.Tag = frm;
                frm.Show();
                frm.BringToFront();
            }
            else
            {
                if (frm.WindowState == FormWindowState.Minimized)
                {
                    frm.WindowState = FormWindowState.Normal;
                }
                frm.BringToFront();
            }

        }

        private void frmPanelPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
