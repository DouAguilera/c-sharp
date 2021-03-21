namespace Pilares
{
    class Perro: Mamiferos
    {
        public string Raza { get; set; }

        public Perro(string nombre, string raza, int cantidaddepatas, string comer, string ruido)  
        {
            Nombre = nombre;
            Raza = raza;
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