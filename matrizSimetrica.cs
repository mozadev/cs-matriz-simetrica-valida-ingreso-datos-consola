using System;

namespace pregunta2CompruebaSimetrica
{
    class Program
    {
        static void Main(string[] args)
        {
            int filas;
            int columnas;
            Console.WriteLine("ingrese el numero de filas: ");
            filas = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el numero de columnas: ");
            columnas = int.Parse(Console.ReadLine());
            int[,] matriz = new int[filas, columnas];

            llenadoMatriz(filas, columnas, matriz);
            validacionMatrizSimetrica(filas, columnas, matriz);
        }

        public static void llenadoMatriz(int filas, int columnas, int[,] matriz)
        {
            // llenar matriz
            for (int i = 0; i < filas; i++) //(i,j)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.WriteLine("ingrese el valor del arreglo [" + i + "][" + j + "]");
                    int valor = int.Parse(Console.ReadLine());
                    matriz[i, j] = valor;


                }

            }


            // imprimir matriz
            for (int i = 0; i < filas; i++) //(i,j)
            {
                for (int j = 0; j < columnas; j++)
                {

                    Console.Write(matriz[i, j] + " ");

                }
                Console.WriteLine("");
            }
            Console.WriteLine("");



        }

        public static void  validacionMatrizSimetrica(int filas, int columnas, int [,] matriz)
        {

            int contador = 0;
            if (filas ==columnas)
                for (int i = 0; i < filas; i++)
                    for (int j = 0; j < columnas; j++)
                        if (matriz[i,j] == matriz[j,i])
                        {
                            contador++;
                        }


            if (contador ==filas*columnas)
                Console.WriteLine( "la matriz SI es simetrica");
            else
                Console.WriteLine("la matriz NO es simetrica");


        }

    }
}