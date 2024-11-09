using DAL;
using Entity;
using Entity.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;


namespace BLL
{
    public class AplicacionBusiness
    {

        private AplicacionData appData = new AplicacionData();
        List<CategoriaEntity> categorias = new List<CategoriaEntity>();
        CategoriaBusiness catBusiness = new CategoriaBusiness();
        

        public void CargarAplicacion(List<AplicacionEntity> aplicaciones)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    foreach (var app in aplicaciones)
                    {
                        VerificarApps(app);
                    }
                    trx.Complete();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void VerificarApps(AplicacionEntity app)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    if (app.Precio < 0)
                    {
                        throw new Exception("El precio no puede ser menor a 0");
                    }
                    if (app.Titulo.Length < 5)
                    {
                        throw new Exception("El titulo debe tener al menos 5 caracteres");
                    }
                    if (app.Descripcion.Length < 15)
                    {
                        throw new Exception("La descripcion debe tener al menos 15 caracteres");
                    }
                    if (app.Categoria == null)
                    {
                        throw new Exception("La categoria no puede ser nula");
                    }
                    if (VerificarCategoria(app) ==  false)
                    { 
                       throw new Exception("La categoria debe existir en la base de datos");
                    }
                    appData.InsertarAplicacion(app);
                    trx.Complete();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool VerificarCategoria(AplicacionEntity app)
        {
            try
            {
                categorias = catBusiness.ObtenerCategorias();
                foreach (var cat in categorias)
                {
                    if (app.Categoria.Id == cat.Id)
                    {
                        return true;
                    }
                }
                return false;
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
                if (VerificarId(id) == false)
                {
                    throw new Exception("El id no existe en la base de datos");
                }
                appData.ModificarAplicacion(app, id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool VerificarId(int id)
        {
            try
            {
                List<AplicacionEntity> aplicaciones = appData.GetAplicacionEntities();
                foreach (var app in aplicaciones)
                {
                    if (app.Id == id)
                    {
                        return true;
                    }
                }
                return false;
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
                if (VerificarId(id) == false)
                {
                    throw new Exception("El id no existe en la base de datos");
                }
                appData.EliminarAplicacion(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<AplicacionEntity> ObtenerAplicaciones()
        {
            try
            {
                return appData.GetAplicacionEntities();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
