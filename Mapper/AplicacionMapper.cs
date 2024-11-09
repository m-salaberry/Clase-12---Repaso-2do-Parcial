using Entity;
using Entity.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class AplicacionMapper
    {

        public static AplicacionEntity Map(Aplicacion app)
        {
            return new AplicacionEntity
            {
                Id = app.Id,
                Titulo = app.Titulo,
                Descripcion = app.Descripcion,
                Desarrolladora = app.Desarrolladora,
                Precio = app.Precio,
                Categoria = CategoriaMapper.Map(app.Categoria)
            };
        }

        public static Aplicacion Map(AplicacionEntity app)
        {
            return new Aplicacion
            {
                Id = app.Id,
                Titulo = app.Titulo,
                Descripcion = app.Descripcion,
                Desarrolladora = app.Desarrolladora,
                Precio = app.Precio,
                Categoria = CategoriaMapper.Map(app.Categoria)
            };
        }

    }
}
