using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendamentoConsultas.Data.DTO;
using AgendamentoConsultas.Data.Model;

namespace AgendamentoConsultas.Data.Repository
{
    public class ConsultaRepository
    {
        private readonly DataContext _dataContext;

        public ConsultaRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<ConsultaDTO> GetAll()
        {
            List<ConsultaDTO> consultasDTOs = new List<ConsultaDTO>();
            foreach (var item in _dataContext.Consultas.ToList())
            {
                consultasDTOs.Add(ModelToDto(item));
            }
            return consultasDTOs;
        }
        private ConsultaDTO ModelToDto(Consulta coin)
        {
            ConsultaDTO consultaDTO = new ConsultaDTO();
            consultaDTO.ConsultaId = coin.ConsultaId;
            consultaDTO.Cpf = coin.Cpf;
            consultaDTO.NomeCliente = coin.NomeCliente;
            consultaDTO.Data = coin.Data;

            return consultaDTO;
        }
    }
}
