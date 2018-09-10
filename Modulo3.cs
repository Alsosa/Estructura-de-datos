using System;

namespace Modulo3
{
    class Modulo3
    {
        static void Main(string[] args)
        {
            /*Tarea 1: Crea un programa que pida al usuario su identificador y su contraseña (ambos
            numéricos), y no le permita seguir hasta que introduzca como identificador "1234" y como
            contraseña "1111".*/
            Console.WriteLine("Tarea 1");
            string identificador, contrasenia;
            do
            {
                Console.WriteLine("Ingrese identificador: ");
                identificador = Console.ReadLine();
                Console.WriteLine("Ingrese contraseña: ");
                contrasenia = Console.ReadLine();
            } while (identificador != "1234" && contrasenia != "1111");

            Console.WriteLine("Datos correctos");

            /*Tarea 2: Crea un programa calcule cuantas cifras tiene un número entero positivo (pista: se
            puede hacer dividiendo varias veces entre 10).*/
            Console.WriteLine("Tarea 2");
            int num, dig = 0;
            Console.Write("Ingrese un número positivo: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num <= 0)
            {
                Console.WriteLine("ERROR!Ingerse otro número nuevamente: ");
            }

            else
            {
                do
                {
                    num = num / 10;
                    dig = dig + 1;
                }
                while (num > 0);
                Console.WriteLine("El número tiene " + dig + " dígitos..");
                Console.ReadKey();
            }

            //Tarea 3: Crea un programa que muestre la tabla de multipicar del 9.
            Console.WriteLine("Tarea 3");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", i, 9, i * 9);
            }

            /*Tarea 4: Crea un programa que contenga un bucle sin fin que muestre los números enteros
            positivos a partir del uno.*/
            Console.WriteLine("Tarea 4");
            for(int i = 1; i != 0; i++)
            {
                Console.WriteLine(i);
            }

            /*Tarea 5: Crea un programa que contenga un bucle sin fin que escriba "Hola " en pantalla, sin
            avanzar de línea.*/
            Console.WriteLine("Tarea 5");
            for (int i = 1; i != 0; i++)
            {
                Console.Write("Hola");
            }

            /*Tarea 6: ¿Cuál sería el resultado de las siguientes operaciones? a = 5; b = ++a; c = a++; b = b * 5;
            a = a * 2; Crea un programa que lo resuelva.*/
            Console.WriteLine("Tarea 6");
            int a = 5;
            int b = ++a;
            int c = a++;
            b *= 5;
            a *= 2;

            Console.WriteLine("a = {0} /n b = {1} /n c = {2}", a, b, c);

            //Tarea 8: Crea un programa que pida una letra al usuario y diga si se trata de una vocal.
            Console.WriteLine("Tarea 8");
            Console.WriteLine("Ingrese una letra: ");
            string letra = Console.ReadLine();

            if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
            {
                Console.WriteLine("La letra ingresada es una vocal");
            }
            else
            {
                Console.WriteLine("La letra ingresada no es una vocal");
            }

            /*Tarea 9: Crear un programa que pida al usuario un nombre y una contraseña. La contraseña se
            debe introducir dos veces. Si las dos contraseñas no son iguales, se avisará al usuario y se le
            volverán a pedir las dos contraseñas. */
            Console.WriteLine("Tarea 9");
            string passwd, nombre, pass2;

            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            do
            {
                Console.Write("Ingrese su contraseña: ");
                passwd = Console.ReadLine();

                Console.Write("Ingrese su contraseña nuevamente: ");
                pass2 = Console.ReadLine();

                if (passwd != pass2)
                {
                    Console.WriteLine("Las contraseñas no coinciden, intentelo nuevamente.");
                }
                else
                {
                    Console.WriteLine("Contraseña correcta, bienvenido.");
                }
            } while (passwd != pass2);

            /*Tarea 10: Crear un programa que pida al usuario su nombre, y le diga "Hola" si se llama "Martín", 
             * o bien le diga "No te conozco" si teclea otro nombre. */
            Console.WriteLine("Tarea 10");
            Console.WriteLine("Ingrese su nombre: ");
            string nom = Console.ReadLine();

            if (nom != "Martin")
            {
                Console.WriteLine("No te conozco");
            }
            else
            {
                Console.WriteLine("Hola");
            }

            Console.ReadKey();
        }
    }
}
