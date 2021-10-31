namespace JogoPatos
{
    public class PatoRuivo : Pato, IPadraoGrasnar
    {
        public PatoRuivo()
        {
            SetComportamento(new VoaveisAsa());
        }

        public override string Mostrar()
        {
            return "Eu sou o Pato Ruivo";
        }

        public string Grasnar()
        {
            return "Que-que";
        }
        
    }
}