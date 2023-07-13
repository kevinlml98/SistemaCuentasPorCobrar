using DTO.UsuarioDTO;
using System.Collections.Generic;

namespace DAL.UsuarioDAL
{
    public static class UsuarioDAL
    {
        public static List<P_UsuarioDTO> VerficarUsuario(V_UsuarioDTO usuario)
        {
            List<DBParameter> param = new List<DBParameter>
            {
                new DBParameter() { ParameterName = "@User", ParameterValue = usuario.User },
                new DBParameter() { ParameterName = "@Password", ParameterValue = usuario.Password }
            };

            return DBConnection.ExecuteStorageProcedure<P_UsuarioDTO>("SP_VerificarUsuario",param);
        }
    }
}
