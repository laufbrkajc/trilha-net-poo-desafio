namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        private List<string> AplicativosInstalados = new List<string> {"bloatware"};

        public Iphone(string num, string imei, string modl, int mem) : base(num, modl, imei, mem)
        {
        }

        public override void InstalarAplicativo(string? nomeApp)
        {
            if (nomeApp is null) {
                Console.WriteLine("Nome de aplicativo nulo não é válido.");
                return;
            }

            Console.WriteLine($"\nInstalando {nomeApp} no iPhone.");
            AplicativosInstalados.Add(nomeApp);
            Console.WriteLine($"{nomeApp} instalado.\n");
        }
    }
}
