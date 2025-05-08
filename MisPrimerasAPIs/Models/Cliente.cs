using System.ComponentModel.DataAnnotations;

namespace MisPrimerasAPIs.Models
{
    public class Cliente
    {
        
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }

        public IEnumerable<Cuenta> Cuentas { get; set; }
    }
}
