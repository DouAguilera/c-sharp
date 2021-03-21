namespace Pilares
{
    class Mono: Mamiferos
    {
        public Mono(string nombre, int cantidaddepatas, string comer, string ruido)  
        {
            Nombre = nombre;
            CantidadePatas = cantidaddepatas;
            Comer = comer;
            Ruido = ruido;
        }
       
        public void Movilidad()
        {
            Caminar = true;
            Accesibilidad();
        }
           
        private void Accesibilidad()
        {
            Caminar = false;
        }   
    }   
}
