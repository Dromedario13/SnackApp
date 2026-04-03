using SnackApp.Interfaces;
using SnackApp.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISnackService servicio = new SnackService();
            int opcion;

            do
            {
                Console.WriteLine("\n***** MÁQUINA DE SNACKS *****");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("1. Agregar snack");
                Console.WriteLine("2. Listar snacks");
                Console.WriteLine("3. Comprar snack");
                Console.WriteLine("4. Actualizar snack");
                Console.WriteLine("5. Eliminar snack");
                Console.WriteLine("0. Salir");
                Console.WriteLine("-----------------------------");
                Console.Write("Seleccione una opción: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("--- Agregar snack ---");
                        Console.Write("Nombre: ");
                        string nombre = Console.ReadLine();

                        Console.Write("Precio: ");
                        double precio = double.Parse(Console.ReadLine());

                        Console.Write("Cantidad: ");
                        int cantidad = int.Parse(Console.ReadLine());

                        servicio.AgregarSnack(nombre, precio, cantidad);
                        break;

                    case 2:
                        Console.WriteLine("--- Lista de Snacks ---");
                        servicio.ListarSnacks();
                        break;

                    case 3:
                        Console.WriteLine("--- Comprar Snacks ---");
                        Console.Write("ID del snack: ");
                        int idCompra = int.Parse(Console.ReadLine());

                        servicio.ComprarSnack(idCompra);
                        break;

                    case 4:
                        // Permite actualizar la información de un snack existente
                        Console.WriteLine("--- Actualizar Snacks ---");
                        Console.Write("ID del snack: ");
                        int idActualizar = int.Parse(Console.ReadLine());

                        Console.Write("Nuevo nombre: ");
                        string nuevoNombre = Console.ReadLine();

                        Console.Write("Nuevo precio: ");
                        double nuevoPrecio = double.Parse(Console.ReadLine());

                        Console.Write("Nueva cantidad: ");
                        int nuevaCantidad = int.Parse(Console.ReadLine());

                        servicio.ActualizarSnack(idActualizar, nuevoNombre, nuevoPrecio, nuevaCantidad);
                        break;

                    case 5:
                        Console.WriteLine("--- Eliminar Snack ---");
                        Console.Write("ID del snack: ");
                        int idEliminar = int.Parse(Console.ReadLine());

                        servicio.EliminarSnack(idEliminar);
                        break;

                    case 0:
                        Console.WriteLine("Saliendo...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

            } while (opcion != 0);
        }
    }
}
    

