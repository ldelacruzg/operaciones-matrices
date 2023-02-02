using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionesMatrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matriz matrix1 = new Matriz(new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } });
            Matriz matrix2 = new Matriz(new int[3, 3] { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } });
            Matriz matrix3 = matrix1 + matrix2;

            matrix3.Print();

            Console.ReadKey();
        }
    }
}
