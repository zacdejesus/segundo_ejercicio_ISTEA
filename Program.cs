using System;

namespace segundo_ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int vendidos1 = 0;
            int vendidos2 = 0;
            int total = 0;

            string[,] matrizProductos = new string[5,5];

            matrizProductos[0, 0] = "cartuchera";
            matrizProductos[0, 1] = "2310";
            matrizProductos[0, 2] = "10213";
            matrizProductos[0, 3] = "100";

            matrizProductos[1, 0] = "lapiz";
            matrizProductos[1, 1] = "5533";
            matrizProductos[1, 2] = "333";
            matrizProductos[1, 3] = "300";

            matrizProductos[2, 0] = "casa";
            matrizProductos[2, 1] = "30343";
            matrizProductos[2, 2] = "2342";
            matrizProductos[2, 3] = "250";

            matrizProductos[3, 0] = "perro";
            matrizProductos[3, 1] = "3023";
            matrizProductos[3, 2] = "263432";
            matrizProductos[3, 3] = "200";

            matrizProductos[4, 0] = "borrador";
            matrizProductos[4, 1] = "3032";
            matrizProductos[4, 2] = "12320";
            matrizProductos[4, 3] = "50";

            Console.Write("          producto            sucursal 1        sucursal 2          precio              total del vendidos\n");

            for (int c = 0; c < matrizProductos.GetLength(0); c++) 
            {
                int kmDos = int.Parse(matrizProductos[c, 1]);
                int kmTres = int.Parse(matrizProductos[c, 2]);

                int kmTotales = kmDos + kmTres ;
                 matrizProductos[c, 4] = $"{kmTotales}";
            }

            for (int f = 0; f < matrizProductos.GetLength(0); f++)
            {

               for (int c = 0; c < matrizProductos.GetLength(1); c++)
               {
                   if (!string.IsNullOrEmpty(matrizProductos[f, c]))
                   {
                       if (c == 0)
                       {
                           Console.Write("          {0,-10}", matrizProductos[f, c]);
                       }
                        else if  (c == 1)
                       {
                           Console.Write("          {0,-10}", matrizProductos[f, c]);
                       }
                        else if  (c == 2)
                       {
                           Console.Write("          {0,-10}", matrizProductos[f, c]);
                       }
                         else if  (c == 3)
                       {
                           Console.Write("          {0,-10}", matrizProductos[f, c]);
                       }
                        else if  (c == 4)
                       {
                           Console.Write("          {0,-10}", matrizProductos[f, c]);
                       }
                        else if  (c == 5)
                       {
                           Console.Write("          {0,-10}", matrizProductos[f, c]);
                       }
                                               else if  (c == 6)
                       {
                           Console.Write("          {0,-10}", matrizProductos[f, c]);
                       }
                                               else if  (c == 7)
                       {
                           Console.Write("          {0,-10}", matrizProductos[f, c]);
                       }
                                               else if  (c == 8)
                       {
                           Console.Write("          {0,-10}", matrizProductos[f, c]);
                       }
                                               else if  (c == 9)
                       {
                           Console.Write("          {0,-10}", matrizProductos[f, c]);
                       }
                                                                      else if  (c == 10)
                       {
                           Console.Write("          {0,-10}", matrizProductos[f, c]);
                       }
                       else
                       {
                           Console.Write($"{matrizProductos[f, c]  ,-3}\n");
                       }
                   }

               }
               Console.WriteLine("");  // salto de linea para mostrar la siguiente fila abajo 
            }

            Console.WriteLine("\n");

            for (int c = 0; c < matrizProductos.GetLength(0); c++) 
            {
                int totalProd1 = int.Parse(matrizProductos[c, 2]);

                total = totalProd1 + total;
            }

            Console.Write("cantidad de artículos en la sucursal 2.\n");
            Console.Write($"{total}\n\n");


            Console.Write("cantidad del articulo 3 en la sucursal 1.\n");
            Console.Write($"{matrizProductos[2, 1]}\n\n");

            Console.Write("recaudacion de la sucursal 1.\n");

            for (int c = 0; c < matrizProductos.GetLength(0); c++) 
            {
                int totalProdAux = int.Parse(matrizProductos[c, 1]);
                int axu = int.Parse(matrizProductos[c, 3]);

                totalProdAux = totalProdAux * axu;

                vendidos1 = totalProdAux + vendidos1;
            }
            Console.Write($"{vendidos1}\n\n");

            Console.Write("recaudacion de la sucursal 2.\n");

            for (int c = 0; c < matrizProductos.GetLength(0); c++) 
            {
                int totalProdAux = int.Parse(matrizProductos[c, 2]);
                int axu = int.Parse(matrizProductos[c, 3]);

                totalProdAux = totalProdAux * axu;

                vendidos2 = totalProdAux + vendidos2;
            }
            Console.Write($"{vendidos2}\n\n");

            Console.Write("recaudación total de la empresa.\n");

            int recaudacionTotal = vendidos1 + vendidos2;
            Console.Write($"{recaudacionTotal}\n\n");

            string sucursalMayor = vendidos1 > vendidos2 ? "1" : "2";
            Console.Write($" la sucursal {sucursalMayor} tiene mayor recaudacion\n\n");

            
            Console.ReadKey();
        }
    }
}
