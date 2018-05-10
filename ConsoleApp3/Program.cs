using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
   
        class Program
        {
           

            static int Suma(int a, int b)
            {
                int suma = a + b;
                return suma;
            }
            static int Resta(int a, int b)
            {
                int resta = a - b;
                return resta;
            }
            static int Multi(int a, int b)
            {
                int multi = a * b;
                return multi;
            }
            static int Division(int a, int b)
            {
                int divi = a / b;
                return divi;
            }
            // Main el principal
            static void Main(string[] args)
            {

                int a, b;
                Console.Write("Ingrese el primer numero: ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el segundo numero: ");
                b = int.Parse(Console.ReadLine());

                Console.Write("1º) Suma" + "\n" + "2º) Resta" + "\n" + "3º) Multiplicación" + "\n" + "4º) División" + "<strong>\n");
                Console.Write("Seleccione una opción: ");

                switch (Console.Read())
                {
                    case '1':
                        Console.Write("Suma = " + Suma(a, b));
                        break;
                    case '2':
                        Console.Write("Resta = " + Resta(a, b));
                        
                        break;
                    case '3':
                        Console.Write("Multiplicación = " + Multi(a, b));
                       
                        break;
                    case '4':
                        Console.Write("División = " + Division(a, b));
                      
                        break;
                }
                Console.ReadKey();
            }
        }
    }

  
