using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz_Vehiculo
{
    public class Bicicleta:Vehiculo
    {
        public Bicicleta()
        {
            Nombre = "Bicicleta";
        }

        public override void Acelerar()
        {
            velocidad += 2;
            Console.WriteLine(AcelerarInfo());
        }

        public override void Desacelerar()
        {
            velocidad -= 1;

            if (velocidad < 0)
            {
                velocidad = 0;
            }
            Console.WriteLine(DesacelerarInfo());
        }
    }
}

