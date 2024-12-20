using RetanguloX;
using System;
using System.ComponentModel.Design;
using System.Globalization;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                CultureInfo CI = CultureInfo.InvariantCulture;
                                    
                Retangulo ret = new Retangulo();

                Console.WriteLine("Entre com as Largura do Retangulo: ");
                ret.Largura = double.Parse(Console.ReadLine(), CI);
                ret.Altura = double.Parse(Console.ReadLine(), CI);


                Console.WriteLine("AREA = " + ret.Area().ToString("F4", CI));
                Console.WriteLine("PERIMETRO = " + ret.Perimetro().ToString("F4", CI));
                Console.WriteLine("DIAGONAL = " + ret.Diagonal().ToString("F4", CI));
            }
        }
    }
}