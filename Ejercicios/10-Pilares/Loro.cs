
namespace Pilares
{
    class Loro: Aves
    {
        public Loro(string nombre, string comer, string colorplumaje)  
        {
            Nombre = nombre;
            Comer = comer;
            ColorPlumaje = colorplumaje;
            
        }
        public void Vuelo()
        {
            Volar = true;
        }
        public void Habilidad()
        {
            Capacidad = "Hablar";
        }
          
    }
}

