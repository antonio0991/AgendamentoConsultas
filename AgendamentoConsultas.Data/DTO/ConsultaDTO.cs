using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendamentoConsultas.Data.DTO
{
    public class ConsultaDTO
    {
        public int ConsultaId { get; set; }
        public string Cpf { get; set; }
        public string NomeCliente { get; set; }
        public DateTime Data { get; set; }
    }
}
