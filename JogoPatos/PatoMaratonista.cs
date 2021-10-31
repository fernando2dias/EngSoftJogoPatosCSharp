namespace JogoPatos
{
    public class PatoMaratonista : Pato
    {
        public PatoMaratonista()
        {
            SetCorredor(new Corre());
        }

        public override string Mostrar()
        {
            return "Eu sou um pato que gosta de correr longas distancias";
        }
    }
}