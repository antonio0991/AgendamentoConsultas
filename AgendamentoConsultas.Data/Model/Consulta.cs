using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgendamentoConsultas.Data.Model
{
    public class Consulta
    {   
        public int ConsultaId { get; set; }
        [Column(TypeName="char(11)")]
        public string Cpf { get; set; }
        [Column(TypeName = "varchar(60)")]
        public string NomeCliente { get; set; }
        public DateTime Data { get; set; }

    }
}
