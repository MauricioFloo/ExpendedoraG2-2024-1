﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExpendedoraG2_2024_1
{
    internal class Snack : Expendedora
    {
        public Snack()
        {
            Saludar();
            Console.WriteLine("Marca: {0}", Marca);
            LimpiarDisplay();
            string codigo = MostrarProducto();
            MostrarPrecio(codigo);
        }
    }
}
