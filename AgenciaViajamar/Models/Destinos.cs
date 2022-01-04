using System.ComponentModel.DataAnnotations;

namespace AgenciaViajamar.Models
{
    public class Destinos
    {
        [Key]
        public int id {get;set; }
        public string local { get; set; }
        public int quantidade { get;set; }
    }
}
