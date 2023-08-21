
using DTO.PersonaDTO;
using System.Collections.Generic;
using DAL.PersonaDAL;

namespace BLL.PersonaBLL
{
    public static class PersonaBLL
    {
        public static List<PersonaDTO> ObtenerPersona(string persona = "TODOS")
        {
            return PersonaDAL.ObtentenerPersona(persona);
        }

        public static List<PersonaDTO> CrearPersona(PersonaDTO personaDTO)
        {
            return PersonaDAL.CrearPersona(personaDTO);
        }


        public static List<PersonaDTO> EliminarPersona(PersonaDTO personaDTO)
        {
            return PersonaDAL.EliminarPersona(personaDTO);

        }

        public static List<PersonaDTO> ActualizarPersona(PersonaDTO personaDTO)
        {
            return PersonaDAL.ActualizarPersona(personaDTO);

        }

        public static bool ValidarIdEliminar(PersonaDTO personaDTO)
        {
            List<PersonaDTO> personas = PersonaDAL.ObtentenerPersona(personaDTO.Identificacion);


            foreach (PersonaDTO persona in personas)
            {
                if (persona.Identificacion == personaDTO.Identificacion)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool ValidarIdRegistrar(PersonaDTO personaDTO)
        {
            List<PersonaDTO> personas = PersonaDAL.ObtentenerPersona(personaDTO.Identificacion);


            foreach (PersonaDTO persona in personas)
            {
                if (persona.Identificacion == personaDTO.Identificacion)
                {
                    return false;
                }
            }

            return true;
        }

        public static bool ValidarIdActualizar(PersonaDTO personaDTO)
        {
            List<PersonaDTO> personas = PersonaDAL.ObtentenerPersona(personaDTO.Identificacion);


            foreach (PersonaDTO persona in personas)
            {
                if (persona.Identificacion == personaDTO.Identificacion)
                {
                    return true;
                }
            }

            return false;
        }

   
        public static void CrearEmpleado(EmpleadoDTO empleadoDTO)
        {
            PersonaDAL.CrearEmpleado(empleadoDTO);
        }
        public static void ActualizarEmpleado(EmpleadoDTO empleadoDTO)
        {
            PersonaDAL.ActualizarEmpleado(empleadoDTO);
        }

        public static List<EmpleadoDTO> ObtenerEmpleados()
        {
            return PersonaDAL.ObtenerEmpleados();
        }
    }
}
