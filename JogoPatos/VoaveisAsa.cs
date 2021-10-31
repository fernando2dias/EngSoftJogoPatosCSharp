namespace JogoPatos
{
    public class VoaveisAsa : IPadraoVoaveis
    {
        private double velocidade;
        
        public VoaveisAsa(){
            velocidade = 10;
        }

        public string Voar(){
            return $"Voando como um passaro que voa. Velocidade: {GetVelocidade()}";
        }

        public double GetVelocidade(){
            return velocidade;
        }
    }
}