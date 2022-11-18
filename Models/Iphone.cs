namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        private string[] AplicativosInstalados = { "bloatware" };

        public Iphone(string num) : base(num)
        {
            Numero = num;
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            AplicativosInstalados.Append(nomeApp);
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
    }
}
