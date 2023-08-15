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

            List<PersonaDTO> personas = PersonaBLL.CrearPersona(persona);
            if(personas.Count < 1)
            {
                MessageBox.Show("No se pudo crear el usuario");
            }
            else
            {
                MessageBox.Show("Usuario Creado");
                this.DgvDatos.DataSource = personas;
            }
        }
    }
}
