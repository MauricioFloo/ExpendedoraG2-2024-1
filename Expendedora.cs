using System;
using System.Threading;

namespace ExpendedoraG2_2024_1
{
    internal class Expendedora
    {
        #region Atributos
        
        private string marca;
        private ushort cantproductos;
        private float precio;

        #endregion

        #region Métodos

        private void Saludar()
        {
            Console.WriteLine(" Bienvenido, elige un producto ");
        }
        
        private void LimpiarDisplay()
        {
            Thread.Sleep(2000);
            Console.Clear();
        }

        public string MostrarProducto()
        {
            string codigo = "";
            Console.WriteLine(" 3A: Doritos \n 3B: Churrumais ");
            Console.WriteLine("Ingresa el código del producto ");
            codigo = Console.ReadLine();
            return codigo;
        }

        public void MostrarPrecio(string codigo)
        {
            switch(codigo)
            {
                case "3A":
                    Console.WriteLine("Precio: ${0}", precio);
                    break;
                case "3B":
                    Console.WriteLine("Precio: ${0}", precio - 6);
                    break;
                default:
                    Console.WriteLine("No ingresaste un prodcuto válido");
                    break;
            }
        }

        #endregion

        #region Constrcutor

        public Expendedora()
        {
            marca = "AMS";
            precio = 18;
            Saludar();
            LimpiarDisplay();
            Console.WriteLine("Marca: {0}", marca);
            LimpiarDisplay();
            string codigo = MostrarProducto();
            MostrarPrecio(codigo);
        }

        public Expendedora(bool Mantenimiento)
        {
            if (Mantenimiento == true)
             Console.WriteLine("Entrar en modo mantenimiento");
        }


        #endregion
    }

}
