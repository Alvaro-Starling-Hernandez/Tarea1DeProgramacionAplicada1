using System;

namespace Tarea_1
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Capitulo1 c1 = new Capitulo1();
            Capitulo2 c2 = new Capitulo2();
            Capitulo3 c3 = new Capitulo3();

            byte opcion = 0;
            string valor = "";

            do{
                Console.Clear();
                Console.WriteLine("Menu de los Capitulos de la Tarea 1\n");
                Console.WriteLine("1. Capitulo 1");
                Console.WriteLine("2. Capitulo 2");
                Console.WriteLine("3. Capitulo 3");
                Console.WriteLine("4. Salir\n");
                Console.Write("Digite el numero del Capitulo que sea ver: ");
                valor = Console.ReadLine();
                opcion = Convert.ToByte(valor);

                switch(opcion){
                    case 1:
                        Console.Clear();
                        c1.MenuCap1();
                        break;
                    case 2:
                        Console.Clear();
                        c2.MenuCap2();
                        break;
                    case 3:
                        Console.Clear();
                        c3.MenuCap3();
                        break;
                    case 4:
                        return;
                        break;
                    default:
                        Console.WriteLine("\n\nOpcion incorrecta!");
                        break;
                }
                Console.Write("\n\n\nPresione enter para regresar...");
                Console.ReadLine();
            }while(opcion <=0 && opcion >= 5 || opcion != 4);
        }
    }
}
