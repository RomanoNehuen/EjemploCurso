using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    //Crear un proyecto de consola .Net Framework.
    //        Crear la clase Telefono(recordemos que una clase va en un archivo nuevo; click derecho en el proyecto, agregar, class).

    //Agregale los siguientes atributos:
    //Modelo string.
    //Marca string.
    //NumeroTelefonico string.
    //CodigoOperador int (1, 2 o 3).

    //Agregale las propiedades correspondientes.Podés hacer el formato largo o el corto.
    //Modelo: solo lectura. Es decir, solo get.
    //Marca: solo lectura.
    //NumeroTelefonico: lectura y escritura.
    //CodigoOperador: lectura y escritura.Validar escritura que solo admita 1, 2 o 3, caso contrario escribir un cero.

    //Agregar Constructor que reciba Modelo y Marca.
    //Crear algunos objetos en el main de Program y probar escribirle datos y mostrar en pantalla el estado del Telefono.
    //Agregar método Llamar() sin parámetros que devuelva un string con la leyenda "Realizando llamada...".
    //Sobrecargar el método Llamar(string contacto) para que reciba un contacto y devuelva un string con la leyenda "Llamando a " + contacto
    //Probar métodos en el main mostrando en pantalla el comportamiento de los objetos.

    internal class Telefono
    {
        //atributos
        private string modelo;
        private string marca;
        private string numeroTelefonico;
        private int codigoOperador;
        
        //Constructor

           public Telefono(string modelo, string marca)
        {
            this.modelo = modelo;
            this.marca = marca;
        }
        
        //propiedades
        public string Modelo 
        { get 
            { return modelo; } 
        }

        public string Marca
        {
            get { return marca; }
        }
       // set lectura
       // get escritura
        public string NumeroTelefonico 
        {
            get { return numeroTelefonico; }
            set { numeroTelefonico = value; }
         }
         public int CodigoOperador
        {
            get { return codigoOperador; }
            set 
                {
                codigoOperador = value;
                codigoOperador = Verificacion(codigoOperador);
                    }

            
        }
       
        public int Verificacion(int n)
        {
            if (n == 1 || n == 2 || n == 3)
            
                return n;
            
            else
                
                return 0;
            
        }
        // Metodos
        public string llamar()
        {
            return "Realizando llamada";
        }
        public string llamar(string contacto)
        {
            return "Llamando a " + contacto;
        }
    }
}
