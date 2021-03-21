namespace Pilares
{
    class Aguila: Aves
    {
        public Aguila(string nombre, string comer, string colorplumaje)  
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
            Capacidad = "Vuela Alto";
        }
          
    }
}