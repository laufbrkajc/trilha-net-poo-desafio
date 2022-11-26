using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
List<Smartphone> smartphones = new List<Smartphone>();
char opcaoMenu = ' ';

while (opcaoMenu != 's' && opcaoMenu != 'S')
{
    Console.WriteLine("O que deseja fazer?");
    Console.WriteLine("Adicionar um novo telefone, Fazer uma ligação, Ligar para um número, Remover um telefone, Instalar um aplicativo, Excluir um telefone ou Sair?(A/C/L/I/E/S)");
    opcaoMenu = (char)Console.Read();
    Console.Read();

    switch (opcaoMenu)
    {
        case 'a' or 'A': // Adicionar um telefone
            AdicionarTelefone();
            break;
        case 'c' or 'C': // Chamar um número
            Chamar();
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

bool SelecionarSmartphone(string? num, out Smartphone smartphoneEncontrado)
{
    foreach (var telefone in smartphones)
    {
        if (telefone.Numero == num) {
            smartphoneEncontrado = telefone;
            return true;
        }
    }

    smartphoneEncontrado = new Nokia("0", "0", "0", 0);
    return false;
}

void ListarSmartphones()
{
    foreach (var telefone in smartphones)
    {
        // Começamos com um rótulo indicando se o telefone é iPhone ou Nokia.
        string nokiaOuIphone = (telefone is Nokia) ? "iPhone" : "Nokia";
        Console.WriteLine($"  {nokiaOuIphone}");
        Console.WriteLine($"    Numero: {telefone.Numero}");
        Console.WriteLine($"    Modelo: {telefone.Modelo}");
        Console.WriteLine($"    IMEI: {telefone.IMEI}");
        Console.WriteLine($"    Memoria: {telefone.Memoria}");
    }
}

void Chamar()
{
    string? meuNumero = String.Empty;
    string? contato = String.Empty;
    Smartphone meuTelefone;
    Smartphone telefoneDestino;

    Console.WriteLine("De qual número quer ligar?");
    meuNumero = Console.ReadLine();
    Console.WriteLine("Para qual número quer ligar?");
    contato = Console.ReadLine();

    if(!SelecionarSmartphone(meuNumero, out meuTelefone))
    {
        Console.WriteLine("Telefone origem não encontrado.");
        return;
    }
    else if(!SelecionarSmartphone(contato, out telefoneDestino))
    {
        Console.WriteLine("Telefone destino não encontrado.");
        return;
    }

    meuTelefone.Ligar(telefoneDestino.Numero);
    telefoneDestino.ReceberLigacao(meuTelefone.Numero);
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
