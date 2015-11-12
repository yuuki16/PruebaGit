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
            Console.Write("Digite el primer número:");
            int numero1 = int.Parse(Console.ReadLine());
            Console.Write("Digite el segundo número:");
            int numero2 = int.Parse(Console.ReadLine());
            Console.Write("¿Desea sumar o restar?");
            string opcion = Console.ReadLine();
            Entidades.Calculadora calc = new Entidades.Calculadora();
            calc.Numero1 = numero1;
            calc.Numero2 = numero2;
            calc.Sumar(opcion);
            int resultado = calc.Resultado;
            Console.WriteLine(resultado);
            Console.ReadKey();
        }
    }
}
