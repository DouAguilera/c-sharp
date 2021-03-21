using System;

namespace Pilares
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Perro pe = new Perro("Perro", "Pitbul", 4, "Carne", "Ladrar");
            pe.Id = 1;
            pe.Movilidad();
           
            Gato g = new Gato("Gato", 4, "Ratones", "Maulla");
            g.Id = 2;
            g.Movilidad();
       
            Mono m = new Mono("Mono", 2, "Bananas", "Chilla");
            m.Id = 3;
            m.Movilidad();

            Aguila a = new Aguila("Aguila", "Mamiferos y Peces", "Cafes");
            a.Id = 4;
            a.Vuelo();
            a.Habilidad();

            Loro l = new Loro("Loro", "Semillas", "Verdes");
            l.Id = 5;
            l.Vuelo();
            l.Habilidad();

            PezGlobo pg = new PezGlobo("Pez Globo", 2, "Restos Marinos", "Es Venenoso");
            pg.Id = 6;
            pg.Movilidad();
            pg.Inseguridad();
            
            Console.WriteLine(" ");
            Console.WriteLine("**********ANIMALES POR SU TIPO**********");
            Console.WriteLine("===========MAMIFEROS=========");
            Console.WriteLine("Animal numero es: " + pe.Id);
            Console.WriteLine("El animal es: " + pe.Nombre);
            Console.WriteLine("Su Raza es: "+  pe.Raza);
            Console.WriteLine("Cantidad de Patas: " + pe.CantidadePatas);
            Console.WriteLine("El animal come: " + pe.Comer);
            Console.WriteLine("El sonido del animal es: " + pe.Ruido);
            Console.WriteLine("El animal Camina?: " + pe.Caminar);

            Console.WriteLine(" ");
            Console.WriteLine("Animal Numero: " + g.Id);
            Console.WriteLine("El animal es: " + g.Nombre);
            Console.WriteLine("Cantidad de Patas: " + g.CantidadePatas);
            Console.WriteLine("El animal come: " + g.Comer);
            Console.WriteLine("El sonido del animal es: " + g.Ruido);
            Console.WriteLine("El animal Camina?: " + pe.Caminar);

            Console.WriteLine(" ");
            Console.WriteLine("Animal Numero: " + m.Id);
            Console.WriteLine("El animal es: " + m.Nombre);
            Console.WriteLine("Cantidad de Patas: " + m.CantidadePatas);
            Console.WriteLine("El animal come: " + m.Comer);
            Console.WriteLine("El sonido del animal es: " + m.Ruido);
            Console.WriteLine("El animal Camina?: " + m.Caminar);

            Console.WriteLine(" ");
            Console.WriteLine("===========AVES=========");
            Console.WriteLine("Animal Numero: " + a.Id);
            Console.WriteLine("El animal es: " + a.Nombre);
            Console.WriteLine("El animal vuela: " + a.Volar);
            Console.WriteLine("El animal come: " + a.Comer);
            Console.WriteLine("El color del plumaje es: " + a.ColorPlumaje);
            Console.WriteLine("Tiene la capacidad de: " + a.Capacidad);

            Console.WriteLine(" ");
            Console.WriteLine("Animal Numero: " + l.Id);
            Console.WriteLine("El animal es: " + l.Nombre);
            Console.WriteLine("El animal come: " + l.Comer);
            Console.WriteLine("El animal vuela: " + l.Volar);
            Console.WriteLine("El color del plumaje es: " + l.ColorPlumaje);
            Console.WriteLine("Tiene la capacidad de: " + l.Capacidad);

            Console.WriteLine(" ");
            Console.WriteLine("===========PECES=========");
            Console.WriteLine("Animal Numero: " + pg.Id);
            Console.WriteLine("El animal es: " + pg.Nombre);
            Console.WriteLine("El animal come: " + pg.Comer);
            Console.WriteLine("El animal puede nadar?: " + pg.Nadar);
            Console.WriteLine("Cantidad de Aletas: " + pg.NumeroAletas);
            Console.WriteLine("Una caracteristica es: " + pg.Caracteristica);
            Console.WriteLine("Si esta inseguro se desinfla?: " + pg.Seguro);
            Console.WriteLine(" ");
           

                
        }
    }
}