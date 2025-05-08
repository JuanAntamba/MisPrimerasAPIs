using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using MisPrimerasAPIs.Models;
using MisPrimerasAPIs.Repositorios;

namespace MisPrimerasAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly ClientesRepository _clientesRepository;

        public ClientesController()
        {
            _clientesRepository = new ClientesRepository();
        }

        [HttpGet]
        [Route("List")]
        public IEnumerable<Cliente> ObtenerListadoClientes()
        {
            return _clientesRepository.ObtenerListadoClientes();
        }


        [HttpGet]
        [Route("Details{Identificacion}")]
        public IActionResult ObtenerInformacionClientePorIdentificacion(string Identificacion)
        {
            try
            {
                var cliente = _clientesRepository.ObtenerInfoClientePorIdentificacion(Identificacion);
                return Ok(cliente);

            }
            catch (Exception)
            {
                return StatusCode(500);
            }

        }

        [HttpPost]
        [Route("Create")]
        public IActionResult CrearCliente([FromBody] Cliente cliente)
        {
            var guardar = _clientesRepository.CrearCliente(cliente);
            if (guardar)
            {
                return Ok();
            }
            else
            {
                return StatusCode(500);
            }
        }

        [HttpPut]
        [Route("Update")]
        public IActionResult ActualizarCliente([FromBody] Cliente cliente)
        {
            var actualizar= _clientesRepository.ActualizarCliente(cliente);
            if (actualizar)
            {
                return Ok();
            }
            else
            {
                return StatusCode(500);
            }
        }

        [HttpDelete]
        [Route("Delete /{Identificacion}")]
        public IActionResult EliminarCliente(string Identificacion)
        {
            var eliminar = _clientesRepository.EliminarCliente(Identificacion);
            if (eliminar)
            {
                return Ok();
            }
            else
            {
                return StatusCode(500);
            }
        }
    }
}
