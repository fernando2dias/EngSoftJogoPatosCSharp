namespace JogoPatos
{
    public class VoarFoguete : IPadraoVoaveis
    {
        private double velocidade;

        public VoarFoguete()
        {
            velocidade = 1000;
        }

        public string Voar()
        {
            return $"Voando como um foguete. Velocidade: {GetVelocidade()}";
        }

        public double GetVelocidade()
        {
            return velocidade;
        }
    }
}