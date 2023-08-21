
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
