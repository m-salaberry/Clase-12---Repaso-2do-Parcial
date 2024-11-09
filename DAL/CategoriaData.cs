using Entity;
using Entity.model;
using Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DAL
{
    public class CategoriaData
    {

        private static AppDbContext getAppDbContext()
        {
            AppDbContextFactory appDbContextFactory = new AppDbContextFactory();
            AppDbContext appDbConext = appDbContextFactory.CreateDbContext(null);
            return appDbConext;
        }

        public List<CategoriaEntity> ExtraerCategorias()
        {
            try
            {
                List<CategoriaEntity> cats = new List<CategoriaEntity>();

                AppDbContext appDbContext = getAppDbContext();
                using (appDbContext) 
                {
                    var categorias = appDbContext.Categorias.ToList();
                    foreach (var item in categorias)
                    {
                        CategoriaEntity cat = CategoriaMapper.Map(item);
                        cats.Add(cat);
                    }
                    return cats;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public CategoriaEntity? getById(int id)
        {
            try
            {
                AppDbContext appDbContext = getAppDbContext();
                using (appDbContext) 
                {
                    Categoria categoria = appDbContext.Categorias.Where(t => t.Id == id).FirstOrDefault()!;
                    return categoria != null ? CategoriaMapper.Map(categoria) : null;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
