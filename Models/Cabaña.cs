namespace TP1BIS_SISRO_MOGUELEVSKY
 {
 public class Cabaña
    {
           private int id;
           private string nombre;
           private string descripcion;        
           private int capacidad;
            private List<string> fotos;
            private List<string> ambientes;
    
        public Cabaña(int id,string nombre,string descripcion,int capacidad)
        {
        this.id=id;
        this.nombre=nombre;
        this.descripcion=descripcion;
        this..capacidad=capacidad;
        List<string> fotos = new List<string>();
        List<string> ambientes = new List<string>();
        } 
      
    }
   
}
 
