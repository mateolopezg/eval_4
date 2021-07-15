using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace eval_iv_mateo_lopez.Models
{
    public class Cliente
    {
        

        [Key]
        public int id_cliente { get; set; }

        [Required(ErrorMessage = "Nombre Obligatorio")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "Rut Obligatorio")]
        public string rut { get; set; }

        [Required(ErrorMessage = "Dirección Obligatorio")]
        public string direccion { get; set; }

        [Required(ErrorMessage = "Teléfono Obligatorio")]
        public string telefono { get; set; }
        public List<Producto> productos { get; set; }
        public int cantidad { get; set; }

    }
}
