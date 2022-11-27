namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        private List<string> AplicativosInstalados = new List<string> {"bloatware"};

        public Nokia(string num, string imei, string modl, int mem) : base(num, modl, imei, mem)
        {
        }

        public override void InstalarAplicativo(string? nomeApp)
        {
            if (nomeApp is null) {
                Console.WriteLine("Nome de aplicativo nulo não é válido.");
                return;
            }

            Console.WriteLine($"\nInstalando {nomeApp} no Nokia.");
            AplicativosInstalados.Add(nomeApp);
            Console.WriteLine($"{nomeApp} instalado.\n");
        }
    }
}
