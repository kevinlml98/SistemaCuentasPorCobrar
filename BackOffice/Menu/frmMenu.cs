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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            string usuario = "empleadoN";

            if (usuario == "empleado")
            {
                this.btnPersona.Visible = false;
                this.btnUsuarios.Visible = false;
                
            }
            else
            {
                
            }
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


        private void FrmMenu_Load(object sender, EventArgs e)
        {

            
            OpenForm<Form>();
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            OpenForm<frmEmpresa>();
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPanelPrincipal_Click(object sender, EventArgs e)
        {
            OpenForm<frmPanelPrincipal>();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmMenu_Load_1(object sender, EventArgs e)
        {

        }

        private void btnPersona_Click(object sender, EventArgs e)
        {
            OpenForm<frmPersona>();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            OpenForm<frmUsuario>();
        }


         

    }
}
