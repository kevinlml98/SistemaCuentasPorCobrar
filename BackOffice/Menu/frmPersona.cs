using BLL.PersonaBLL;
using DTO.PersonaDTO;
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
    public partial class frmPersona : Form
    {
        public frmPersona()
        {
            InitializeComponent();
            ObtenerPersonas();
        }

        private void ObtenerPersonas()
        {
            List<PersonaDTO> personas = PersonaBLL.ObtenerPersona();
            this.DgvDatos.DataSource = personas;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            PersonaDTO persona = new PersonaDTO()
            {
                Id_Persona = 0,
                Identificacion = this.txtIdentificacion.Text,
                Nombre = this.txtNombre.Text,
                Apellido1 = this.txtApellido1.Text,
                Apellido2 = this.txtApellido2.Text,
                Direccion = this.txtIdDireccion.Text,
                Telefono = this.txtIdTelefono.Text,
                Email = this.txtIdEmail.Text
            };


            if (PersonaBLL.ValidarIdRegistrar(persona))
            {
                List<PersonaDTO> personas = PersonaBLL.CrearPersona(persona);
                MessageBox.Show("Persona ha sido registrado con exito");
                limpiarTxt();
                this.txtIdentificacion.Focus();
            }
            else
            {
                MessageBox.Show("El ID ya existe en la base de datos, intentelo de nuevo");
            }

            ObtenerPersonas();
        }

        private void frmPersona_Load(object sender, EventArgs e)
        {
            this.txtIdentificacion.Focus();

        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            PersonaDTO persona = new PersonaDTO()
            {
                Identificacion = this.txtIdentificacion.Text,

            };

            if (PersonaBLL.ValidarIdEliminar(persona))
            {
                List<PersonaDTO> personas = PersonaBLL.EliminarPersona(persona);
                MessageBox.Show("Persona ha sido eliminado");
                limpiarTxt();
                this.txtIdentificacion.Focus();
            }
            else
            {
                MessageBox.Show("El ID no existe en la base de datos, intentelo de nuevo");
            }

            ObtenerPersonas();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            PersonaDTO persona = new PersonaDTO()
            {
                Id_Persona = 0,
                Identificacion = this.txtIdentificacion.Text,
                Nombre = this.txtNombre.Text,
                Apellido1 = this.txtApellido1.Text,
                Apellido2 = this.txtApellido2.Text,
                Direccion = this.txtIdDireccion.Text,
                Telefono = this.txtIdTelefono.Text,
                Email = this.txtIdEmail.Text
            };

            if (PersonaBLL.ValidarIdActualizar(persona))
            {
                List<PersonaDTO> personas = PersonaBLL.ActualizarPersona(persona);
                MessageBox.Show("Persona ha sido actualizada con exito");
                limpiarTxt();
                this.txtIdentificacion.Focus();
            }
            else
            {
                MessageBox.Show("El ID no existe en la base de datos, intentelo de nuevo");
            }

            ObtenerPersonas();
        }

        private void limpiarTxt()
        {
            this.txtIdentificacion.Text = null;
            this.txtNombre.Text = null;
            this.txtApellido1.Text = null;
            this.txtApellido2.Text = null;
            this.txtIdDireccion.Text = null;
            this.txtIdTelefono.Text = null;
            this.txtIdEmail.Text = null;
        }

    }
}
