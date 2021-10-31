namespace JogoPatos
{
    public class PatoBravo : Pato, IPadraoGrasnar
    {
        public PatoBravo()
        {
            SetComportamento(new VoaveisAsa());
        }

        public override string Mostrar()
        {
            return "Eu sou um pato brabissimo";
        }

        public string Grasnar()
        {
            return "Que-Que. Grrrrrr";
        }
    }
}