namespace TP1BIS_SISRO_MOGUELEVSKY
 {
 public class Complejo
    {
            private Dictionary <int, Cabaña> cabañas = new Dictionary <int, Cabaña>();
    
        public Complejo()
        {
      Dictionary <int, Cabaña> cabañas = new Dictionary <int, Cabaña>();
        } 
        private void CargaDatos()
        {
            Cabaña Cabaña1 = new Cabaña(1, "Francia", "La mejor cabaña de todas con los colchones mas costosos de la actualidad",4, "francia.jpg");
            Cabaña Cabaña2 = new Cabaña(2, "Italia", "Un destino inpecable con una increible vista de los alpes italianos ",2, "alpes.jpg");
            Cabaña Cabaña3 = new Cabaña(3, "Argentina", "Una cabaña con una vista imperdible del rio de la plata",6, "argentina.jpg");
            cabañas.Add(Cabaña1);
            cabañas.Add(Cabaña2);
            cabañas.Add(Cabaña3);
        }
        public Dictionary<int,Cabaña> DevolverCabañas()
        {
            return cabañas;
        }
        public Cabaña GetCabaña(int id)
        {
            if(cabañas.ContainsKey(id) = true)
            {
                return cabañas[id];
            }
            else
            {
                return null;
            }
        }
    }
