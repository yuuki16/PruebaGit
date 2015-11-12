using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class CalculadoraUI
    {
        static void Main(string[] args)
        {
            int continuar = 1;
            try
            {
                do
                {
                    Console.Write("Digite el primer número:");
                    int numero1 = int.Parse(Console.ReadLine());
                    Console.Write("Digite el segundo número:");
                    int numero2 = int.Parse(Console.ReadLine());
                    Console.Write("¿Desea 1.sumar, 2.restar, 3.multiplicar o 4.dividir?");
                    int opcion = int.Parse(Console.ReadLine());
                    Entidades.Calculadora calc = new Entidades.Calculadora();
                    calc.Numero1 = numero1;
                    calc.Numero2 = numero2;
                    calc.Sumar(opcion);
                    int resultado = calc.Resultado;
                    Console.WriteLine(resultado);
                    Console.ReadKey();

                    Console.Write("Desea realizar otra operacion: 1. Si, 2.No");
                    continuar = int.Parse(Console.ReadLine());
                } while (continuar == 1);
            }
            catch (Exception e)
            {
                Console.WriteLine("{0}", e.Message);
                throw;
            }

        }
    }
}
