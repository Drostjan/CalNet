using System;
using System.Collections;
namespace ExamenBonito{
    class MenuBonito{
        /*
        2.-  Se quiere rellenar una matriz de 8 * 8 con valores entre 1 y 99 de forma aleatoria pero todos deben ser diferentes.
        En un menú de opciones nos dará las opciones de:
        Generar / regenerar la matriz de números aleatorios.
        Mostrar la matriz generada por pantalla.
        Ordenar los números por filas de manera creciente.
        Ordenar los números por columnas de manera creciente.
        “Permutar” entre sí los dígitos de cada número, quedando invariables (obviamente) si son de sólo un dígito.
        */
        static void Menu(){
            Console.WriteLine("1.Generar/Regenerar matriz con numeros aleatorios.");
            Console.WriteLine("2.Mostrar la matriz generada por pantalla.");
            Console.WriteLine("3.Ordenar los numeros por fila de manera creciente.");
            Console.WriteLine("4.Ordenar los numeros por columna de manera creciente.");
            Console.WriteLine("5.Permutar los digitos de un numero de 2 o mas digitos.");
            Console.WriteLine("Elige una opcion: ");
        }
        static string reverse(string test){
            char[] charArray = test.ToCharArray();
            string reverse = String.Empty;
            for (int i = charArray.Length - 1; i >= 0; i--)
            {
                reverse += charArray[i];
            }
            return reverse;
        }
        static void GenR(int [,] matrix){
            Random rd = new Random();
            for (int j = 0; j < matrix.GetLength(0); j++){
                for (int i = 0; i < matrix.GetLength(1); i++){
                    matrix[i,j] = rd.Next(1,99);
                }
            }
        }
        static void PrinR(int [,] matrix){
            for (int j = 0; j < matrix.GetLength(0); j++){
                for (int i = 0; i < matrix.GetLength(1); i++){
                   Console.Write("{0} ",matrix[i,j]);
                }Console.WriteLine("");
            }
        }
        static void CrecF(int [,] matrix){
            for (int k = 0; k < 8; k++){
                for (int f = 0; f < 8; f++){
                    for (int a = 0; a < k; a++){
                        if (matrix[k,f] > matrix[a + 1,f]){
                            int aux;
                            aux = matrix[k,f];
                            matrix[k,f] = matrix[a + 1,f];
                            matrix[a + 1,f] = aux;
                        }
                    }
                }
            }
        }
        static void CrecC(int [,] matrix){
            for (int k = 0; k < 8; k++){
                for (int f = 0; f < 8; f++){
                    for (int b = 0; b < f; b++){
                        if (matrix[k,f] > matrix[k,b]){
                            int aux;
                            aux = matrix[k,f];
                            matrix[k,f] = matrix[k,b];
                            matrix[k,b] = aux;
                        }
                    }
                }
            }
        }
        static void PermD(int [,] matrix){
            for (int i=0;i<matrix.GetLength(0);i++){
                for (int j=0;j<matrix.GetLength(1);j++){
                    int cell = matrix[i,j];
                    string cel = "" + cell;
                    int num = Int32.Parse(reverse(cel));
                    matrix[i,j] = num;
                }
            }
        }
        static void Main(string[] args){
           int [,] v = new int[8,8];
           bool salir = false;
            while(!salir){
                Menu();
                int op = Int32.Parse(Console.ReadLine());
                switch (op){
                    case 0: salir = true;
                        break;
                    case 1: GenR(v);
                        continue;
                    case 2: PrinR(v);
                        continue;
                    case 3: CrecF(v);
                        break;
                    case 4: CrecC(v);
                        break;
                    case 5: PermD(v);
                        break;
                    default: Console.WriteLine("Noob printa una opcion correcta.");
                        break;
                }
            }
        }
    }
}