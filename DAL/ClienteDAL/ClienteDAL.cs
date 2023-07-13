using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ClienteDAL
{
    public static class ClienteDAL
    {
        public static void LlamarProcedimiento()
        {
            DBConnection.ExecuteStorageProcedure<ClienteDTO>("sp_obtenerListaClientes");
        }
    }

    public class ClienteDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        /*
         SELECT Id,Name FROM dbo.Clientes
         */
    }
}
