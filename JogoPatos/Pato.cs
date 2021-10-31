namespace JogoPatos
{
    public abstract class Pato
    {
        protected IPadraoVoaveis comportamentoPato;
        protected IPadraoCorrer corredor;

        public abstract string Mostrar();

        public string Nadar(){
            return "Pato nadando";
        }

        public string Correr(){
            return "Estou correndo...";
        }

        public void SetComportamento(IPadraoVoaveis padrao){
            comportamentoPato = padrao;
        }

        public string ComportamentoPato(){
            return comportamentoPato.Voar();
        }

        public void SetCorredor(IPadraoCorrer padrao){
            corredor = padrao;
        }

        public string Corredor(){
            return corredor.Correr();
        }

    }
}