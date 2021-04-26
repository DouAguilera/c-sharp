namespace VentasPOS

{

class Seguridad
{
    public bool Autenticador(string usuario, string contrasena)
    {
        if  (usuario == "admin" && contrasena == "admin1234")
        {
            return true;
        }
            return false;
        }
    }
}
