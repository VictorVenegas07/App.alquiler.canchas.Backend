using App.canchas.Dominio.Entidades;
using App.canchas.Dominio.Services;
using App.canchas.infraestructura.datos.Contexto;
using App.canchas.infraestructura.datos.Repositorios;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace App.chamchas.infraestructura.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservaController : ControllerBase
    {
        private readonly ReservaRepositori reservaRepositori;
        private readonly ClienteRepositorio clienteRepositorio;
        private readonly CanchaRepositorio canchaRepositorio;
        private readonly PagoRepositorio pagoRepositorio;
        private readonly ServicioReserva servicio;
        public ReservaController(CanchaContext context)
        {
            reservaRepositori = new ReservaRepositori(context);
            clienteRepositorio = new ClienteRepositorio(context);
            canchaRepositorio = new CanchaRepositorio(context);
            pagoRepositorio = new PagoRepositorio(context);
            servicio = new ServicioReserva(reservaRepositori,clienteRepositorio,canchaRepositorio,pagoRepositorio);
        }
        // GET: api/<ReservaController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ReservaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ReservaController>
        [HttpPost]
        public async Task<ActionResult<FormularioReserva>> Post(FormularioReserva value)
        {
            FormularioReserva res = await servicio.AgregarAsync(value);
            Ok(res);
            return (FormularioReserva)res;

        }

        // PUT api/<ReservaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ReservaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
