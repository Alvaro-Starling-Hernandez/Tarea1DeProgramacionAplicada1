using System;

namespace Tarea_1
{
    public class Capitulo2
    {
        private string valor = "";

        public void CalcularPerimetro(){
            float medidaDelLado = 0.0f;
            float cantidaDeLados = 0.0f;
            float perimetro = 0.0f;

            Console.WriteLine("Hacer un programa que calcule el perímetro de cualquier polígono regular.\n");

            Console.Write("Digite la medida de uno de los lados del poligono: ");
            valor = Console.ReadLine();
            medidaDelLado = Convert.ToSingle(valor);

            Console.Write("Digite la cantidad de lados del poligono: ");
            valor = Console.ReadLine();
            cantidaDeLados =  Convert.ToSingle(valor);

            perimetro = medidaDelLado*cantidaDeLados;

            Console.WriteLine("El perimetro es igual a: {0}\n", perimetro);
        }

        public void TransformarGradosRadianes(){
            float grados = 0.0f;
            float radianes = 0.0f;

            Console.WriteLine("Hacer un programa que transforme de grados a radianes.\n");

            Console.Write("Digite la cantida de grados a convertir: ");
            valor = Console.ReadLine();
            grados = Convert.ToSingle(valor);

            radianes = grados/57.2957795f;

            Console.WriteLine("Resultado: {0} grados es igual a {1} radianes\n",grados,radianes);

        }

        public void TransformarCentigradosfahrenheit(){
            float centigrados = 0.0f;
            float fahrenheit = 0.0f;

            Console.WriteLine("Hacer un programa que transforme de grados centígrados a grados Fahrenheit.\n");

            Console.Write("Digite la cantida de grados centigrados a convertir: ");
            valor = Console.ReadLine();
            centigrados = Convert.ToSingle(valor);

            fahrenheit = (centigrados*1.8f)+32;

            Console.WriteLine("Resultado: {0} grados centigrados es igual a {1} fahrenheit\n",centigrados,fahrenheit);
        }

        public void TransformarDolaresEuros(){
            float cantidadDolares = 0.0f;
            float precioDolar = 0.0f;
            float cantidadEuros = 0.0f;
            float precioEuro = 0.0f;
            float resultado = 0.0f;

            Console.WriteLine("Hacer un programa que transforme entre dólares y euros y que también pida el tipo de cambio del día.\n");

            Console.WriteLine("\nConvertir de dolares a euros");
            Console.Write("Digite la cantidad de dolares a convertir: ");
            valor = Console.ReadLine();
            cantidadDolares = Convert.ToSingle(valor);

            Console.Write("Digite el precio del euro en dolares: ");
            valor = Console.ReadLine();
            precioEuro =  Convert.ToSingle(valor);

            resultado = cantidadDolares*precioEuro;

            Console.WriteLine("{0} dolales es igual a {1} euros\n\n",cantidadDolares,resultado);
            
            Console.WriteLine("\nConvertir de euros a dolares");
            Console.Write("Digite la cantidad de euros a convertir: ");
            valor = Console.ReadLine();
            cantidadEuros = Convert.ToSingle(valor);

            Console.Write("Digite el precio del euro en dolares: ");
            valor = Console.ReadLine();
            precioDolar =  Convert.ToSingle(valor);

            resultado = cantidadEuros*precioDolar;

            Console.WriteLine("{0} euros es igual a {1} dolares\n",cantidadEuros,resultado);

        }

        public void MenuCap2(){
            byte opcion = 0;
            string valor = "";
            do{
                Console.Clear();
                Console.WriteLine("Menu de ejercicios del Capitulo 2\n");
                Console.WriteLine("1. Ejercicio 1");
                Console.WriteLine("2. Ejercicio 2");
                Console.WriteLine("3. Ejercicio 3");
                Console.WriteLine("4. Ejercicio 4");
                Console.WriteLine("5. Volver atras\n");
                Console.Write("Digite el numero del ejercicio que sea ver: ");
                valor = Console.ReadLine();
                opcion = Convert.ToByte(valor);

                switch(opcion){
                    case 1:
                        Console.Clear();
                        CalcularPerimetro();
                        break;
                    case 2:
                        Console.Clear();
                        TransformarGradosRadianes();
                        break;
                    case 3:
                        Console.Clear();
                       TransformarCentigradosfahrenheit();
                        break;
                    case 4:
                        Console.Clear();
                        TransformarDolaresEuros();
                        break;
                    case 5:
                        return;
                        break;
                    default:
                        Console.WriteLine("\n\nOpcion incorrecta!");
                        break;
                }
                Console.Write("\n\n\nPresione enter para regresar...");
                Console.ReadLine();
            }while(opcion <=0 && opcion >= 6  || opcion != 5);
        }
    }
}