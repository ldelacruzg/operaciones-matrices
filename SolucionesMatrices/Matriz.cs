using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionesMatrices
{
    public class Matriz
    {
        private int[,] matriz;
        private int filas;
        private int columnas;

        public Matriz(int[,] matriz)
        {
            this.matriz = matriz;
            filas = matriz.GetLength(0);
            columnas = matriz.GetLength(1);
        }

        public int[,] PropMatriz { get => matriz; }

        public static Matriz operator +(Matriz matrizA, Matriz matrizB)
        {
            if (matrizA.filas != matrizB.filas || matrizA.columnas != matrizB.columnas)
            {
                throw new Exception("Las matrices no tienen las mismas dimensiones");
            }

            int[,] result = new int[matrizA.filas, matrizA.columnas];
            for (int i = 0; i < matrizA.filas; i++)
            {
                for (int j = 0; j < matrizA.columnas; j++)
                {
                    result[i, j] = matrizA.matriz[i, j] + matrizB.matriz[i, j];
                }
            }

            return new Matriz(result);
        }

        public void Print()
        {
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
