    using System;
    using System.Collections.Generic;
    using System.Threading;

    public class BasedeDatos
    {
        
        public List<Producto> ListadeProductos { get; set; }
        public List<Clientes> ListadeClientes { get; set; }
        public List<Vendedores> ListadeVendedores { get; set; }
        public List<Venta> ListaVentas { get; set; }

        public BasedeDatos()
        {
            ListadeProductos = new List<Producto>();
            datosProductos();

            ListadeClientes = new List<Clientes>();
            datosClientes();

            ListadeVendedores = new List<Vendedores>();
            datosVendedores();

            ListaVentas = new List<Venta>();
        }
        private void datosProductos()
        {
            Producto p1 = new Producto("001", "Clavos", 20, 5);
            Producto p2 = new Producto("002", "Cemento", 20, 100);
            Producto p3 = new Producto("003", "Martillo", 20, 150);
            Producto p4 = new Producto("004", "Tornillos", 20, 10);
            ListadeProductos.Add(p1);
            ListadeProductos.Add(p2);
            ListadeProductos.Add(p3);
            ListadeProductos.Add(p4);
        }
   
        private void datosClientes()
        {
            Clientes c1 = new Clientes(1, "Mario", 1111);
            Clientes c2 = new Clientes(2, "Rosa", 22222);
            Clientes c3 = new Clientes(3, "Pablo", 33333);
            ListadeClientes.Add(c1);
            ListadeClientes.Add(c2);
            ListadeClientes.Add(c3);
        }

        private void datosVendedores()
        {
            Vendedores v1 = new Vendedores(1, "Luis", "V1");
            Vendedores v2 = new Vendedores(2, "Pablo", "V2");
            Vendedores v3 = new Vendedores(3, "Alicia", "V3");
            ListadeVendedores.Add(v1);
            ListadeVendedores.Add(v2);
            ListadeVendedores.Add(v3);
        }

 
        public void DatosProductos()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                                     ===============================================================================================================");
            Console.WriteLine("                                     ===================================== Listado de Productos en la Ferreteria ===================================");
            Console.WriteLine("                                     ===============================================================================================================");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                                     ||     Codigo de Producto  ||  Nombre del Producto  ||  Cantidad en Existencias  ||  Precio del Producto  ||"); 
            
            foreach (var producto in ListadeProductos)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("                                              "+ producto.Codigo + "                         " + producto.Info + "                      " + producto.Existencia.ToString() + "                           "   + producto.Precio );
                Console.WriteLine("");
                Console.WriteLine("                                     ______________________________________________________________________________________________________________");

            }
            
            Console.ReadLine();  
        }
        
        private void movimientoInventario(string codigo, int cantidad, string tipoMovimiento) {
        foreach (var producto in ListadeProductos)
        {
            if (producto.Codigo == codigo) {
                if (tipoMovimiento == "+") {
                    producto.Existencia = producto.Existencia + cantidad;
                } else {
                    producto.Existencia = producto.Existencia - cantidad;
                }
            }         
        }
    }
            public void ingresoDeInventario() {
                string codigo = "";
                string cantidad = "";

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("                                                        =====================================================================");
                Console.WriteLine("                                                        =================  Ingreso de Podructo al Inventario ================");
                Console.WriteLine("                                                        =====================================================================");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("                                                                       Ingrese el codigo del producto: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                codigo = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("                                                                       Ingrese la cantidad del producto: ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                cantidad = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("                                                       =====================================================================");
                movimientoInventario(codigo, Int32.Parse(cantidad), "+");
            }           
            public void salidaDeInventario() {
            string codigo = "";
            string cantidad = "";
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.WriteLine("                                                       =====================================================================");
            Console.WriteLine("                                                       ================= Salida de Poductos del Inventario =================");
            Console.WriteLine("                                                       =====================================================================");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("                                                                       Ingrese el codigo del producto: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;           
            codigo = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("                                                                       Ingrese la cantidad del producto: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            cantidad = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("                                                       =====================================================================");
            movimientoInventario(codigo, Int32.Parse(cantidad), "-");
        }

        public void DatosClientes()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("                                               ====================================================================================");
            Console.WriteLine("                                               ======================  Listado de Clientes de la Ferreteria  ======================");
            Console.WriteLine("                                               ____________________________________________________________________________________");
            Console.WriteLine("");
            
            foreach (var cliente in ListadeClientes)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("                                                ______________________________________________________________________________________");
                Console.WriteLine("                                                 ||     Codigo de Cliente      Nombre del Cliente      Telefono del Cliente      ||");   
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("                                                            "+ cliente.Codigo + "                      "+      cliente.Nombre +     "                     "   + cliente.Telefono      );
            }
            Console.ReadLine();
        }
        public void DatosVendedores()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.WriteLine("                                                ========================================================================================");
            Console.WriteLine("                                                ========================== Listado de Vendedores de la Ferreteria ======================");
            Console.WriteLine("                                                ________________________________________________________________________________________");
            Console.WriteLine("");
            
            foreach (var vendedor in ListadeVendedores)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("                                                ______________________________________________________________________________________");
                Console.WriteLine("                                                ||     Codigo de Empleado   ||   Nombre del Empleado    ||  Codigo del Empleado   ||");   
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("                                                              "+ vendedor.Codigo + "                      "+      vendedor.Nombre +     "                         "   + vendedor.CodigoVendedor      );
            }

            Console.ReadLine();
        }
            public void CrearVenta()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                                                                    ======================= Creando Nueva Venta ===================");
            Console.WriteLine("                                                                    ===============================================================");                                             
            Console.WriteLine("");

            Console.Write("                                                                    Ingrese el codigo del cliente: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string codigoCliente = Console.ReadLine();

            Clientes cliente = ListadeClientes.Find(c => c.Codigo.ToString() == codigoCliente);        
            if (cliente == null)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("                                                                    Cliente no encontrado en el sistema");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.ReadLine();
                return;
            } else {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("                                                                    Cliente: " + cliente.Nombre);
                Console.WriteLine("");
                Console.WriteLine("                                                                     ______________________________________________________________");
                Console.WriteLine("");

            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("                                                                    Ingrese el codigo del vendedor: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;           
            string codigoVendedor = Console.ReadLine();

            Vendedores vendedor = ListadeVendedores.Find(v => v.Codigo.ToString() == codigoVendedor);
        if (vendedor == null) 
        {
            Console.WriteLine("");
            Console.WriteLine("                                                                    Vendedor no encontrado");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.ReadLine();
            return;
        } else {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("                                                                    Vendedor: " + vendedor.Nombre);
            Console.WriteLine("");
            Console.WriteLine("                                                                     ______________________________________________________________");
            Console.WriteLine("");

        }   
            int nuevoCodigo = ListaVentas.Count + 1;
            Venta nuevaVenta = new Venta(nuevoCodigo, DateTime.Now,   "TG" + nuevoCodigo, cliente, vendedor);
            ListaVentas.Add(nuevaVenta);

            while(true)
            {
                int cantidad = 1;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("                                                                    Ingrese el Codigo del Producto: ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                string codigoProducto = Console.ReadLine();
                
                Console.WriteLine("");
                Producto producto = ListadeProductos.Find(p => p.Codigo.ToString() == codigoProducto);        
                if (producto == null)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("                                                                    Producto no encontrado en el Inventario");
                    Console.ReadLine();
                    Console.WriteLine("");
                } else 
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("                                                                    Producto agregado a su factura: " + producto.Info + " con precio de: " + producto.Precio);
                        nuevaVenta.AgregarProducto(producto);
                        Console.WriteLine("                                                                                                                              ______________________________________________________________");
                        movimientoInventario(codigoProducto,(cantidad), "-");

                        Console.Write("");
                    }
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("");
                        Console.Write("                                                                    ¿Desea continuar? s | n: ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        string continuar = Console.ReadLine();
                        Console.WriteLine("");
                        if (continuar.ToLower() == "n") {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("                                                                     ______________________________________________________________");
                            Console.WriteLine("");
                            Console.Clear();
                           break;
                    }   

                    }
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine(""); 
                    Console.Write("                                                                    Imprimiendo Factura... ");
		using (var progreso = new BarradeProgreso()) {
			for (int i = 0; i <= 100; i++) {
				progreso.Report((double) i / 100);
				Thread.Sleep(50);
			}
		}
        Console.Clear();
		Console.WriteLine("                                                                    Hecho.");
	

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("                                                                    ===============================================================");                                             
                    Console.WriteLine("                                                                    ========== Factura de Consumo Ferreteria La Confianza =========");
                    Console.ForegroundColor = ConsoleColor.White;               
                    Console.WriteLine("");
                    Console.WriteLine("                                                                    Fecha de Facturación: " + " "+ DateTime.Now);
                    Console.WriteLine("                                                                    Factura Numero: "+        "#"+  nuevoCodigo);
                    Console.WriteLine("");
                    Console.WriteLine("                                                                    Nombre de Cliente: " +    "------------------------------------" + cliente.Nombre);
                    Console.WriteLine("                                                                    Nombre de Vendedor: "+    "-----------------------------------"+ vendedor.Nombre);
                    Console.WriteLine("");
                    Console.WriteLine("                                                                    ===============================================================");                                             
                    Console.WriteLine("");
                    Console.WriteLine("                                                                    Subtotal de la orden es de: " + "----------------------------"+ nuevaVenta.Subtotal);
                    Console.WriteLine("                                                                    Impuesto de la orden es de: " + "----------------------------" + nuevaVenta.Impuesto);
                    Console.WriteLine("                                                                    Total de la orden es de: " +    "-------------------------------" + nuevaVenta.Total);
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("                                                                    ===============================================================");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                }

            public void CantidadVentas()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("                                       ==================================================== Lista de Ventas =============================================");
                Console.WriteLine("                                       ==================================================================================================================");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;  
                Console.WriteLine("                                       __________________________________________________________________________________________________________________");
                Console.WriteLine("                                        Codigo    ||   Subtotal    ||   Impuesto    ||   Total   ||   Cliente   ||   Vendedor   ||    Fecha");
                foreach (var orden in ListaVentas)
                {
                    Console.ForegroundColor = ConsoleColor.White;  
                    Console.WriteLine("                                          " + orden.Codigo + "               " + orden.Subtotal + "            " + orden.Impuesto + "               " + orden.Total + "          " + orden.Cliente.Nombre + "          " + orden.Vendedor.Nombre+ "            " +  orden.Fecha);
                   
                    foreach (var detalle in orden.ListaVentaDetalle)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;  
                        
                        Console.WriteLine("                                       __________________________________________________________________________________________________________________");
                        Console.WriteLine("                                        Producto   ||   Cantidad    ||   Precio Unidad");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("                                         " + detalle.Producto.Info + "           " + detalle.Cantidad + "               " + detalle.Precio);
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("                                      =================================================================================================================");
                    
                    }

                    Console.WriteLine();
                } 

                Console.ReadLine();
            }
        }