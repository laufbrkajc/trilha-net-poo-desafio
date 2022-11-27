using DesafioPOO.Models;

List<Smartphone> smartphones = new List<Smartphone>();
char opcaoMenu = ' ';

smartphones.Add(new Nokia("34 12345-6789", Guid.NewGuid().ToString(), "2.1", 2));
smartphones.Add(new Iphone("45 98765-4321", Guid.NewGuid().ToString(), "10 Pro", 2));

Nokia nokia_21 = (Nokia)smartphones[0];
Iphone iphone_10Pro = (Iphone)smartphones[1];

nokia_21.InstalarAplicativo("Telegram");
iphone_10Pro.InstalarAplicativo("Stellarium");

nokia_21.Ligar(iphone_10Pro.Numero);
iphone_10Pro.ReceberLigacao(nokia_21.Numero);

while (opcaoMenu != 's' && opcaoMenu != 'S')
{
    Console.WriteLine("\nO que deseja fazer?");
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
            InstalarAplicativo();
            break;
        case 'e' or 'E': // Excluir um telefone
            ExcluirTelefone();
            break;
        case 's' or 'S': // Sair
            break;
        default:
            break;
    }
}

void ExcluirTelefone()
{
    Smartphone telefone = new Nokia(" ", " ", " ", 0);
    string? numeroTelefone = "";
    Console.WriteLine("\nDigite o número do telefone a ser excluído.");
    numeroTelefone = Console.ReadLine();

    if (!SelecionarSmartphone(numeroTelefone, out telefone)) {
        Console.WriteLine("\nTelefone não encontrado.");
        return;
    };

    smartphones.Remove(telefone);

    Console.WriteLine("\nTelefone removido.");
}

void InstalarAplicativo()
{
    Smartphone telefone = new Nokia(" ", " ", " ", 0);
    string? nomeAplicativo = "";
    string? numeroTelefone = "";

    Console.WriteLine("\nDigite o número do telefone no qual quer instalar um aplicativo");
    numeroTelefone = Console.ReadLine();
    Console.WriteLine("Por favor, digite o nome do aplicativo a ser instalado.\n");
    nomeAplicativo = Console.ReadLine();

    if (!SelecionarSmartphone(numeroTelefone, out telefone)) {
        Console.WriteLine("\nTelefone não encontrado.");
        return;
    }

    if (nomeAplicativo is null) {
        Console.WriteLine("Nome de aplicativo nulo não é válido.");
        return;
    }

    telefone.InstalarAplicativo(nomeAplicativo);
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
        string nokiaOuIphone = (telefone is Nokia) ? "Nokia" : "iPhone";
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

    Console.WriteLine("\nDe qual número quer ligar?");
    meuNumero = Console.ReadLine();
    Console.WriteLine("Para qual número quer ligar?");
    contato = Console.ReadLine();

    if(!SelecionarSmartphone(meuNumero, out meuTelefone))
    {
        Console.WriteLine("\nTelefone origem não encontrado.");
        return;
    }
    else if(!SelecionarSmartphone(contato, out telefoneDestino))
    {
        Console.WriteLine("\nTelefone destino não encontrado.");
        return;
    }

    meuTelefone.Ligar(telefoneDestino.Numero);
    telefoneDestino.ReceberLigacao(meuTelefone.Numero);
}

void AdicionarTelefone()
{
    char opcao = ' ';
    string? num = null;
    string? modelo = null;
    int memoria = 0;

    while (opcao != 's' && opcao != 'S')
    {
        Console.WriteLine("\nAdicionar iPhone ou Nokia? 'S' para sair.(i/n/s)");
        opcao = (char)Console.Read();
        Console.Read();

        if (opcao == 's' || opcao == 'S') return;

        if (opcao == 'i' || opcao == 'I')
        {
            if (ColetaDados(ref num, ref modelo, ref memoria)) {
                smartphones.Add(new Iphone(num!, Guid.NewGuid().ToString(), modelo!, memoria));
            }
        }
        else if (opcao == 'n' || opcao == 'N')
        {
            if (ColetaDados(ref num, ref modelo, ref memoria))
            {
                smartphones.Add(new Nokia(num!, Guid.NewGuid().ToString(), modelo!, memoria));
            }
        }
        else
        {
            Console.WriteLine($"\n{opcao}, não é uma opção válida");
            break;
        }
    }
}

bool ColetaDados(ref string? num, ref string? modelo, ref int memoria)
{
    string? tempMem = string.Empty;

    Console.WriteLine("Digite as informações.");
    Console.Write("\n    Numero: ");
    num = Console.ReadLine()!;
    if (num is null || num.Length == 0) {
        Console.WriteLine("\nO número não pode ser nulo ou vazio");
        return false;
    }

    Console.Write("    Modelo: ");
    modelo = Console.ReadLine()!;
    if (modelo is null || modelo.Length == 0) {
        Console.WriteLine("\nO modelo não pode ser nulo ou vazio");
        return false;
    }

    Console.Write("    Memoria: ");
    tempMem = Console.ReadLine();
    if (tempMem is null || tempMem.Length == 0) {
        Console.WriteLine("\nO modelo não pode ser nulo ou vazio");
        return false;
    }
    memoria = int.Parse(tempMem);
    return true;
}
