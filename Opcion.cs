﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz_Vehiculo
{
    internal class Opcion
    {
        private string message;
        private Action action;

        public Opcion(string message, Action action)
        {
            this.message = message;
            this.action = action;
        }

        public string Message { get { return message; } }
        public Action Action { get { return action; } }
    }
}
