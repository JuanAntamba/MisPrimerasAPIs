using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MisPrimerasAPIs.Models
{
    public class Cuenta
    {
        [Key]
        public int NumeroCuenta { get; set; }
        [JsonIgnore]
        public TipoCuenta TipoCuenta { get; set; }
        public double Saldo { get; set; }

        public String NombreTipoCuenta
        {
            get
            {
                return TipoCuenta.ToString();
            }
        }
    }

    public enum TipoCuenta
    {
        Ahorros,
        Corriente
    }
}
