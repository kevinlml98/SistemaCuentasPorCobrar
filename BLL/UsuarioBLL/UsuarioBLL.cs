
using DAL.UsuarioDAL;
using DTO.UsuarioDTO;
using System.Collections.Generic;

namespace BLL.UsuarioBLL
{
    public static class UsuarioBLL
    {
        public static List<P_UsuarioDTO> VerificarUsuario(V_UsuarioDTO usuario)
        {
            return UsuarioDAL.VerficarUsuario(usuario);
        }
    }
}
