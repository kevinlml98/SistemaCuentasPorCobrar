using DTO.EmpresaDTO;
using System.Collections.Generic;
using DAL.EmpresaDAL;

namespace BLL.EmpresaBLL
{
    public static class EmpresaBLL
    {

        public static List<EmpresaDTO> ObtenerEmpresas(int empresa)
        {
            return EmpresaDAL.ObtenerEmpresa(empresa);
        }

        public static List<EmpresaDTO> ObtenerEmpresas()
        {
            return EmpresaDAL.ObtenerEmpresa();
        }

        public static bool CrearEmpresa(EmpresaDTO empresaDTO)
        {
            List<EmpresaDTO> empresas = EmpresaDAL.ObtenerEmpresa(empresaDTO.Id_Empresa);
            if (empresas.Count < 1)
            {
                EmpresaDAL.CrearEmpresa(empresaDTO);
                return true;

            }
            else
            {
                return false;

            }

        }

        public static bool ActualizarEmpresa(EmpresaDTO empresaDTO)
        {
            List<EmpresaDTO> empresas = EmpresaDAL.ObtenerEmpresa(empresaDTO.Id_Empresa);
            if (empresas.Count > 0)
            {
                EmpresaDAL.ActualizarEmpresa(empresaDTO);

                return true;

            }
            else
            {
                return false;

            }
        }

        public static bool EliminarEmpresa(int empresa)
        {
            List<EmpresaDTO> empresas = EmpresaDAL.ObtenerEmpresa(empresa);
            if (empresas.Count > 0)
            {
                EmpresaDAL.EliminarEmpresa(empresa);

                return true;

            }
            else
            {
                return false;

            }




        }
    }
}

