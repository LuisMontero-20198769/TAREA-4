using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea4_Supermercado_Montero
{
    public class Menu
    {
        Facade fachada = new Facade(); //Obejeto del tipo de la clase facade
        
        public void Presentacion()
        {
            int opcion; //variable declarada
            do
            {
                Console.Clear();//Limpiar la pantalla...
                Console.ForegroundColor = ConsoleColor.Yellow;
                //Menu principal de la Empresa 
                Console.WriteLine("********************************");
                Console.WriteLine("*                              *");
                Console.WriteLine("*          TIENDA MONTERO      *");
                Console.WriteLine("*                              *");
                Console.WriteLine("********************************\n");
                Console.WriteLine("*****      SERVICIOS AL CLIENTE    ***** \n");
                Console.WriteLine("           Menu Principal:\n");
                Console.WriteLine(" (1) Canasta Basica.");
                Console.WriteLine(" (2) Articulos de Vestir.");
                Console.WriteLine(" (3) Articulos Tecnologicos.");
                Console.WriteLine(" (5) Salir.\n");
                Console.WriteLine("=> Eliga la opcion deseada: ");
                Console.ResetColor();

                opcion = int.Parse(Console.ReadLine());//Aqui se lee el valor de la variable
                switch (opcion)
                {
                    case 1:
                        fachada.UsarCanasta();//Llamada del metodo 
                        break;
                    case 5:
                        Console.Clear();//limpiador de pantalla....
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n Se ha cerrado la sesion!!!");
                        Console.WriteLine("\n Press 'ENTER' para cerrar ventana....");
                        Console.ResetColor();
                        Environment.Exit(0);//Metodo que cierra el programa.
                        break;
                }
               

            } while (opcion != 0); //Condicion para finalizar el ciclo do-while (hacer-mientras)

        }
    }
}
