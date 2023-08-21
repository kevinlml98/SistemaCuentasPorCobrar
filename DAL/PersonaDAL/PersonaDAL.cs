using DTO.PersonaDTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;

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

        public static List<PersonaDTO> EliminarPersona(PersonaDTO persona)
        {


            // Creando una lista de parámetros de base de datos
            List<DBParameter> parameters = new List<DBParameter>
        {
            new DBParameter()
            {
                ParameterName = "@PersonaID",
                ParameterValue = persona.Identificacion
            }
        };

            // Llamando a un procedimiento almacenado llamado "SP_EliminarPersona" con los parámetros proporcionados
            return DBConnection.ExecuteStorageProcedure<PersonaDTO>("SP_EliminarPersona", parameters);


        }

        public static List<PersonaDTO> ActualizarPersona(PersonaDTO persona)
        {
            List<DBParameter> parameters = new List<DBParameter>
            {
                new DBParameter()
                {
                    ParameterName = "@PersonaID",
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

            return DBConnection.ExecuteStorageProcedure<PersonaDTO>("SP_ActualizarPersona", parameters);
        }

        public static string obtenerMensaje(string id = "432422")
        {
            List<DBParameter> dBParametros = new List<DBParameter>();
            dBParametros.Add(new DBParameter()
            {
                ParameterName = "@PersonaID",
                ParameterValue = id
            });

            string message = DBConnection.ExecuteScalarProcedure("SP_EliminarPersona", dBParametros);

            return message;
        }
        

    }
}
    




        