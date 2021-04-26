using System;
using System.Collections.Generic;

public class Venta
{
    public int Codigo { get; set; }

    public DateTime Fecha { get; set; }

    public string NumerodeFactura { get; set; }

    public Clientes Cliente { get; set; }

    public Vendedores Vendedor { get; set; }
    

    public List<VentaDetalles> ListaVentaDetalle { get; set; }

    public double Subtotal { get; set; }

    public double Impuesto { get; set; }

    public double Total { get; set; }

    


    public Venta(int codigo, DateTime fecha, string numerodefactura, Clientes cliente, Vendedores vendedor)
    {
        Codigo = codigo;
        Fecha = fecha;
        NumerodeFactura = numerodefactura;
        Cliente = cliente;
        Vendedor = vendedor;

        ListaVentaDetalle = new List<VentaDetalles>();
    }

    public void AgregarProducto(Producto producto)
    {
        int nuevoCodigo = ListaVentaDetalle.Count + 1;
        int cantidad = 1;
        
        VentaDetalles o = new VentaDetalles(nuevoCodigo, 1,  producto);
        ListaVentaDetalle.Add(o);
        
        Subtotal += cantidad * producto.Precio;
        Impuesto = Subtotal * 0.15;
        Total = Subtotal + Impuesto;
        
    }
}