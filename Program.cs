using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IbañezMarinBrandonRodrigo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista miLista = new Lista();
            int opcion = 0;

            do
            {
                Console.WriteLine("Menú:");
                Console.WriteLine("1.- Insertar");
                Console.WriteLine("2.- Insertar al inicio");
                Console.WriteLine("3.- Insertar al final");
                Console.WriteLine("4.- Mostrar");
                Console.WriteLine("5.- Eliminar");
                Console.WriteLine("6.- Encontrar nodo medio");
                Console.WriteLine("7.- Invertir lista");
                Console.WriteLine("8.- Salir");
                Console.Write("Seleccione una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese la cantidad de números a insertar: ");
                        int cantidad = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < cantidad; i++)
                        {
                            Console.Write($"Ingrese el valor {i + 1}: ");
                            int valorInsertar = Convert.ToInt32(Console.ReadLine());
                            miLista.insertarF(valorInsertar);
                        }
                        break;

                    case 2:
                        Console.Write("Ingrese el valor a insertar al inicio: ");
                        int valorInicio = Convert.ToInt32(Console.ReadLine());
                        miLista.InsertarAlInicio(valorInicio);
                        break;

                    case 3:
                        Console.Write("Ingrese el valor a insertar al final: ");
                        int valorFinal = Convert.ToInt32(Console.ReadLine());
                        miLista.InsertarAlFinal(valorFinal);
                        break;

                    case 4:
                        miLista.Mostrar();
                        break;

                    case 5:
                        Console.Write("Ingrese el valor a eliminar: ");
                        int valorEliminar = Convert.ToInt32(Console.ReadLine());
                        miLista.EliminarNodo(valorEliminar);
                        break;

                    case 6:
                        Nodo nodoMedio = miLista.EncontrarNodoMedio();
                        if (nodoMedio != null)
                        {
                            Console.WriteLine($"El nodo medio tiene el valor: {nodoMedio.dato}");
                        }
                        else
                        {
                            Console.WriteLine("La lista está vacía.");
                        }
                        break;

                    case 7:
                        miLista.InvertirLista();
                        Console.WriteLine("La lista ha sido invertida.");
                        break;

                    case 8:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }

                Console.WriteLine();

            } while (opcion != 8);
        }
    }

}
