namespace JogoPatos
{
    public class Corre : IPadraoCorrer
    {
        public Corre(){}

        public string Correr(){
            return $"Esse pato é um corredor: está correndo há {GetVelocidade()} Km/h\n" ;
        }

        public double GetVelocidade() {
            return 10;
        }
    }
}