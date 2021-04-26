public class Producto
{
    public string Codigo { get; set; }
    public string Info { get; set; }
    
    public int Existencia { get; set;}

    public double Precio { get; set; }

    public Producto(string codigo, string info, int existencia,  double precio)
    {
        Codigo = codigo;
        Info = info;
        Existencia = existencia;
        Precio = precio;
    }
}