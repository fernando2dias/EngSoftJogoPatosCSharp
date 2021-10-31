namespace JogoPatos
{
    public class PatoCorredor : Pato
    {
       public PatoCorredor()
       {
           SetCorredor(new Corre());
       } 

       public override string Mostrar()
       {
           return "Eu sou um pato que gosta de correr.";
       }
    }
}