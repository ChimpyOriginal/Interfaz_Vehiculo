using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz_Vehiculo
{
    public class Automovil : Vehiculo
    {
        public Automovil()
        {
            Nombre = "Automóvil";
        }

        public override void Acelerar()
        {
            velocidad += 15;
            Console.WriteLine(AcelerarInfo());
        }

        public override void Desacelerar()
        {
            velocidad -= 10;
            if (velocidad < 0) velocidad = 0;
            Console.WriteLine(DesacelerarInfo());
        }
    }
}
