public class Vendedores: Personas
{
    public string CodigoVendedor { get; set; }

    public Vendedores(int codigo, string nombre, string codigoVendedor)
    {
        Codigo = codigo;
        Nombre = nombre;
        CodigoVendedor = codigoVendedor;
    }
}