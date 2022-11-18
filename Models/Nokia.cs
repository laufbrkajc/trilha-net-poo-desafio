namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        private string[] AplicativosInstalados = { "bloatware" };

        public Nokia(string num) : base(num)
        {
            Numero = num;
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            AplicativosInstalados.Append(nomeApp);
        }
    }
}
