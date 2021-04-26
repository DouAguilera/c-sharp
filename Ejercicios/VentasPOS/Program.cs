using System;

namespace VentasPOS
{
    class Program
    {
        static void Main(string[] args)
        {
           Seguridad s = new Seguridad ();
           
            string usuario = "";
            string contrasena = "";
            Console.Clear();
            Console.WriteLine("                                                                =============================================================");                                             
            Console.WriteLine("                                                                ========== Area de Acceso al Sistema de la Empresa ==========");
            Console.WriteLine("                                                                =============================================================");
            Console.Write("");
            Console.Write("                                                                            Ingrese Usuario:  "                     );
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            usuario = Console.ReadLine();
            Console.Write("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("                                                                            Ingrese Contraseña: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            contrasena = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                                                                =============================================================");
            
                if (s.Autenticador(usuario, contrasena))
                {
                    BasedeDatos Bases = new BasedeDatos();
                    string opcion1 = " ";
                    string opcion2 = " ";
                    string opcion3 = " ";

        
                    while (true)
                    {   
                        Console.ForegroundColor = ConsoleColor.Cyan;
                         Console.Clear();
                        Console.WriteLine("                                                               BIENVENIDO AL SISTEMA DE FACTURACION DE FERRETARIA LA CONFIANZA   ");
                        Console.WriteLine("                                                                    Le saluda Douglas Aguilera, Gerente de la Ferreteria      ");
                        Console.WriteLine("");                      
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("                                                                     Presione cualquier tecla y siga las instrucciones...    ");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("                                                                ||=======================================================||                                             ");
                        Console.WriteLine("                                                                ||                                                       ||                                             ");
                        Console.WriteLine("                                                                ||-----------------FERRETERIA LA CONFIANZA---------------||                                             ");
                        Console.WriteLine("                                                                ||                                                       ||                                             ");
                        Console.WriteLine("                                                                ||                                                       ||                                             ");
                        Console.WriteLine("                                                                ||-----------Sistema de Ventas e Informacion-------------||                                             ");
                        Console.WriteLine("                                                                ||=======================================================||                                             ");
                        Console.WriteLine("                                                                ||                                                       ||                                             ");
                        Console.WriteLine("                                                                ||               ¿Qué opcion desea ingresar?             ||                                             ");
                        Console.WriteLine("                                                                ||                                                       ||                                             ");
                        Console.WriteLine("                                                                ||                1 - Facturación                        ||                                             ");
                        Console.WriteLine("                                                                ||                                                       ||                                             ");
                        Console.WriteLine("                                                                ||                                                       ||                                             ");
                        Console.WriteLine("                                                                ||                2 - Lista de Clientes                  ||                                             ");
                        Console.WriteLine("                                                                ||                3 - Lista de Vendedores                ||                                             ");
                        Console.WriteLine("                                                                ||                4 - Control de Inventario              ||                                             ");
                        Console.WriteLine("                                                                ||                                                       ||                                             ");
                        Console.WriteLine("                                                                ||                                                       ||                                             ");
                        Console.WriteLine("                                                                ||                                                       ||                                             ");
                        Console.WriteLine("                                                                ||                                                       ||                                             ");
                        Console.WriteLine("                                                                ||                                                       ||                                             ");
                        Console.WriteLine("                                                                ||                                                       ||                                             ");
                        Console.WriteLine("                                                                ||                                                       ||                                             ");
                        Console.WriteLine("                                                                ||                                                       ||                                             ");
                        Console.WriteLine("                                                                ||                                                       ||                                             ");
                        Console.WriteLine("                                                                ||                0 - Salida del Sistema                 ||                                             ");
                        Console.WriteLine("                                                                ||                                                       ||                                             ");
                        Console.WriteLine("                                                                ||=======================================================||                                             ");
                        opcion1 = Console.ReadLine();
                        Console.Clear();
                        
                        if (opcion1 == "1")
                        {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("                                                                ===============================================================");                                             
                                Console.WriteLine("                                                                ===========Ingrese la opcion a la que desea acceder:===========");
                                Console.WriteLine("                                                                ===============================================================");                                             
                                Console.WriteLine("");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("                                                                    1- Crear una Factura (Venta)");
                                Console.WriteLine("                                                                    2 - Revisar las facturas Existentes");
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                opcion2 = Console.ReadLine(); 
                                Console.Clear();

                                    switch (opcion2)
                                        { 
                                            case "1":
                                                Bases.CrearVenta();
                                                break;
                                            case "2":
                                                Bases.CantidadVentas();
                                                break;
                                            default:
                                                break;
                                        }
                            }
                            else

                        if (opcion1 == "2")
                            {
                                
                                Bases.DatosClientes();
                            }
                        else
                            if (opcion1 == "4")
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("                                                                ===============================================================");                                             
                                Console.WriteLine("                                                                ===========Ingrese la opcion a la que desea acceder:===========");
                                Console.WriteLine("                                                                ===============================================================");                                             
                                Console.WriteLine("");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("                                                                1- Añadir Producto al Inventario");
                                Console.WriteLine("                                                                2 - Eliminar Producto del Inventario");
                                Console.WriteLine("                                                                3 - Revisar Lista de Inventario");
                                opcion3 = Console.ReadLine();
                                Console.Clear();

                            switch (opcion3)
                                {
                                     case "1":
                                        Bases.ingresoDeInventario();
                                        break;
                                    case "2":
                                        Bases.salidaDeInventario();
                                        break;
                                    case "3":
                                        Bases.DatosProductos();
                                    break;
                                default:
                                    break;
                                }
                            }
                        else
                            if (opcion1 == "3")
                            {                           
                                Bases.DatosVendedores();
                            }
                            else 
                                if (opcion1 == "0")
                                { 
                                   
                                    Environment.Exit(0);
                                }
                        }
                }
                       else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("                                                                                    ¡Acceso Denegado!                     ");
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.ReadLine();
                            } 
                        }                    
                    }
                }
            
        
        
    

                               
                
        



