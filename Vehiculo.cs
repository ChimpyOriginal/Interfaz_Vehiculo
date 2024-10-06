using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz_Vehiculo
{
    public abstract class Vehiculo : IVehiculo
    {
        public string Nombre { get; set; }
        protected int velocidad;

        public abstract void Acelerar();
        public abstract void Desacelerar();
        public void Frenar()
        {
            velocidad = 0;
        }

        public int ObtenerVelocidad()
        {
            return velocidad;
        }

        public string AcelerarInfo()
        {
            return $"¡{Nombre} ha acelerado! Su velocidad ahora es de {ObtenerVelocidad()} km/h. ¡Cuidado!";
        }

        public string DesacelerarInfo()
        {
            return $"El conductor vió un tránsito y tuvo que bajar la velocidad, ahora su {Nombre} va a {ObtenerVelocidad()} km/h :(";
        }
        public string FrenarInfo()
        {
            return $"¡Te detuviste por completo! Obviamente ahora tu {Nombre} va a 0 km/h.";
        }

        public string ObtenerVelocidadInfo()
        {
            return $"¡{Nombre} va a la sorprendente velocidad de {ObtenerVelocidad()} km/h!";
        }
    }
}
