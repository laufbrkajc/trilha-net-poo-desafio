using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
List<Smartphone> smartphones = new List<Smartphone>();
char opcaoMenu = ' ';

while (opcaoMenu != 's' && opcaoMenu != 'S')
{
    Console.WriteLine("O que deseja fazer?");
    Console.WriteLine("Adicionar um novo telefone, Ligar para um número, Remover um telefone, Instalar um aplicativo ou Sair?(A/L/I/S)");
    opcaoMenu = (char)Console.Read();
    Console.Read();

    switch (opcaoMenu)
    {
        case 'a' or 'A': // Adicionar um telefone
            AdicionarTelefone();
            break;
        case 'c' or 'C': // Chamar um número
            break;
        case 'l' or 'L': // Listar os telefones
            ListarSmartphones();
            break;
        case 'i' or 'I': // Instalar um aplicativo
            break;
        case 'e' or 'E': // Excluir um telefone
            break;
        case 's' or 'S': // Sair
            break;
        default:
            break;
    }
}

void ListarSmartphones()
{
    foreach (var telefone in smartphones)
    {
        Console.WriteLine("teste");

        // Começamos imprimindo um rótulo indicando se o telefone é iPhone ou Nokia.
        Console.WriteLine($"  {0}", (telefone is Iphone) ? "iPhone" : "Nokia");
        Console.WriteLine($"    {telefone.Numero}");
        Console.WriteLine($"    {telefone.Modelo}");
        Console.WriteLine($"    {telefone.IMEI}");
        Console.WriteLine($"    {telefone.Memoria}");
    }
}

void Chamar(string meuNum, string contato)
{
    foreach (var telefone in smartphones)
    {
        if (telefone.Numero == contato)
        {
            telefone.ReceberLigacao(meuNum);
            return;
        }
    }

}

void AdicionarTelefone()
{
    char opcao = ' ';
    string num = string.Empty;
    string modelo = string.Empty;
    int memoria = 0;

    while (opcao != 's' && opcao != 'S')
    {
        Console.WriteLine("Adicionar iPhone ou Nokia? 'S' para sair.(i/n/s)");
        opcao = (char)Console.Read();
        Console.Read();

        if (opcao == 's' || opcao == 'S') return;

        if (opcao == 'i' || opcao == 'I')
        {
            ColetaDados(ref num, ref modelo, ref memoria);
            smartphones.Add(new Iphone(num, Guid.NewGuid().ToString(), modelo, memoria));
        }
        else if (opcao == 'n' || opcao == 'N')
        {
            ColetaDados(ref num, ref modelo, ref memoria);
            smartphones.Add(new Nokia(num, Guid.NewGuid().ToString(), modelo, memoria));
        }
        else
        {
            Console.WriteLine($"{opcao}, não é uma opção válida");
            break;
        }
    }
}

void ColetaDados(ref string num, ref string modelo, ref int memoria)
{
    Console.WriteLine("Digite as informações.");
    Console.Write("\n    Numero: ");
    num = Console.ReadLine();
    Console.Write("    Modelo: ");
    modelo = Console.ReadLine();
    Console.Write("    Memoria: ");
    memoria = int.Parse(Console.ReadLine());
}
