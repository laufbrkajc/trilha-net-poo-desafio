using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Iphone[] iphones = new Iphone[0];
Nokia[] nokias = new Nokia[0];
char opcaoMenu = ' ';

while (opcaoMenu != 's'&& opcaoMenu != 'S')
{
    Console.WriteLine("O que deseja fazer?");
    Console.WriteLine("Adicionar um novo telefone, Ligar para um número, Remover um telefone, Instalar um aplicativo ou Sair?(A/L/I/S)");
    opcaoMenu = (char)Console.Read();
    Console.Read();

    switch (opcaoMenu)
    {
        case 'a' or 'A':
            AdicionarTelefone();
            break;
        case 'l' or 'L':
            break;
        case 'r' or 'R':
            break;
        case 'i' or 'I':
            break;
        case 'e' or 'E':
            break;
        case 's' or 'S':
            break;
        default:
            break;
    }
}

void AdicionarTelefone()
{
    char opcao = ' ';
    string num = string.Empty;
    string modelo = string.Empty;
    int memoria = 0;

    while (opcao != 's' && opcao != 'S') {
        Console.WriteLine("Adicionar iPhone ou Nokia? 'S' para sair.(i/n/s)");
        opcao = (char)Console.Read();
        Console.Read();

        if (opcao == 's' || opcao == 'S') return;

        if (opcao == 'i' || opcao == 'I') {
            ColetaDados(ref num, ref modelo, ref memoria);
            iphones.Append(new Iphone(num, Guid.NewGuid().ToString(), modelo, memoria));
        } else if (opcao == 'n' || opcao == 'N') {
            ColetaDados(ref num, ref modelo, ref memoria);
            nokias.Append(new Nokia(num, Guid.NewGuid().ToString(), modelo, memoria));
        } else {
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
