using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C__project.Models
{
    public class Exceções
    {

        public void Metodo1()
        {
            try
            {
                Metodo2();
            }
            catch (Exception ex)
            {

                Console.WriteLine("exceção tratada " + ex.Message);
            }

        }
        public void Metodo2()
        {
            Metodo3();
        }
        public void Metodo3()
        {
            Metodo4();

        }
        public void Metodo4()
        {
            throw new Exception("Ocorreu um erro");
        }
    }

}