// Screen Sound - Projeto Alura
// Professor: Guilherme e Daniel Portugal
// Desenvolvido por: Thainá Israel, 2023


// C# é um alinguagem fortemente tipada, ou seja, é necessário declarar o tipo da variável(string, int, double, bool)
// Nomes de variáveis são em camelCase, ou seja, a primeira letra da primeira palavra é minúscula e as demais palavras são maiúsculas
// Quando uma função não retorna nada, ela é do tipo void
// Nomes de função são em PascalCase, ou seja, a primeira letra de cada palavra é maiúscula
string boasVindas = "Bem vindo(a) ao Screen Sound";
void ExibirLogo()
{   // Verbatim string, ou seja, o texto é exibido exatamente como está escrito, sem precisar de caracteres de escape
    Console.WriteLine(@"
       
    ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
    ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
    ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
    ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
    ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
    ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
     ");
    Console.WriteLine(boasVindas);

}

void ExbirOpcoesDoMenu()
{   
    ExibirLogo();
    Console.WriteLine();
    Console.WriteLine("1 - Registrar uma banda");
    Console.WriteLine("2 - Listar bandas");
    Console.WriteLine("3 - Avaliar banda");
    Console.WriteLine("4 - Média de avaliação de uma banda");
    Console.WriteLine("5 - Sair");
    Console.WriteLine();
    Console.Write("Escolha uma opção: ");

    //Quando nao queremos trabalhar com valores nulos, podemos usar o operador !, que indica que a variável não é nula
    string opcaoEscolha = Console.ReadLine()!;
    int opcaoEscolhaNumerica = int.Parse(opcaoEscolha);

    // Switch case é uma estrutura de decisão, que funciona como um if, mas é mais legível quando temos muitas opções
    switch (opcaoEscolhaNumerica)
    {
        case 1:
            RegistrarBandas();
            break;
        case 2:
            Console.WriteLine("Listar bandas");
            break;
        case 3:
            Console.WriteLine("Avaliar banda");
            break;
        case 4:
            Console.WriteLine("Média de avaliação de uma banda");
            break;
        case 5:
            Console.WriteLine("Sair");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }


}
void RegistrarBandas()
{   
    // Console.Clear limpa a tela do console
    Console.Clear();
    Console.WriteLine("Registrar uma banda");
    Console.Write("Informe o nome da banda que você deseja registrar: ");
    string nomeDaBnada = Console.ReadLine()!;
    Console.WriteLine($"Banda {nomeDaBnada} registrada com sucesso!");
    // Thread.Sleep é uma função que faz o programa esperar por um tempo determinado, em milissegundos
    Thread.Sleep(2000);
    Console.Clear();
    ExbirOpcoesDoMenu();
}
ExbirOpcoesDoMenu();