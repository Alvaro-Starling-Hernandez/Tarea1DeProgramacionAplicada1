using System;

namespace Tarea_1
{
    public class Capitulo3
    {
        private string valor = "";

        public void Par_o_Impar(){
            int numero = 0;

            Console.WriteLine("Hacer un programa que le pida al usuario un número y la computadora responda si es par o impar.\n");
            Console.Write("Digite el numero para saber si es par o impar: ");
            valor = Console.ReadLine();
            numero = Convert.ToInt32(valor);

            if(numero % 2 == 0){
                Console.WriteLine("El nuemro {0} es par!", numero);
            }else{
                Console.WriteLine("El numero {0} es impar!", numero);
            }
        }

        public void ImprimirDiasSemana(){
            byte dia = 0;
            
            Console.WriteLine("Hacer un programa que le pida al usuario un número del 1 al 7 y escriba el nombre del día que corresponde ese número en la semana.\n");
            Console.Write("Digite el numero del dia de la semana que sea saber el nombre: ");
            valor = Console.ReadLine();
            dia = Convert.ToByte(valor);

            switch(dia){
                case 1:
                    Console.WriteLine("Domingo");
                    break;
                case 2:
                    Console.WriteLine("Lunes");
                    break;
                case 3:
                    Console.WriteLine("Martes");
                    break;
                case 4:
                    Console.WriteLine("Miercoles");
                    break;
                case 5:
                    Console.WriteLine("Jueves");
                    break;
                case 6:
                    Console.WriteLine("Viernes");
                    break;
                case 7:
                    Console.WriteLine("Sabado");
                    break;
                default:
                    Console.WriteLine("No existe dia {0} de la semana!", dia);
                    break;
            }
        }

        public void MenuCap3(){
            byte opcion = 0;
            string valor = "";
            do{
                Console.Clear();
                Console.WriteLine("Menu de ejercicios del Capitulo 3\n");
                Console.WriteLine("1. Ejercicio 1");
                Console.WriteLine("2. Ejercicio 2");
                Console.WriteLine("3. Volver atras\n");
                Console.Write("Digite el numero del ejercicio que sea ver: ");
                valor = Console.ReadLine();
                opcion = Convert.ToByte(valor);

                switch(opcion){
                    case 1:
                        Console.Clear();
                        Par_o_Impar();
                        break;
                    case 2:
                        Console.Clear();
                        ImprimirDiasSemana();
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