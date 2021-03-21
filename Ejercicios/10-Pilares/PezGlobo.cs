namespace Pilares
{
    class PezGlobo: Peces
    {
        public bool Seguro { get; set; }
        public PezGlobo(string nombre, int numeroaletas, string comer, string caracteristica)  
        {
            Nombre = nombre;
            NumeroAletas = numeroaletas;
            Comer = comer;
            Caracteristica = caracteristica;
            
        }
        public void Movilidad()
        {
            Nadar = true;
           
        }
       
        public void Inseguridad()
        {
            Seguro = true;
            Seguridad();
        }
           
        private void Seguridad()
        {
            Seguro = false;
        }   
    }   
}