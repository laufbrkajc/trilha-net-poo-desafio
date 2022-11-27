namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; }
        public string IMEI { get; }
        public int Memoria { get; }

        public Smartphone(string numero, string modl, string imei, int mem)
        {
            Numero = numero;
            Modelo = modl;
            IMEI = imei;
            Memoria = mem;
        }

        public void Ligar(string num)
        {
            Console.WriteLine($"/nLigando para {num}");
        }

        public void ReceberLigacao(string num)
        {
            Console.WriteLine($"Recebendo ligação de {num}/n");
        }

        public abstract void InstalarAplicativo(string? nomeApp);
    }
}
