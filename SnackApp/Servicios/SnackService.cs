using SnackApp.Interfaces;
using SnackApp.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackApp.Servicios
{
    public class SnackService : ISnackService
    {
        private List<Snack> snacks = new List<Snack>();
        private int contador = 1;

        // Permite agregar un nuevo snack
        public void AgregarSnack(string nombre, double precio, int cantidad)
        {
            snacks.Add(new Snack
            {
                Id = contador++,
                Nombre = nombre,
                Precio = precio,
                Cantidad = cantidad
            });

            Console.WriteLine("Snack agregado correctamente.");
        }

        // Muestra todos los snacks disponibles
        public void ListarSnacks()
        {
            if (snacks.Count == 0)
            {
                Console.WriteLine("No hay snacks disponibles.");
                return;
            }

            foreach (var snack in snacks)
            {
                Console.WriteLine($"ID: {snack.Id} | {snack.Nombre} | Precio: {snack.Precio} | Cantidad: {snack.Cantidad}");
            }
        }

        // Permite comprar un snack por ID
        public void ComprarSnack(int id)
        {
            var snack = snacks.FirstOrDefault(s => s.Id == id);

            if (snack != null && snack.Cantidad > 0)
            {
                snack.Cantidad--;
                Console.WriteLine($"Compraste: {snack.Nombre}");
            }
            else
            {
                Console.WriteLine("Snack no disponible.");
            }
        }

        // Permite actualizar un snack
        public void ActualizarSnack(int id, string nombre, double precio, int cantidad)
        {
            var snack = snacks.FirstOrDefault(s => s.Id == id);

            if (snack != null)
            {
                snack.Nombre = nombre;
                snack.Precio = precio;
                snack.Cantidad = cantidad;

                Console.WriteLine("Snack actualizado correctamente.");
            }
            else
            {
                Console.WriteLine("Snack no encontrado.");
            }
        }

        // Permite eliminar un snack
        public void EliminarSnack(int id)
        {
            var snack = snacks.FirstOrDefault(s => s.Id == id);

            if (snack != null)
            {
                snacks.Remove(snack);
                Console.WriteLine("Snack eliminado correctamente.");
            }
            else
            {
                Console.WriteLine("Snack no encontrado.");
            }
        }
    }
}
