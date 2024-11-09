using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class AplicacionEntity
    {

        private int id;
        private string titulo;
        private string descripcion;
        private string desarrolladora;
        private double precio;
        private CategoriaEntity categoria;

        public int Id { get => id; set => id = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Desarrolladora { get => desarrolladora; set => desarrolladora = value; }
        public double Precio { get => precio; set => precio = value; }
        public CategoriaEntity Categoria { get => categoria; set => categoria = value; }

        
    }
}
