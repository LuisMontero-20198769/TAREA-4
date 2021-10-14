using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea4_Supermercado_Montero
{
    public class Facade
    {
        //Variables de referencias
        private CanastaBasic canasta;

        public void UsarCanasta()
        {
            int opcion;
            Console.WriteLine("*****              CANASTA BASICA          *******\n");
            Console.WriteLine("[1] Crear Articulo                [2] Cobrar Articulo ");
            Console.WriteLine("=> Elija su opcion: ");
            opcion = int.Parse(Console.ReadLine());//Digita su opcion deseada

            switch (opcion)
            {
                case 1:
                    canasta.CreateItems();//Llamada del metodo crearItems..
                    break;
                case 2:
                    canasta.Cobrar();//Llamada del metodo cobrar..
                    break;
                default:
                    Console.WriteLine("Esta no es una opcion!!");
                    break;
            }
        }
    }
}
