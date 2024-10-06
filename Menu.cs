using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz_Vehiculo
{
    internal class Menu
    {
        private List<Opcion> menuPrincipal; 
        private List<Opcion> menuVehiculo;  
        private IVehiculo vehiculo = null;

        public Menu()
        {
            
            menuPrincipal = new List<Opcion>()
            {
                new Opcion("Automóvil", () => { vehiculo = new Automovil(); MostrarSubMenu(); }),
                new Opcion("Bicicleta", () => { vehiculo = new Bicicleta(); MostrarSubMenu(); }),
                new Opcion("Motocicleta", () => { vehiculo = new Motocicleta(); MostrarSubMenu(); }),
                new Opcion("Salir", () => Environment.Exit(0))
            };

            menuVehiculo = new List<Opcion>()
        {
            new Opcion("Acelerar", () => vehiculo.Acelerar()),
            new Opcion("Desacelerar", () => vehiculo.Desacelerar()),
            new Opcion("Frenar", () => { vehiculo.Frenar();Console.WriteLine(((Vehiculo)vehiculo).FrenarInfo()); }),
            new Opcion("Obtener Velocidad", () => { Console.WriteLine(((Vehiculo)vehiculo).ObtenerVelocidadInfo()); }),
            new Opcion("Regresar al menú principal", () => MostrarMenuPrincipal())
        };

            MostrarMenuPrincipal();
        }

        public void MostrarMenu(List<Opcion> opciones)
        {
            for (int i = 0; i < opciones.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + opciones[i].Message);
            }
        }

        public void ElegirOpcion(List<Opcion> opciones)
        {
            Console.Write("\nElige una opción: ");
            int numOpcion = Convert.ToInt32(Console.ReadLine()) - 1;

            if (numOpcion >= 0 && numOpcion < opciones.Count)
            {
                Console.Clear();
                opciones[numOpcion].Action.Invoke();
            }
            else
            {
                Console.WriteLine("\nOpción no válida. Por favor, elige una opción válida.");
            }

            Continuar();
        }

        private void MostrarSubMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("¿Qué deseas hacer con tu vehículo?");
                MostrarMenu(menuVehiculo); 
                ElegirOpcion(menuVehiculo); 
            }
        }

        private void MostrarMenuPrincipal()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("LISTA DE VEHÍCULOS:");
                MostrarMenu(menuPrincipal);
                ElegirOpcion(menuPrincipal);
            }
        }

        private static void Continuar()
        {
            Console.WriteLine("\nPresiona cualquier tecla para continuar...");
            Console.ReadKey(); 
            Console.Clear(); 
        }
    }
}
