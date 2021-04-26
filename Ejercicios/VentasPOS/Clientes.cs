using System.Collections.Generic;
public class Clientes: Personas
{
    public List<Clientes> NuevoCliente { get; set; }
    
    public Clientes(int codigo, string nombre, int telefono)
    {
        Codigo = codigo;
        Nombre = nombre;
        Telefono = telefono;
        NuevoCliente = new List<Clientes>();
    }

    public void AgregarCliente(Clientes clientes)
    {
        int codigo = NuevoCliente.Count + 1;
 
        Clientes o = new Clientes(1, " ", 1);
        NuevoCliente.Add(o);

        
    }
}
