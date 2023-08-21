using BLL.CuentaBLL;
using DTO.PanelPrincipalDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackOffice.PanelPrincipal
{
    public partial class frmNuevaCuenta : Form
    {
        public frmNuevaCuenta()
        {
            InitializeComponent();

            this.cmbPlazo.SelectedIndex = 0;

        }

        private void btnAgregarCuenta_Click(object sender, EventArgs e)
        {
            CuentaDTO cuentaDTO = new CuentaDTO()
            {
                MontoInicial = decimal.Parse(this.txtMonto.Text),
                IdPersona = int.Parse(this.txtIdPersona.Text),
                MontoCuota = decimal.Parse(this.txtCuota.Text),
                Plazo = int.Parse(this.cmbPlazo.SelectedItem.ToString())
            };
            
            CuentaBLL.AddCuenta(cuentaDTO);
            txtCuota.Text = "0";
            txtIdPersona.Text = "0";
            txtMonto.Text = "0";
            MessageBox.Show("Cuenta Creada");

        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {
            decimal monto = decimal.Parse(this.txtMonto.Text);
            decimal plazo = decimal.Parse(this.cmbPlazo.SelectedItem.ToString());
            decimal cuota = monto/plazo;

            this.txtCuota.Text = cuota.ToString();
        }

        private void cmbPlazo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                decimal monto = decimal.Parse(this.txtMonto.Text);
                decimal plazo = decimal.Parse(this.cmbPlazo.SelectedItem.ToString());
                decimal cuota = monto / plazo;

                this.txtCuota.Text = cuota.ToString();
            }
            catch(Exception exce) 
            {
            
            }
            
        }
    }
}
