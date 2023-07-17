using DTO.RolDTO;
using System.Collections.Generic;

namespace DAL.RolDAL
{
    public static class RolDAL
    {
        public static List<RolDTO> ObtenerRoles()
        {
            return DBConnection.ExecuteStorageProcedure<RolDTO>("SP_ObtenerRoles");
        }
    }
}
