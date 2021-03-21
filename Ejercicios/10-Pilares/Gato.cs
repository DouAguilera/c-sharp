namespace Pilares
{
    class Gato: Mamiferos
    {
        public Gato(string nombre, int cantidaddepatas, string comer, string ruido)  
        {
            Nombre = nombre;
            CantidadePatas = cantidaddepatas;
            Comer = comer;
            Ruido = ruido;    
        }
      
        public void Movilidad()
        {
            Caminar = true;
        }
          
    }
}