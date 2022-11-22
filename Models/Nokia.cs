namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        private string[] AplicativosInstalados = { "bloatware" };

        public Nokia(string num, string imei, string modl, int mem) : base(num, modl, imei, mem)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no Nokia.");
            AplicativosInstalados.Append(nomeApp);
            Console.WriteLine("Instalado.");
        }
    }
}
