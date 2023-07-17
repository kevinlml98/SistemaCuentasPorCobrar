
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
        }

        private void ObtenerRoles()
        {
            List<RolDTO> roles = RolBLL.ObtenerRoles();
            this.cmbRol.DataSource = roles;
            this.cmbRol.ValueMember = "Id_Rol";
            this.cmbRol.DisplayMember= "Nombre_Rol";
        }

        

        private void btnRegistrar_Click(object sender, System.EventArgs e)
        {
            
        }
    }
}
