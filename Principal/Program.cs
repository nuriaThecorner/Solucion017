using Datos;
using Datos.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.AnyadeCategoria();
            program.Comprobar();
            program.Modificar();
            program.Comprobar();
            program.Eliminar();
            program.Comprobar();
            program.EliminarTodosLosRegistrosQue();
            program.Comprobar();
            

        }

        //metodo
        //INSERT CREATE
        private void AnyadeCategoria()
        {
            Class1 class1 = null;
            class1 = new Class1();

            IList<Categoria> categorias = null;
            categorias = class1.DevuelveCategorias();

            Categoria categoria = null;
            categoria = new Categoria();

            categoria.CategoryName = "Zapatos";
            categoria.Description = "Accesorio ropa";

            categorias.Add(categoria);

            bool ok = false;

            ok = class1.GuardarCambios(categoria);

            Console.WriteLine("El registro ha sido guardado " + ok);

            Console.ReadLine();




        }

        //SELECT O READ
        private void Comprobar()
        {
            Class1 class1 = new Class1();
            IList<Categoria> categorias = class1.DevuelveCategorias();

            foreach (Categoria categoria in categorias)
            {
                Console.WriteLine(categoria.CategoryName);

            }
            Console.ReadLine();
        }


        //UPDATE
        private void Modificar()
        {
            Class1 class1 = new Class1();
            IList<Categoria> categorias = class1.DevuelveCategorias();



            foreach (Categoria categoria in categorias)
            {
                Console.WriteLine(categoria.CategoryID + " " + categoria.CategoryName);

            }
            Console.WriteLine("Dime el id del regitro a modificar");
            string texto = Console.ReadLine();
            int id = 0;
            if (int.TryParse(texto, out id) == true)
            {
                id = int.Parse(texto);
            }

            Console.WriteLine("Ahora dime el nuevo nombre");

            texto = Console.ReadLine();

            bool ok = false;

            ok = class1.GuardarRegistro(id, texto);

            Console.WriteLine("El resultado de la modificacion es " + ok);

            Console.ReadLine();

        }

        //DELETE

        private void Eliminar()
        {
            Class1 class1 = new Class1();
            IList<Categoria> categorias = class1.DevuelveCategorias();



            foreach (Categoria categoria in categorias)
            {
                Console.WriteLine(categoria.CategoryID + " " + categoria.CategoryName);

            }
            Console.WriteLine("Dime el id del registro a eliminar");
            string texto = Console.ReadLine();
            int id = 0;
            if (int.TryParse(texto, out id) == true)
            {
                id = int.Parse(texto);
            }



            bool ok = false;

            ok = class1.EliminarRegistro(id);

            Console.WriteLine("El resultado de la eliminación es " + ok);

            Console.ReadLine();

        }


        //Delete muchos registros

        private void EliminarTodosLosRegistrosQue()
        {

            Class1 class1 = new Class1();
            IList<Categoria> categorias = class1.DevuelveCategorias();



            foreach (Categoria categoria in categorias)
            {
                Console.WriteLine(categoria.CategoryID + " " + categoria.CategoryName);

            }
            Console.WriteLine("Dime el nombre del registro a eliminar");
            string texto = Console.ReadLine();
            string nombre = texto;
            //if (int.TryParse(texto, out id) == true)
            //{
            //    id = int.Parse(nombre);
            //}

            //Elimina todos los registros que tiene ese nombre


            bool ok = false;

            ok = class1.EliminarRegistros(nombre);

            Console.WriteLine("El resultado de la eliminación es " + ok);

            Console.ReadLine();








        }





    }
}
