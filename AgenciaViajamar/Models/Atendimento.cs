using System.ComponentModel.DataAnnotations;

namespace AgenciaViajamar.Models
{
    public class Atendimento
    {
        [Key]
        public int id { get; set; }
        public string nome { get; set; }
        public int telefone { get; set; }
        public string email { get; set; }
        public string mensagem { get; set;}
    }
}
