using System;

namespace Modulo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tarea 2: Crea un programa que muestre el resultado de sumar 200 y 56.
            Console.WriteLine("Tarea 2");
            Console.WriteLine(200 + 56);

            //Tarea 3: Haz un programa que calcule el producto entre 13 y 12.
            Console.WriteLine("Tarea 3");
            Console.WriteLine(13 * 12);

            //Tarea 4: Hacer un programa que calcule la diferencia entre 312 y 213.
            Console.WriteLine("Tarea 4");
            Console.WriteLine(312 - 213);

            //Tarea 5: Calcular el resultado de (20 + 5) % 6.
            Console.WriteLine("Tarea 5");
            Console.WriteLine((20 + 5) % 6);

            //Tarea 6: Crea un programa que calcule el producto entre 12 y 102, usando variables.
            Console.WriteLine("Tarea 6");
            int num1 = 12;
            int num2 = 102;
            Console.WriteLine(num1 * num2);

            //Tarea 7: Crea un programa que calcule la suma entre 200 y 1111, utilizando variables.
            Console.WriteLine("Tarea 7");
            int num01 = 200;
            int num02 = 1111;
            Console.WriteLine(num01 + num02);

            //Tarea 8: Calcular producto 10 y 25, usar variables 'numero1' y 'numero2'.
            Console.WriteLine("Tarea 8");
            int numero1 = 10;
            int numero2 = 25;
            Console.WriteLine(numero1 * numero2);

            //Tarea 9: Crea un programa que calcule el producto de dos números ingresados por el usuario.
            Console.WriteLine("Tarea 9");
            int num3 = Convert.ToInt32(Console.ReadLine());
            int num4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num3 * num4);

            //Tarea 10: Crear programa que le pida al usuario ingresar un numero entero y diga si es par o impar.
            Console.WriteLine("Tarea 10");
            int num5 = Convert.ToInt32(Console.ReadLine());
            if (num5 % 2 == 0)
            {
                Console.WriteLine("El numero ingresado es par");
            }
            else
            {
                Console.WriteLine("El numero ingresado es impar");
            }

            //Tarea 11: Crea un programa que pida al usuario dos numeros enteros y diga cual es mayor.
            Console.WriteLine("Tarea 11");
            int num6 = Convert.ToInt32(Console.ReadLine());
            int num7 = Convert.ToInt32(Console.ReadLine());

            if (num6 > num7)
            {
                Console.WriteLine("El numero mayor es {0}", num6);
            }
            else if (num6 < num7)
            {
                Console.WriteLine("El numero menor es {0}", num6);
            }

            /*Tarea 12: Crea un programa que pida al usuario dos números enteros. Si el segundo
            no es cero, mostrará el resultado de dividir entre el primero y el segundo. Por el
            contrario, si el segundo número es cero, escribirá "Error: No se puede dividir entre
            cero".*/
            Console.WriteLine("Tarea 12");
            int num8 = Convert.ToInt32(Console.ReadLine());
            int num9 = Convert.ToInt32(Console.ReadLine());

            if (num9 != 0)
            {
                Console.WriteLine(num8 / num9);
            }
            else if (num9 == 0)
            {
                Console.WriteLine("Error, no se puede dividir por cero");
            }

            /*Tarea 13: Crea un programa que pida un número del 1 al 5 al usuario, y escriba el
            nombre de ese número, usando "switch"(por ejemplo, si introduce "1", el programa
            escribirá "uno").*/
            Console.WriteLine("Tarea 13");
            Console.WriteLine("Inserte numero del 1 al 5");
            int num10 = Convert.ToInt32(Console.ReadLine());
            switch(num10)
            {
                case 1:
                    Console.WriteLine("uno");
                    break;
                case 2:
                    Console.WriteLine("dos");
                    break;
                case 3:
                    Console.WriteLine("tres");
                    break;
                case 4:
                    Console.WriteLine("cuatro");
                    break;
                case 5:
                    Console.WriteLine("cinco");
                    break;
                default:
                    Console.WriteLine("El numero ingresado no se encuentra entre 1 y 5");
                    break;
            }

            //Tarea 14: Crea un programa que muestre en pantalla los numeros del 1 al 10 usando "while".
            Console.WriteLine("Tarea 14");
            int cont = 1;
            while (cont <= 10)
            {
                Console.WriteLine(cont);
                cont++;
            }

            //Tarea 15: Crea un programa que muestre en pantalla los numeros del 1 al 10 usando "do..while".
            Console.WriteLine("Tarea 15");
            int cont1 = 1;
            do
            {
                Console.WriteLine(cont1);
                cont1++;
            } while (cont1 <= 10);

            //Tarea 16: Crea un programa que muestre en pantalla los numeros del 10 al 20, ambos incluidos, usando "for".
            Console.WriteLine("Tarea 16");
            for (int i = 10; i <= 20; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}
