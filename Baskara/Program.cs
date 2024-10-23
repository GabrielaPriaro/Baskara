//Problema "baskara"
//Fazer um programa para ler os três coeficientes de uma equação do segundo grau. Usando a fórmula
//de Baskara, calcular e mostrar os valores das raízes x1 e x2 da equação com quatro casas decimais,
//conforme exemplo. Se a equação não possuir raízes reais, mostrar uma mensagem.

using System.Globalization;

namespace Baskara
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, raizX1, raizX2;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Coeficiente a: ");
            a = double.Parse(Console.ReadLine(), CI);

            Console.Write("Coeficiente b: ");
            b = double.Parse(Console.ReadLine(), CI);

            Console.Write("Coeficiente c: ");
            c = double.Parse(Console.ReadLine(), CI);

            delta = (b * b) - (4 * a * c);

            if (a == 0 || delta < 0)
            {
                Console.WriteLine("Esta equacao nao possui raizes reais");
            }
            else
            {
                raizX1 = (-b + Math.Sqrt(delta)) / (2 * a);
                raizX2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"X1 = {raizX1.ToString("F4", CI)}");
                Console.WriteLine($"X2 = {raizX2.ToString("F4", CI)}");
            }

        }
    }
}
