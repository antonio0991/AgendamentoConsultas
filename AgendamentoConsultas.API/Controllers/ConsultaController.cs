using AgendamentoConsultas.Data.Model;
using AgendamentoConsultas.Data.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AgendamentoConsultas.Data.Controllers
{
    [Route("api/consultas")]
    [ApiController]
    public class ConsultaController : ControllerBase
    {
        private readonly DataContext _dataContext;
        private readonly ConsultaRepository _consultaRepository;

        public ConsultaController(DataContext dataContext)
        {
            _dataContext = dataContext;
            _consultaRepository = new ConsultaRepository(dataContext);
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            return Ok(_consultaRepository.GetAll());
        }

        [HttpGet("{ConsultaId}")]
        public ActionResult GetById(int ConsultaId)
        {
            return Ok(_dataContext.Consultas.Find(ConsultaId));
        }

        [HttpPost]
        public ActionResult Post([FromBody]Consulta consulta)
        {
            if (string.IsNullOrWhiteSpace(consulta.Cpf) || string.IsNullOrWhiteSpace(consulta.NomeCliente))
                return NoContent();

            _dataContext.Consultas.Add(consulta);
            _dataContext.SaveChanges();
            return Ok(consulta);
        }

        [HttpPut("{ConsultaId}")]
        public ActionResult Put([FromBody]Consulta newConsulta, int ConsultaId)
        {
            Consulta consulta = _dataContext.Consultas.Find(ConsultaId);
            if (consulta == null) return NoContent();

            consulta.Cpf = newConsulta.Cpf;
            consulta.NomeCliente = newConsulta.NomeCliente;
            consulta.Data = newConsulta.Data;

            _dataContext.SaveChanges();
            return Ok(consulta);
        }

        [HttpDelete("{ConsultaId}")]
        public ActionResult Delete(int ConsultaId)
        {
            Consulta consulta = _dataContext.Consultas.Find(ConsultaId);

            if(consulta == null)
                return NoContent();

            _dataContext.Consultas.Remove(consulta);
            _dataContext.SaveChanges();
            return Ok($"Consulta com ID {ConsultaId} removida");
        }
    }
}
