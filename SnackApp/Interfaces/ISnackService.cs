using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackApp.Interfaces
{
    public interface ISnackService
    {
        void AgregarSnack(string nombre, double precio, int cantidad);
        void ListarSnacks();
        void ComprarSnack(int id);
        void ActualizarSnack(int id, string nombre, double precio, int cantidad);
        void EliminarSnack(int id);
    }
}
