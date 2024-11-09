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
    public class CategoriaMapper
    {
        public static CategoriaEntity Map(Categoria cat)
        {
            return new CategoriaEntity
            {
                Id = cat.Id,
                Descripcion = cat.Descripcion
            };
        }

        public static Categoria Map(CategoriaEntity cat)
        {
            return new Categoria
            {
                Id = cat.Id,
                Descripcion = cat.Descripcion
            };


        }
    }
}

