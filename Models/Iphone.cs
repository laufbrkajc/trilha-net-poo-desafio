namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        private string[] AplicativosInstalados = { "bloatware" };

        public Iphone(string num, string imei, string modl, int mem) : base(num, modl, imei, mem)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            AplicativosInstalados.Append(nomeApp);
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
    }
}
