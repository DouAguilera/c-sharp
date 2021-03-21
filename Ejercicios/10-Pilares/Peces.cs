namespace Pilares
{
    abstract class Peces: Animales
    {
        public bool Nadar{ get; set; }

        public int NumeroAletas { get; set; }

        public string Caracteristica { get; set; }
    }
}