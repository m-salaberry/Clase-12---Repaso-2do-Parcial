using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.model
{
    public class Aplicacion
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int IdCategoria { get; set; }
        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public string Desarrolladora { get; set; }
        [Required]
        public double Precio { get; set; }

        [ForeignKey("IdCategoria")]
        public Categoria Categoria { get; set; }
        

    }
}
