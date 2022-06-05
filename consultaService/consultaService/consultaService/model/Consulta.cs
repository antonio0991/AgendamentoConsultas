using System;
using System.Collections.Generic;
using System.Text;

namespace consultaService.model
{
    public class Consulta
    {
        public int ConsultaId { get; set; }

        public string Cpf { get; set; }

        public string NomeCliente { get; set; }

        public DateTime Data { get; set; }

    }
}
