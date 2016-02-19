using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.IO;

namespace Textoss
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter fichero;
            StreamReader fichero2;
            String Linea;
            fichero = File.CreateText("Prueba.txt");
            fichero.WriteLine("Primera linea");
            fichero.Close();
            fichero.WriteLine("Segunda linea");
            fichero.Close();
            fichero2 = File.OpenText("Prueba.txt");
            Linea = fichero2.ReadLine();
            Console.WriteLine(Linea);
            Console.WriteLine(fichero2.ReadLine());
            fichero2.Close();
        }
    }

    class Program 2 
        static void Main(string[] args)
        {
            StreamWriter ficha;
            String linea;
            StreamReader leer;
            String respuesta = "";

            ficha = File.CreateText("Prueba3.txt");
           // do
            //{
                Console.WriteLine("Ingrese frases");
                do
                {
                    linea = Console.ReadLine();
                    ficha.WriteLine(linea);
                    Console.Clear();
                } while (linea != "Fin");
                ficha.Close();
                leer = File.OpenText("Prueba3.txt");
                while ((linea = leer.ReadLine()) != null)
                    Console.WriteLine(linea);
                Console.ReadKey();
               /* Console.WriteLine("Desea continuar");
                respuesta = Console.ReadLine();

            } while (respuesta == "si");*/
        }
}
