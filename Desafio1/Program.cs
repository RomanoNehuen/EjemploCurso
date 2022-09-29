using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Telefono t1 = new Telefono("J7 Neo", "Samsung");
            Console.WriteLine(t1.Marca);
            Console.WriteLine(t1.Modelo);

            t1.NumeroTelefonico = 1165809207.ToString();

            Console.WriteLine("El numero de telefono es: " + t1.NumeroTelefonico);

          
                
            
            Console.WriteLine("ingrese codigo de operador");

            n = int.Parse(Console.ReadLine());

            t1.Verificacion(n);

            Console.WriteLine("Usted selecciono el codigo de operador siguiente: " + t1.Verificacion(n));

            Console.WriteLine(t1.llamar());

            Console.WriteLine(t1.llamar("Nehuen"));

            Console.ReadKey();
   

                



        }
    }
}
