namespace JogoPatos
{
    public class PatoBorracha : Pato
    {
        public PatoBorracha()
        {
            SetComportamento(new NaoVoa());
        }
        public override string Mostrar(){
            return "Eu sou um pato de borracha";
        }   
    }
}