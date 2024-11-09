using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entity.model
{
    public class Categoria
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string Descripcion { get; set; }

    }
}
