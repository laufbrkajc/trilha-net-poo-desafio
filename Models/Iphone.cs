namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        private string[] AplicativosInstalados = { "bloatware" };

        public Iphone(string num, string imei, string modl, int mem) : base(num, modl, imei, mem)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no iPhone.");
            AplicativosInstalados.Append(nomeApp);
            Console.WriteLine("Instalado.");
        }
    }
}
