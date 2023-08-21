using System;

namespace DTO.PanelPrincipalDTO
{
    public class FacturaDTO
    {
        public int Id { get; set; } 
        public int IdPersona { get; set; }
        public int IdCuenta { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
    }
}
