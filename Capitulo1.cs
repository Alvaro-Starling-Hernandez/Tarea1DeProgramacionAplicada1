using System;

namespace Tarea_1
{
    public class Capitulo1
    {
        public void ImprimirNombre(){
            Console.WriteLine("\nAlvaro Starling Hernandez Luzon");
        }

        public void MasMensajes(){
            Console.WriteLine("Agregue más mensajes a la aplicación que ha creado.\n");
            ImprimirNombre();
            Console.WriteLine("Edad: 20");
            Console.WriteLine("Estatura: 6,1");
            Console.WriteLine("Direccion: Joboban, Villa Riva");
            Console.WriteLine("Provincia: Duarte");
            Console.WriteLine("Pais: Republica Dominicana\n");
        }

        public void MenuCap1(){
            byte opcion = 0;
            string valor = "";
            do{
                Console.Clear();
                Console.WriteLine("Menu de ejercicios del Capitulo 1\n");
                Console.WriteLine("1. Ejercicio 1");
                Console.WriteLine("2. Ejercicio 2");
                Console.WriteLine("3. Volver atras\n");
                Console.Write("Digite el numero del ejercicio que sea ver: ");
                valor = Console.ReadLine();
                opcion = Convert.ToByte(valor);

                switch(opcion){
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Cree un proyecto nuevo que imprima su nombre en la ventana de la consola.\n");
                        ImprimirNombre();
                        break;
                    case 2:
                        Console.Clear();
                        MasMensajes();
                        break;
                    case 3:
                        return;
                        break;
                    default:
                        Console.WriteLine("\n\nOpcion incorrecta!");
                        break;
                }
                Console.Write("\n\n\nPresione enter para regresar...");
                Console.ReadLine();
            }while(opcion <=0 && opcion >= 4 || opcion != 3);
        }
    }
}

