 
 namespace TP1BIS_SISRO_MOGUELEVSKY
 {
 public class Complejo
    {
            private Dictionary <int, Complejo> cabañas = new Dictionary <int, Complejo>();
    
        public Complejo()
        {
      Dictionary <int, Complejo> cabañas = new Dictionary <int, Complejo>();
        } 
        private void CargaDatosManual()
        {
            Cabaña Cabaña1 = new Cabaña(1, "Alejandro", "La mejor cabaña de todas con los colchones mas costosos de la actualidad",4, "Ale.jpg");
            Cabaña Cabaña2 = new Cabaña(2, "sisro", "Un destino inpecable con una increible vista de los alpes italianos ",2, "alpes.jpg");
            cabañas.Add(Cabaña1);
            cabañas.Add(Cabaña2);
        }
    }
   
}
