using System;
using Microsoft.VisualBasic;
using Xceed.Wpf.Toolkit;

namespace Sudoku
{
    public class Program
    {
        bool datoRepetido = false;
        string cad = "";
        int contador = 0;
        int[] Arreglo = { 1, 2, 3, 4, 5, 6, 6 };
        int[] numerosUnoAlNueve = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        int[,] Matriz = new int[3, 3]
                {{1,1,7},
                {2,1,8},
                {3,6,9} };


        public bool Linea_Matriz(){
            //Console.WriteLine("Introduce un numero");
            for(int i=0; i<Arreglo.Length;i++){
                //Arreglo[i] = int.Parse(Console.ReadLine());
                // for(int j=0;j<numerosUnoAlNueve.Length;j++){
                // }
                    if(Arreglo[i]==numerosUnoAlNueve[0] || Arreglo[i] == numerosUnoAlNueve[1] || 
                    Arreglo[i] == numerosUnoAlNueve[2] || Arreglo[i] == numerosUnoAlNueve[3] || 
                    Arreglo[i] == numerosUnoAlNueve[4] || Arreglo[i] == numerosUnoAlNueve[5]
                    || Arreglo[i] == numerosUnoAlNueve[6] || Arreglo[i] == numerosUnoAlNueve[7]
                    || Arreglo[i] == numerosUnoAlNueve[8])
                {
                        contador++;
                        
                    if (contador > 1)
                        {
                            datoRepetido = true;
                            Console.WriteLine("false");
                            break;
                        }
                    } 
            }
            return datoRepetido;
        }
        public void MatrizDosDimensiones_Verticales()
        {
            int pibote = 0;
            int contador = 0;
            int limite = 0;
            int[] numerosUnoAlNueve = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int filas = 0; filas < Matriz.GetLength(0); filas++)//renglon
            {
                for (int col = 0; col < Matriz.GetLength(1); col++)
                {
                    do
                    {
                        Console.Write(Matriz[filas, col]);
                        if (Matriz[pibote, filas] == numerosUnoAlNueve[0])
                        {
                            contador++;
                            if (contador > 1)
                            {
                                Console.WriteLine("\nSe repite un numero en alguna fila");

                            }
                        }
                        pibote++;
                        break;
                    } while (limite == filas);
                }
                limite++;
                pibote = 0;
                contador = 0;
                Console.WriteLine();
            }
        }
        public void MatrizDosDimensiones_Horizontales()
        {
            int pibote = 0;
            int contador = 0;
            int limite = 0; 
            int[] numerosUnoAlNueve = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int filas = 0; filas < Matriz.GetLength(0); filas++)//renglon
            {
                for (int col = 0; col < Matriz.GetLength(1); col++)
                {
                    do
                    {
                        Console.Write(Matriz[filas, col]);
                        if (Matriz[filas, pibote] == numerosUnoAlNueve[0])
                        {
                            contador++;
                            if (contador > 1)
                            {
                                Console.WriteLine("\nSe repite un numero en alguna fila");

                            }
                        }
                        pibote++;
                        break;
                    } while (limite == filas);                    
                }
                limite++;
                pibote = 0;
                contador = 0;
                Console.WriteLine();
            }
            
        }
        //public void MatrizDosDimensiones3_3_incompleto()
        //{
        //    int pibote = 0;
        //    int contador = 0;
        //    int[] numerosUnoAlNueve = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        //    for (int filas = 0; filas < Matriz.GetLength(0); filas++)//renglon
        //    {
        //        for (int col = 0; col < Matriz.GetLength(1); col++)
        //        {
        //            Console.Write(Matriz[filas, col]);
        //            if (Matriz[filas, pibote] == numerosUnoAlNueve[6])
        //            {
        //                contador++;
        //                if (contador > 1)
        //                {
        //                    Console.WriteLine("\nSe repite un numero en alguna fila");
        //                }
        //            }
        //            pibote++;
        //        }
        //        pibote = 0;
        //        Console.WriteLine();
        //    }
        //}
        public static void Main(string[] args)
        {
            Program a = new Program();
            a.MatrizDosDimensiones_Verticales();
        }
    }
}
