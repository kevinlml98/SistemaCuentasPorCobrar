
using DTO.EmpresaDTO;
using System.Collections.Generic;

namespace DAL.EmpresaDAL
{
    public static class EmpresaDAL
    {
        public static List<EmpresaDTO> ObtenerEmpresa(int Empresa)
        {
            List<DBParameter> parameters = new List<DBParameter>();
            parameters.Add(new DBParameter()
            {
                ParameterName = "@Id_Empresa",
                ParameterValue = Empresa
            }
            );

            return DBConnection.ExecuteStorageProcedure<EmpresaDTO>("sp_ObtenerEmpresaPorId", parameters);
        }

        public static List<EmpresaDTO> ObtenerEmpresa()
        {
            return DBConnection.ExecuteStorageProcedure<EmpresaDTO>("sp_ObtenerEmpresas");
        }

        public static void CrearEmpresa(EmpresaDTO Empresa)
        {
            List<DBParameter> parameters = new List<DBParameter>
            {
                new DBParameter()
                {
                    ParameterName = "@Id_Empresa",
                    ParameterValue = Empresa.Id_Empresa
                },
                new DBParameter()
                {
                    ParameterName = "@Nombre_Empresa",
                    ParameterValue = Empresa.Nombre_Empresa
                },
                new DBParameter()
                {
                    ParameterName = "@Direccion_Empresa",
                    ParameterValue = Empresa.Direccion_Empresa

                }
            };

            DBConnection.ExecuteStorageProcedure("sp_InsertarEmpresa", parameters);
        }

        public static void ActualizarEmpresa(EmpresaDTO empresa)
        {
            List<DBParameter> parameters = new List<DBParameter>
            {
                new DBParameter()
                {
                    ParameterName = "@Id_Empresa",
                    ParameterValue = empresa.Id_Empresa
                },
                new DBParameter()
                {
                    ParameterName = "@Nombre_Empresa",
                    ParameterValue = empresa.Nombre_Empresa
                },
                new DBParameter()
                {
                    ParameterName = "@Direccion_Empresa",
                    ParameterValue = empresa.Direccion_Empresa
                }
            };

            DBConnection.ExecuteStorageProcedure("sp_ActualizarEmpresa", parameters);
        }


        public static void EliminarEmpresa(int empresa)
        {
            List<DBParameter> parameters = new List<DBParameter>
            {
                new DBParameter()
                {
                    ParameterName = "@Id_Empresa",
                    ParameterValue = empresa
                }
            };

            DBConnection.ExecuteStorageProcedure("sp_EliminaEmpresa", parameters);
        }
    }
}
