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
    public partial class frmListaCuentas : Form
    {
        public frmListaCuentas()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int persona = int.Parse(this.txtBuscar.Text);
            CuentaDTO cuentaDTO = new CuentaDTO()
            {
                IdPersona = persona
            };
            List<CuentaDTO> cuentas = CuentaBLL.GetCuenta(cuentaDTO);
            this.tableCuotas.DataSource = cuentas;
        }

     
        private void tableCuotas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = this.tableCuotas.Rows[e.RowIndex];
                this.txtCuenta.Text = selectedRow.Cells["Id"].Value.ToString();
                this.txtRestante.Text = selectedRow.Cells["MontoRestante"].Value.ToString();
                this.txtCuota.Text = selectedRow.Cells["MontoCuota"].Value.ToString();
                this.chkPagado.Checked = bool.Parse(selectedRow.Cells["Pagado"].Value.ToString());

            }
        }

        private void btnAbonar_Click(object sender, EventArgs e)
        {
            CuentaDTO cuenta = new CuentaDTO()
            {
                Id = int.Parse(this.txtCuenta.Text),
                MontoCuota = decimal.Parse(this.txtCuota.Text)
            };
            
        }
    }
}
