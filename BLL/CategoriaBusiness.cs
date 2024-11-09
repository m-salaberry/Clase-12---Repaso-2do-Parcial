using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CategoriaBusiness
    {

		CategoriaData categoriaData = new CategoriaData();

        public List<CategoriaEntity> ObtenerCategorias()
        {
			try
			{
				return categoriaData.ExtraerCategorias();
			}
			catch (Exception)
			{

				throw;
			}
        }

    }
}
