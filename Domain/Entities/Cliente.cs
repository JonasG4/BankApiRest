using Domain.Common;
using System;

namespace Domain.Entities
{
    public class Cliente : AuditableBaseEntity
    {
        private int _edad;
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DUI { get; set; }
        public string NIT { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
    }
}
