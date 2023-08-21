

using DAL.CuentaDAL;
using DTO.PanelPrincipalDTO;
using System.Collections.Generic;

namespace BLL.CuentaBLL
{
    public static class CuentaBLL
    {
        public static void AddCuenta(CuentaDTO cuentaDTO)
        {
            CuentaDAL.AddCuenta(cuentaDTO);
        }
        public static List<CuentaDTO> GetCuenta(CuentaDTO cuentaDTO)
        {
            return CuentaDAL.GetCuenta(cuentaDTO);
        }
        public static void UpdateCuota(CuentaDTO cuenta)
        {
            CuentaDAL.UpdateCuota(cuenta);
        }
    }
}
