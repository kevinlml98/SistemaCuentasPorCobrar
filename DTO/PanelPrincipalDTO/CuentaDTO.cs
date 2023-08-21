
using System;

namespace DTO.PanelPrincipalDTO
{
    public class CuentaDTO
    {
        public int Id { get; set; }
        public int IdPersona { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int Plazo { get; set; }
        public decimal MontoCuota { get; set; }
        public decimal MontoInicial { get; set; }
        public decimal MontoRestante { get; set; }
        public bool Pagado { get; set; }
    }
}
