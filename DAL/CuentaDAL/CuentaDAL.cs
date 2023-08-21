

using DTO.PanelPrincipalDTO;
using System.Collections.Generic;

namespace DAL.CuentaDAL
{
    public static class CuentaDAL
    {
        public static void AddCuenta(CuentaDTO cuentaDTO)
        {
            List<DBParameter> parameters = new List<DBParameter>() 
            { 
                new DBParameter()
                {
                    ParameterName = "@IdPersona",
                    ParameterValue = cuentaDTO.IdPersona
                },
                new DBParameter()
                {
                    ParameterName = "@Plazo",
                    ParameterValue = cuentaDTO.Plazo
                },
                new DBParameter()
                {
                    ParameterName = "@MontoCuota",
                    ParameterValue = cuentaDTO.MontoCuota
                },
                new DBParameter()
                {
                    ParameterName = "@MontoInicial",
                    ParameterValue = cuentaDTO.MontoInicial
                }            
            };

            DBConnection.ExecuteStorageProcedure("SP_AddCuenta", parameters);
        }
        public static List<CuentaDTO> GetCuenta(CuentaDTO cuentaDTO)
        {
            List<DBParameter> parameters = new List<DBParameter>
            {
                new DBParameter()
                {
                    ParameterName  = "@IdPersona",
                    ParameterValue = cuentaDTO.IdPersona
                }
            };
            return DBConnection.ExecuteStorageProcedure<CuentaDTO>("SP_GetCuenta", parameters);
        }

        public static void UpdateCuota(CuentaDTO cuentaDTO)
        {
            List<DBParameter> parameters = new List<DBParameter>
            {
                new DBParameter()
                {
                    ParameterName  = "@Id",
                    ParameterValue = cuentaDTO.IdPersona
                },
                new DBParameter()
                {
                    ParameterName  = "@IdPersona",
                    ParameterValue = cuentaDTO.IdPersona
                }
            };
            DBConnection.ExecuteStorageProcedure<CuentaDTO>("SP_GetCuenta", parameters);
        }
    }
}
