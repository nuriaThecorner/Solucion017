using Datos.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{

    public class Class1
    {

        private static NorthWindTuneadoDbContext _dbContext = null;

        //constructor
        public Class1()
            {
            if (_dbContext== null)
            {
                _dbContext = new NorthWindTuneadoDbContext();
            }
             
    }

        //metodo
        public IList<Categoria> DevuelveCategorias()
        {
            IList<Categoria> categorias = null;
            categorias = _dbContext.Categoria.ToList();

            return categorias;
        }

        public bool GuardarCambios(Categoria categoria)
        {
            bool ok = false;
            int respuesta = 0;

            try
            {
                _dbContext.Categoria.Add(categoria);
                respuesta = _dbContext.SaveChanges();

                if (respuesta > 0)
                {
                    ok = true;
                }

            }
            catch (Exception)
            {

                throw;
            }

            return ok;

        }




        public bool GuardarRegistro(int id, string texto)
        {
            bool ok = false;
            Categoria categoria = null;
            //Categoria categoria = _dbContext.Categoria.Find(id);
            categoria = _dbContext.Categoria.Where(x=>x.CategoryID== id).FirstOrDefault();
            categoria.CategoryName = texto;

            try
            {
                int respuesta = 0;
                respuesta = _dbContext.SaveChanges();

                if (respuesta > 0)
                {
                    ok = true;
                }

            }
            catch (Exception)
            {

                throw;
            }

            return ok;

        }



        public bool EliminarRegistro(int id)
        {
            bool ok = false;


            Categoria categoria = null;

            categoria = _dbContext.Categoria.Where(x => x.CategoryID == id).FirstOrDefault();

            _dbContext.Categoria.Remove(categoria);

            try
            {
                int respuesta = 0;
                respuesta = _dbContext.SaveChanges();

                if (respuesta > 0)
                {
                    ok = true;
                }

            }
            catch (Exception)
            {

                throw;
            }

            return ok;

        }



        public bool EliminarRegistros(string nombre)
        {
            bool ok = false;


            Categoria categoria = null;

            categoria = _dbContext.Categoria.Where(x => x.CategoryName == nombre).FirstOrDefault();

            _dbContext.Categoria.Remove(categoria);

            try
            {
                int respuesta = 0;
                respuesta = _dbContext.SaveChanges();

                if (respuesta > 0)
                {
                    ok = true;
                }

            }
            catch (Exception)
            {

                throw;
            }

            return ok;

        }


    }
}
