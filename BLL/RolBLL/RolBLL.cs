using DTO.RolDTO;
using System.Collections.Generic;
using DAL.RolDAL;

namespace BLL.RolBLL
{
    public static class RolBLL
    {
        public static List<RolDTO> ObtenerRoles()
        {
            return RolDAL.ObtenerRoles();
        }
    }
}
