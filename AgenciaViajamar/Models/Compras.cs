using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgenciaViajamar.Models
{
    public class Compras
    {
        [Key]
        public int id { get; set; }
        [ForeignKey("Destinos")]
        public int idCompra { get; set; }
        [ForeignKey("Cliente")]
        public int idComprador { get; set; }
        public DateTime Ida { get; set; }
        public DateTime Volta { get; set; }

    }
}