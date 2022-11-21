namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string IMEI { get; set; }
        public int Memoria { get; set; }

        public Smartphone(string numero, string modl, string imei, int mem)
        {
            Numero = numero;
            Modelo = modl;
            IMEI = imei;
            Memoria = mem;
        }

        public void Ligar(string num)
        {
            Console.WriteLine($"Ligando para {num}");
        }

        public void ReceberLigacao(string num)
        {
            Console.WriteLine($"Recebendo ligação de {num}");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}
