using System.ComponentModel.DataAnnotations;

namespace AgenciaViajamar.Models
{
    public class Cliente
    {
        [Key]
        public int id { get; set; }
        public string? nome { get; set; }
        public int CPF { get; set; }
        public int telefone { get; set; }
        public string? email { get; set; }
        public DateTime nascimento { get; set; }

        public virtual Compras? Compras { get; set; }
    }
}
