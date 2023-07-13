using DTO.UsuarioDTO;
using BLL.UsuarioBLL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace BackOffice
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            V_UsuarioDTO usr = new V_UsuarioDTO
            {
                User = this.txtUser.Text,
                Password = this.txtPassword.Text
            };

            List<P_UsuarioDTO> personas = UsuarioBLL.VerificarUsuario(usr);
            if(personas.Count > 0 )
            {
                P_UsuarioDTO persona = personas[0];
                string mensaje = $@"Nombre: {persona.Nombre}
                                    Rol: {persona.Rol}
                                    Permisos: {persona.Permisos} ";
                MessageBox.Show(mensaje);
            }
            else
            {
                MessageBox.Show("Acceso bloqueado");
            }

        }
    }
}
