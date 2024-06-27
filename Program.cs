// Screen Sound
using PrimeiroProjeto.Menus;
using PrimeiroProjeto.Modelos;
using System.Collections.Generic;


string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
Banda ira = new Banda("Ira");
ira.AdicionarNota(new Avaliacao(10));
ira.AdicionarNota(new Avaliacao(8));
ira.AdicionarNota(new Avaliacao(6));
Banda beatles = new("The Beatles");
List<string> listaDasBandas = new List<string> { "U2", "The Beatles", "Calypso" };
//Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
//bandasRegistradas.Add("Link Park", new List<int> { 10, 8, 6 });
//bandasRegistradas.Add("The Beatles", new List<int>());
Dictionary < string, Banda > bandasRegistradas = new();
bandasRegistradas.Add(ira.Nome, ira);
bandasRegistradas.Add(beatles.Nome, beatles);

Dictionary<int,Menu> opcoes = new();
opcoes.Add(1, new MenuRegistrarBanda());
opcoes.Add(2, new MenuRegistrarAlbum());
opcoes.Add(3, new MenuMostrarBandasRegistradas());  
opcoes.Add(4, new MenuAvaliarUmaBanda());   
opcoes.Add(5, new MenuExibirDetalhes());
opcoes.Add(-1, new MenuSair());



void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para Registrar uma banda");
    Console.WriteLine("Digite 2 para Registrar o Albúm de uma banda");
    Console.WriteLine("Digite 3 para msotrar todas as bandas");
    Console.WriteLine("Digite 4 para avaliar uma banda");
    Console.WriteLine("Digite 5 para exbir tetalhes de uma banda");
    Console.WriteLine("Digite -1 para Sair");
    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
    {
        Menu menuASerExibido = opcoes[opcaoEscolhidaNumerica];
        menuASerExibido.Executar(bandasRegistradas);
        if (opcaoEscolhidaNumerica > 0) ExibirOpcoesDoMenu();

    }
    else
    {
        Console.WriteLine("Opção invalida");
    }
    
   
}
ExibirOpcoesDoMenu();