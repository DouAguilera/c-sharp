public class Alumno 
{
    public string PrimerNombre { get; set; }
    public string SegundoNombre { get; set; }

    public int CodigoAlumno { get; set; }

    public int Edad { get; set; }

 
     public Alumno(string primerNombre, string segundoNombre, int CodigoAlumno, int Edad) {
        
        PrimerNombre = primerNombre;
        SegundoNombre = segundoNombre;
        CodigoAlumno = codigoalumno;
        Edad = edad;
    }
}