using BLL.CuentaBLL;
using DTO.PanelPrincipalDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
                if (chkPagado.Checked)
                {
                    this.txtAbonar.Enabled = false;
                    this.txtAbonar.Text = "0";
                }
                else
                {
                    this.txtAbonar.Enabled = true;
                    this.txtAbonar.Text = "0";
                }
            }
        }

        private void btnAbonar_Click(object sender, EventArgs e)
        {
            if(txtCuenta.Text == string.Empty)
            {
                return;
            }
            decimal abonar = decimal.Parse(this.txtAbonar.Text);
            decimal montocuota = decimal.Parse(this.txtCuota.Text);
            decimal restante = decimal.Parse(this.txtRestante.Text);

            if(abonar > restante)
            {
                MessageBox.Show("El monto a abonar es mayor que el restante");
            }
            else if (abonar < montocuota )
            {
                MessageBox.Show("El monto a abonar es menor a la cuota");
            }
            else
            {
                int persona = int.Parse(this.txtBuscar.Text);
                CuentaDTO cuenta = new CuentaDTO()
                {
                    Id = int.Parse(this.txtCuenta.Text),
                    MontoCuota = decimal.Parse(this.txtAbonar.Text),
                    IdPersona = persona
                };
                DateTime fechaActual = DateTime.Now;
                string fechaFormateada = fechaActual.ToString("dd/MM/yyyy HH:mm:ss");
                string factura = "Fecha: " + fechaFormateada +" Cuenta: " + txtCuenta.Text + " Identificacion de Persona: " + txtBuscar.Text + " Monto Abonado: " + txtAbonar.Text;
                CrearArchivoTxt("Factura.txt",factura);
                CuentaBLL.UpdateCuota(cuenta);
                List<CuentaDTO> cuentas = CuentaBLL.GetCuenta(cuenta);
                this.tableCuotas.DataSource = cuentas;
                this.txtCuenta.Text = string.Empty;
                this.txtRestante.Text = "0";
                this.txtCuota.Text = "0";
                this.txtAbonar.Text = "0";
                MessageBox.Show("Transacción completada");
                
            }
            
        }

        public static void CrearArchivoTxt(string nombreArchivo, string contenido)
        {
            try
            {
                // Combinar la ruta del escritorio del usuario con el nombre del archivo
                string rutaCompleta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), nombreArchivo);

                // Crear un archivo y escribir el contenido
                using (StreamWriter writer = new StreamWriter(rutaCompleta))
                {
                    writer.Write(contenido);
                }

            }
            catch (Exception ex)
            {
            }
        }
    }
}
