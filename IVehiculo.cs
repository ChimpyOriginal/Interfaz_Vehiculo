using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz_Vehiculo
{
    public interface IVehiculo
    {
        string Nombre { get; set; }
        void Acelerar();
        void Desacelerar();
        void Frenar();
        int ObtenerVelocidad(); 
    }

}
