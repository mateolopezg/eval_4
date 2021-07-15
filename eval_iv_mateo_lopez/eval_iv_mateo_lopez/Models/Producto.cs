using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace eval_iv_mateo_lopez.Models
{
    public class Producto
    {
        [Key]
        public int id_producto { get; set; }

        //[StringLength(50, ErrorMessage = "El {0} debe ser más largo minimo 3 caracteres", MinimumLength = 3)]
        [Required(ErrorMessage = "Nombre Obligatorio")]
        //[Display(Name ="")]
        public string nombre_p { get; set; }

        [Required(ErrorMessage = "Valor Obligatorio")]
        public int valor { get; set; }

        [Required(ErrorMessage = "Stock Obligatorio")]
        public int stock { get; set; }
    }
}
