namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        private List<string> AplicativosInstalados = new List<string> {"bloatware"};

        public Nokia(string num, string imei, string modl, int mem) : base(num, modl, imei, mem)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"\nInstalando {nomeApp} no Nokia.");
            AplicativosInstalados.Add(nomeApp);
            Console.WriteLine($"{nomeApp} instalado.\n");
        }
    }
}
