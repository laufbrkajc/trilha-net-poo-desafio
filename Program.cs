using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Iphone[] iphones;
Nokia[] nokias;
char opcaoMenu = ' ';

switch (opcaoMenu)
{

    case 'a' or 'A':
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

void AdicionarTelefone()
{
    char opcao = ' ';
    string num = string.Empty;
    string modelo = string.Empty;
    int memoria = 0;

    while (opcao != 's' && opcao != 'S') {
        Console.WriteLine("Adicionar iPhone ou Nokia? 'S' para sair.(i/n/s)");
        if (opcao == 's' || opcao == 'S') return;

        if (opcao == 'i' || opcao == 'I') {
            ColetaDados(ref num, ref modelo, ref memoria);
            iphones.Append(new Iphone(num, Guid.NewGuid().ToString(), modelo, memoria));
        } else if (opcao == 'n' || opcao == 'N') {
            ColetaDados(ref num, ref modelo, ref memoria);
            nokias.Append(new Nokia(num, Guid.NewGuid().ToString(), modelo, memoria));
        } else {
            Console.WriteLine("Opção inválida");
        }
    }
}
void ColetaDados(ref string num, ref string modelo, ref int memoria)
{
    Console.WriteLine("Digite as informações.");
    Console.WriteLine("    Numero: ");
    num = Console.ReadLine();
    Console.WriteLine("    Modelo: ");
    modelo = Console.ReadLine();
    Console.WriteLine("    Memoria: ");
    memoria = int.Parse(Console.ReadLine());
}
