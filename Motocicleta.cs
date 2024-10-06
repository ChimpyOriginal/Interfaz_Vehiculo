using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz_Vehiculo
{
    public class Motocicleta : Vehiculo
    {
        public Motocicleta()
        {
            Nombre = "Motocicleta";
        }

        public override void Acelerar()
        {
            velocidad += 20;
            Console.WriteLine(AcelerarInfo());
        }

        public override void Desacelerar()
        {
            velocidad -= 15;
            if (velocidad < 0) velocidad = 0;
            Console.WriteLine(DesacelerarInfo());
        }
    }
}
