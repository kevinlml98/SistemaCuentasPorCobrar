
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
    }
}
