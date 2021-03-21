namespace Pilares
{
    abstract class Mamiferos: Animales
    {
        public int CantidadePatas{ get; set; }

        public bool Caminar { get; set; }

        public string Ruido { get; set; }
        
    }
}