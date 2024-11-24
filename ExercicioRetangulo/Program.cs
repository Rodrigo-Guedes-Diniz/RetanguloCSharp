using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioRetangulo {
    internal class Program {

        static void Main(string[] args) {

            Retangulo retangulo = new Retangulo();

            Console.WriteLine("entre a largura e a altura do retângulo para calcular a Area, o Perímetro e a Diagonal");
            Console.Write("Altura: ");
            retangulo.altura = double.Parse(Console.ReadLine());
            Console.Write("Largura: ");
            retangulo.largura = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Area = " + retangulo.Area());
            Console.WriteLine("Perimetro = " + retangulo.Perimetro());
            Console.WriteLine("Diagonal = " + retangulo.Diagonal());



        }
    }
}
