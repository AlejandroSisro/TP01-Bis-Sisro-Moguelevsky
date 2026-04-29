 
 namespace TP1BIS_SISRO_MOGUELEVSKY
 {
 public class Complejo
    {
            private Dictionary <int, Complejo> integrantes = new Dictionary <int, Complejo>();
    
        public Complejo()
        {
      Dictionary <int, Complejo> integrantes = new Dictionary <int, Complejo>();
        } 
        private void CargaDatosManual()
        {
            Complejo Complejo1 = new Complejo(1, "Alejandro", "La mejor cabaña de todas con los colchones mas costosos de la actualidad",4, "Ale.jpg");
            Complejo Complejo1 = new Complejo(2, "sisro", "un destino inpecable con una increible vista de los alpes italianos ",2, "alpes.jpg");
            integrantes.Add(Alumno1);
            integrantes.Add(Alumno2);
        }
    }
   
}