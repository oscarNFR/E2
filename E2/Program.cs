/* 
Oscar Noé Fuentes Rabago
331-11
*/

using System;

namespace E2
{
    class Program
    {
        static void Main(string[]args)
        {
            // Sintaxis Funcion
            //Definir funcion: void Saludar()
            // Parametros: ()
            
            int Saludar(int numero)
            {
                // Asignamos la operacion matematica 
                int resultado = numero + 5;
                // Usamos return para devolver el resultado
                return resultado;
            }
            // Invocamos la funcion Saluidar y le pasamos un argumento, en este caso el numero 10
            int devolucion = Saludar(10);
            // Lo imprimimos
            Console.WriteLine($"devolucion: {devolucion}");

            // Ciclo para imprimir numeros
            int numero = 2;
            while(numero < 28)
            {
                Console.WriteLine($"numero: {numero}");
                numero += 2;
                if(numero > 6)
                {
                    numero += 1;
                    if(numero > 15)
                    {
                        numero += 1;
                    }
                }
            }


            // Ciclo descendente y ascendente de inicio y limite
            int inicio = 7;
            int limite = 2;
            int ejecuciones = 9;
            int producto = inicio * limite;
            if(producto < 8 && inicio > limite)
            {
                while(ejecuciones > 0)
                {
                    Console.WriteLine($"Ejecuciones: {ejecuciones}");
                    ejecuciones--;
                }
                
            }
            else
            {
                while(ejecuciones < 15)
                {
                    Console.WriteLine($"Ejecuciones: {ejecuciones}");
                    ejecuciones++;
                }
            }

            //Invocar una funcion si un numero es multiplo de 5, y si el numero es multiplo de 5, imprimir true
             int numero2 = 14;

            void Multiplo()
            {
                

                if(numero2 % 5 == 0)
                {
                    Console.WriteLine($"El numero {numero2} es multiplo de 5: true");
                }
                else
                {
                    Console.WriteLine($"El numero {numero2} es multiplo de 5: false");
                }
            }

            Multiplo();

            // Definir una funcion vacia que imprima Programación III y el argumento sea Programacion III
            void Imprimir(string mensaje)
            {
                Console.WriteLine(mensaje);
            }

            Imprimir("Programación III");
          
        }
    }
}