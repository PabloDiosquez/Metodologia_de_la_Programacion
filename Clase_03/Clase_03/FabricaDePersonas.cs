﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_03
{
    internal class FabricaDePersonas : FabricaDeComparables
    {
        public override Comparable crearProducto()
        {
            return new Persona();
        }
    }
}