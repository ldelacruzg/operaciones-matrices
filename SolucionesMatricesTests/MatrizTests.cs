using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolucionesMatrices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionesMatrices.Tests
{
    [TestClass()]
    public class MatrizTests
    {
        [TestMethod()]
        public void Sum_DosMatrices_RetornandoResultadoCorrecto()
        {
            // Arrange
            Matriz matrizA = new Matriz(new int[,]
            {
                { 5, 4, 3 },
                { 8, 2, 1 },
                { 6, 5, 8 }
            });

            Matriz matrizB = new Matriz(new int[,]
            {
                { 2, 5, 8 },
                { 5, 8, 1 },
                { 8, 5, 2 }
            });

            // Act
            Matriz matrizResultado = matrizA + matrizB;

            // Assert
            CollectionAssert.AreEqual(new int[,]
            {
                { 7, 9, 11 },
                { 13, 10, 2 },
                { 14, 10, 10 }
            }, matrizResultado.PropMatriz);
        }

        [TestMethod()]
        [ExpectedException(typeof(Exception), "Las matrices no tienen las mismas dimensiones")]
        public void Sum_DosMatricesConDimensionesDiferentes_ThrowsExcption()
        {
            // Arrange
            Matriz matrizA = new Matriz(new int[,] 
            { 
                { 1, 2, 3 }, 
                { 4, 5, 6 }, 
                { 7, 8, 9 } 
            });

            Matriz matrizB = new Matriz(new int[,] 
            { 
                { 9, 8, 7 }, 
                { 6, 5, 4 } 
            });

            // Act
            Matriz matrix3 = matrizA + matrizB;

            // Assert, se espera que haya una Exception
        }
    }
}