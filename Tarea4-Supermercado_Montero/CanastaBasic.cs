using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea4_Supermercado_Montero
{
    public class CanastaBasic: IItems
    {
        //Atributos
        private string Nombre;
        private double Precio;
        private int cant;
        private double importe;

        //Constructor
        public CanastaBasic() { }

        public void CreateItems()
        {
            Console.WriteLine("******* CREACION DE ARTICULO ********\n");
            Console.WriteLine("=> Nombre del articulo: ");
            Nombre = Console.ReadLine();//Aqui se digita el nombre del articulo a crear
            Console.WriteLine("\n=> Precio del articulo: ");
            cant = int.Parse(Console.ReadLine());//Precio del articulo...

        }

        public void Cobrar()
        {
            var fecha = DateTime.Now;//Fecha del sistema...
            Random aleatorio = new Random();
            int NumFact = aleatorio.Next(1000, 10000);
            Console.WriteLine("******* SISTEMA DE FACTURACION *********\n");
            Console.WriteLine($" No. Factura: C-{NumFact}     Fecha: {fecha.ToString("d")}  Hora: {fecha.ToString("t")}\n"+
                $" Articulo            Cantidad           Importe\n"+
                $" {Nombre}             {cant}           {Importe()}");

        }

        private double Importe()
        {
            importe = cant * Precio;//Calcula el valor del importe
            return importe;//retorno del valor total
        }
    }
}
