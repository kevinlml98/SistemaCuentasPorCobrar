using DTO.PersonaDTO;
using System.Collections.Generic;

namespace DAL.PersonaDAL
{
    public static class PersonaDAL
    {
        public static List<PersonaDTO> ObtentenerPersona(string persona)
        {
            List<DBParameter> parameters = new List<DBParameter>();
            parameters.Add(new DBParameter()
            {
                ParameterName = "@Persona",
                ParameterValue = persona
            });

            return DBConnection.ExecuteStorageProcedure<PersonaDTO>("SP_ObtenerPersona", parameters);
        }

        public static List<PersonaDTO> CrearPersona(PersonaDTO persona)
        {
            List<DBParameter> parameters = new List<DBParameter>
            {
                new DBParameter()
                {
                    ParameterName = "@IDENTIFICACION",
                    ParameterValue = persona.Identificacion
                },
                new DBParameter()
                {
                    ParameterName = "@NOMBRE",
                    ParameterValue = persona.Nombre
                },
                new DBParameter()
                {
                    ParameterName = "@APELLIDO1",
                    ParameterValue = persona.Apellido1
                },
                new DBParameter()
                {
                    ParameterName = "@APELLIDO2",
                    ParameterValue = persona.Apellido2
                },
                new DBParameter()
                {
                    ParameterName = "@DIRECCION",
                    ParameterValue = persona.Direccion
                },
                new DBParameter()
                {
                    ParameterName = "@TELEFONO",
                    ParameterValue = persona.Telefono
                },
                new DBParameter()
                {
                    ParameterName = "@EMAIL",
                    ParameterValue = persona.Email
                }
            };

            return DBConnection.ExecuteStorageProcedure<PersonaDTO>("SP_CrearPersona", parameters);
        }

        public static void CrearEmpleado (EmpleadoDTO empleadoDTO)
        {
            List<DBParameter> parameters = new List<DBParameter> { 
                new DBParameter()
                {
                    ParameterName = "@User",
                    ParameterValue = empleadoDTO.User
                },
                new DBParameter()
                {
                    ParameterName = "@Password",
                    ParameterValue = empleadoDTO.Password
                },
                new DBParameter()
                {
                    ParameterName = "@Persona",
                    ParameterValue = empleadoDTO.Persona
                },
                new DBParameter()
                {
                    ParameterName = "@Rol",
                    ParameterValue = empleadoDTO.Rol
                }
            };
            DBConnection.ExecuteStorageProcedure("SP_AddEmpleado", parameters);
        }

        public static void ActualizarEmpleado(EmpleadoDTO empleadoDTO)
        {
            List<DBParameter> parameters = new List<DBParameter> {
                new DBParameter()
                {
                    ParameterName = "@User",
                    ParameterValue = empleadoDTO.User
                },
                new DBParameter()
                {
                    ParameterName = "@Password",
                    ParameterValue = empleadoDTO.Password
                },
                new DBParameter()
                {
                    ParameterName = "@Persona",
                    ParameterValue = empleadoDTO.Persona
                },
                new DBParameter()
                {
                    ParameterName = "@Rol",
                    ParameterValue = empleadoDTO.Rol
                },
                new DBParameter()
                {
                    ParameterName = "@Activo",
                    ParameterValue = empleadoDTO.Activo
                }
            };
            DBConnection.ExecuteStorageProcedure("SP_UpdateEmpleado", parameters);
        }

        public static List<EmpleadoDTO> ObtenerEmpleados()
        {            
            return DBConnection.ExecuteStorageProcedure<EmpleadoDTO>("SP_GetEmpleado");
        }
    }
}
