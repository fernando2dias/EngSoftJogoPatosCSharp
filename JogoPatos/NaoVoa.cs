namespace JogoPatos
{
    public class NaoVoa : IPadraoVoaveis
    {
        public NaoVoa()
        {
            
        }

        public string Voar() {
            return $"Esse pato não voa. Velocidade {GetVelocidade()} Km/h";
        }

        public double GetVelocidade(){
            return 0;
        }
        
        
    }
}