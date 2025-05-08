using MisPrimerasAPIs.Models;

namespace MisPrimerasAPIs.Repositorios
{
    public class ClientesRepository
    {
        private CuentaRepository _cuentaRepository;
        public ClientesRepository()
        {
            _cuentaRepository = new CuentaRepository();
        }

        public IEnumerable<Cliente> ObtenerListadoClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            Cliente cliente1 = new Cliente
            {
                Identificacion = "123456789",
                Correo = "hola@udla.du.ec",
                Nombre = "Juan Perez",
                Cuentas = _cuentaRepository.ObtenerListadoCuentasPorCliente("123456789"),


            };
            Cliente cliente2 = new Cliente
            {
                Identificacion = "12345678",
                Correo = "holaaa@udla.du.ec",
                Nombre = "HOla",
                Cuentas = _cuentaRepository.ObtenerListadoCuentasPorCliente("12345678"),


            };

            clientes.Add(cliente1);
            clientes.Add(cliente2);
            return clientes;

        }

        public Cliente ObtenerInfoClientePorIdentificacion(string Identificacion)
        {
            var clientes = ObtenerListadoClientes();
            Cliente cliente = clientes.FirstOrDefault(item => item.Identificacion == Identificacion);
            return cliente;

        }

        public bool CrearCliente(Cliente cliente)
        {
            try
            {
                List<Cliente> clientes = ObtenerListadoClientes().ToList();
                clientes.Add(cliente);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ActualizarCliente(Cliente cliente)
        {
            try
            {
                List<Cliente> clientes = ObtenerListadoClientes().ToList();
                var clienteExistente = clientes.FirstOrDefault(item => item.Identificacion == cliente.Identificacion);
                if (clienteExistente != null)
                {
                    clienteExistente.Nombre = cliente.Nombre;
                    clienteExistente.Correo = cliente.Correo;
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EliminarCliente(string Identificacion)
        {
            try
            {
                List<Cliente> clientes = ObtenerListadoClientes().ToList();
                var clienteExistente = clientes.FirstOrDefault(item => item.Identificacion == Identificacion);
                if (clienteExistente != null)
                {
                    clientes.Remove(clienteExistente);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
