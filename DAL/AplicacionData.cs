using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Entity.model;
using Mapper;
using Microsoft.EntityFrameworkCore;


namespace DAL
{
    public class AplicacionData
    {

        private static AppDbContext getAppDbContext()
        {
            AppDbContextFactory appDbContextFactory = new AppDbContextFactory();
            AppDbContext appDbConext = appDbContextFactory.CreateDbContext(null);
            return appDbConext;
        }

        public void InsertarAplicacion(AplicacionEntity app)
        {
			try
			{
				AppDbContext appDbContext = getAppDbContext();
                using (appDbContext) 
                {
                    Aplicacion aplicacion = Mapper.AplicacionMapper.Map(app);
                    appDbContext.Entry(aplicacion.Categoria).State = EntityState.Unchanged;
                    appDbContext.Aplicaciones.Add(aplicacion);
                    appDbContext.SaveChanges();
                }
			}
			catch (Exception)
			{

				throw;
			}
        }

        public List<AplicacionEntity> GetAplicacionEntities()
        {
            try
            {

                AppDbContext appDbContext = getAppDbContext();
                using (appDbContext)
                {
                    List<Aplicacion> apps = appDbContext.Aplicaciones.Include(e => e.Categoria).ToList();
                    return apps.Select(e => AplicacionMapper.Map(e)).ToList();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void ModificarAplicacion(AplicacionEntity app, int id)
        {
            try
            {
                AppDbContext appDbContext = getAppDbContext();
                using (appDbContext)
                {
                    Aplicacion aplicacionToUpdate = appDbContext.Aplicaciones.Where(aplicacion => aplicacion.Id == id).FirstOrDefault()!;
                    aplicacionToUpdate.Titulo = app.Titulo;
                    aplicacionToUpdate.Descripcion = app.Descripcion;
                    aplicacionToUpdate.Desarrolladora = app.Desarrolladora;
                    aplicacionToUpdate.Precio = app.Precio;
                    appDbContext.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void EliminarAplicacion(int id) 
        {
            try
            {
                AppDbContext appDbContext = getAppDbContext();
                using (appDbContext)
                {
                    Aplicacion aplicacionToDelete = appDbContext.Aplicaciones.Where(aplicacion => aplicacion.Id == id).FirstOrDefault()!;
                    appDbContext.Aplicaciones.Remove(aplicacionToDelete);
                    appDbContext.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
