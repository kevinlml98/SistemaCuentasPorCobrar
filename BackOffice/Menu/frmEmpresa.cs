using BLL.EmpresaBLL;
using DTO.EmpresaDTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BackOffice.Menu
{
    public partial class frmEmpresa : Form
    {
        public frmEmpresa()
        {
            InitializeComponent();
            List<EmpresaDTO> empresas = EmpresaBLL.ObtenerEmpresas();
            DgvDatos.DataSource = empresas;
        }



        private void txtIdEmpresa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string IdEmpresa = txtIdEmpresa.Text;
            string nombreEmpresa = txtNombreEmpresa.Text;
            string direccionEmpresa = txtIdDireccion.Text;
            int idempresa;

            if (ValidarNumero(IdEmpresa, out idempresa, "ID de Empresa"))

            {
                EmpresaDTO empresaDTO = new EmpresaDTO
                {
                    Id_Empresa = idempresa,
                    Nombre_Empresa = nombreEmpresa,
                    Direccion_Empresa = direccionEmpresa
                };
                if (EmpresaBLL.CrearEmpresa(empresaDTO))
                {
                    MessageBox.Show("Se ha creado la empresa");

                }
                else
                {
                    MessageBox.Show("Creación NO exitosa. Favor ingresar datos válidos");
                }
                List<EmpresaDTO> empresas = EmpresaBLL.ObtenerEmpresas();
                DgvDatos.DataSource = empresas;
                txtIdEmpresa.Text = "";
                txtNombreEmpresa.Text = "";
                txtIdDireccion.Text = "";


            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string empresa = txtIdEmpresa.Text;
            int IdEmpresa;
            if (ValidarNumero(empresa, out IdEmpresa, "ID de Empresa"))
            {
                if (EmpresaBLL.EliminarEmpresa(IdEmpresa))
                {
                    MessageBox.Show("La empresa se ha ELIMINADO exitosamente");
                }
                else
                {
                    MessageBox.Show("Eliminación NO exitosa. Favor ingresar datos válidos");
                }
                List<EmpresaDTO> empresas = EmpresaBLL.ObtenerEmpresas();
                DgvDatos.DataSource = empresas;
                txtIdEmpresa.Text = "";
                txtNombreEmpresa.Text = "";
                txtIdDireccion.Text = "";
            }
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            string IdEmpresaT = txtIdEmpresa.Text;
            string nombreEmpresa = txtNombreEmpresa.Text;
            string direccionEmpresa = txtIdDireccion.Text;

            int IdEmpresa;
            if (ValidarNumero(IdEmpresaT, out IdEmpresa, "ID de Empresa"))
            {
                EmpresaDTO actEmpresa = new EmpresaDTO
                {
                    Id_Empresa = IdEmpresa,
                    Nombre_Empresa = nombreEmpresa,
                    Direccion_Empresa = direccionEmpresa
                };

                if (EmpresaBLL.ActualizarEmpresa(actEmpresa))
                {
                    MessageBox.Show("La Empresa se ha actualizado exitosamente");
                }
                else
                {
                    MessageBox.Show("Actualización no exitosa. Favor ingresar datos válidos");
                }

                List<EmpresaDTO> empresas = EmpresaBLL.ObtenerEmpresas();
                DgvDatos.DataSource = empresas;
                txtIdEmpresa.Text = "";
                txtNombreEmpresa.Text = "";
                txtIdDireccion.Text = "";
            }
        }

        public static bool ValidarNumero(string input, out int numericValue, string fieldName)
        {
            bool isValid = true;
            numericValue = 0;

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show($"{fieldName} no puede estar vacío.");
                isValid = false;
            }
            else if (!int.TryParse(input, out numericValue))
            {
                MessageBox.Show($"{fieldName} debe ser un número válido.");
                isValid = false;

            }
            else if (numericValue < 0)
            {
                MessageBox.Show($"{fieldName} no puede ser un número negativo.");
                isValid = false;
            }
            else if (!IsNumeric(input))
            {
                MessageBox.Show($"{fieldName} debe contener solo caracteres numéricos.");
                isValid = false;
            }

            return isValid;
        }

        private static bool IsNumeric(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Actualización no exitosa. Favor ingresar datos válidos");
                    return false;
                }
            }
            return true;
        }


        //private void DgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0 && e.ColumnIndex == 1) 
        //    {
        //        int rowIndex = e.RowIndex;
        //        int empresa = Convert.ToInt32(((DataGridView)sender).Rows[rowIndex].Cells["Id"].Value);

        //        bool eliminacionExitosa = EmpresaBLL.EliminarEmpresa(empresa);

        //        if (eliminacionExitosa)
        //        {
        //            DgvDatos.DataSource = EmpresaBLL.ObtenerEmpresas();
        //            DgvDatos.Refresh();


        //            MessageBox.Show("La empresa se eliminó correctamente.");
        //        }
        //        else
        //        {
        //            MessageBox.Show("No se pudo eliminar la empresa.");
        //        }
        //        //List<EmpresaDTO> empresas = EmpresaBLL.ObtenerEmpresas();
        //        //DgvDatos.DataSource = empresas;
        //        txtIdEmpresa.Text = "";
        //        txtNombreEmpresa.Text = "";
        //        txtIdDireccion.Text = "";
        //    }

    }



}





