using MisPrimerasAPIs.Models;

namespace MisPrimerasAPIs.Repositorios
{
    public class CuentaRepository
    {
        public IEnumerable<Cuenta> ObtenerListadoCuentasPorCliente(string Identificacion)
        {
            List<Cuenta> cuentas = new List<Cuenta>();
            Cuenta cuenta1 = new Cuenta
            {
                NumeroCuenta = 123456,
                TipoCuenta = TipoCuenta.Ahorros,
                Saldo = 1000.00
            };

            Cuenta cuenta2 = new Cuenta 
            {
                NumeroCuenta = 654321,
                TipoCuenta = TipoCuenta.Corriente,
                Saldo = 2000.00
            };
            cuentas.Add(cuenta1);
            cuentas.Add(cuenta2);
            return cuentas;





        }
    }
}
