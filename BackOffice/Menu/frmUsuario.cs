
using BLL.PersonaBLL;
using BLL.RolBLL;
using DTO.PersonaDTO;
using DTO.RolDTO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BackOffice.Menu
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
            ObtenerRoles();
            ObtenerEmpleados();
        }

        private void ObtenerRoles()
        {
            List<RolDTO> roles = RolBLL.ObtenerRoles();
            this.cmbRol.DataSource = roles;
            this.cmbRol.ValueMember = "Id_Rol";
            this.cmbRol.DisplayMember= "Nombre_Rol";
        }

        private void ObtenerEmpleados()
        {
            List<EmpleadoDTO> empleados = PersonaBLL.ObtenerEmpleados();
            this.DgvDatos.DataSource = empleados;
        }
        

        private void btnRegistrar_Click(object sender, System.EventArgs e)
        {
            EmpleadoDTO empleado = new EmpleadoDTO()
            {
                User = this.txtNombreUsuario.Text,
                Password = this.txtContrasena.Text,
                Activo = this.chkActivo.Checked,
                Persona = int.Parse(this.txtIdPersona.Text),
                Rol = int.Parse(this.cmbRol.SelectedValue.ToString())
            };

            bool result = PersonaBLL.CrearEmpleado(empleado);
            if (result)
            {
                MessageBox.Show("Usuario Creado");
                ObtenerEmpleados();
                txtNombreUsuario.Text = string.Empty;
                txtContrasena.Text = string.Empty;
                chkActivo.Checked = false;
                txtIdPersona.Text = string.Empty;

            }
            else
            {
                MessageBox.Show("No se pudo crear por que los datos ya estan usados");
            }
            
        }

        private void btnActualizar_Click(object sender, System.EventArgs e)
        {
            EmpleadoDTO empleado = new EmpleadoDTO()
            {
                User = this.txtNombreUsuario.Text,
                Password = this.txtContrasena.Text,
                Activo = this.chkActivo.Checked,
                Persona = int.Parse(this.txtIdPersona.Text),
                Rol = int.Parse(this.cmbRol.SelectedValue.ToString()),
            };
                        
            bool result = PersonaBLL.ActualizarEmpleado(empleado);
            if (result)
            {
                MessageBox.Show("Usuario Actualizado");
                ObtenerEmpleados();
                txtNombreUsuario.Text = string.Empty;
                txtContrasena.Text = string.Empty;
                chkActivo.Checked = false;
                txtIdPersona.Text = string.Empty;

            }
            else
            {
                MessageBox.Show("No se pudo crear por que los datos ya estan usados");
            }
        }

        private void DgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = this.DgvDatos.Rows[e.RowIndex];
                this.txtIdPersona.Text = selectedRow.Cells["Persona"].Value.ToString();
                this.txtNombreUsuario.Text = selectedRow.Cells["User"].Value.ToString();
                this.txtContrasena.Text = selectedRow.Cells["Password"].Value.ToString();
                this.cmbRol.SelectedIndex = int.Parse(selectedRow.Cells["Rol"].Value.ToString()) - 1;
                this.chkActivo.Checked = bool.Parse(selectedRow.Cells["Activo"].Value.ToString());
            }
        }
    }
}
