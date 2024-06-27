

namespace PrimeiroProjeto.Menus;

internal class MenuExibirDetalhes:Menu
{
  
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Exibir detalhes da banda");
        Console.Write("Digite o nome da banda que deseja exbibir a media : ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {


            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.WriteLine($"\n A média da banda {nomeDaBanda} é {banda.Media}");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
           

        }
        else
        {
            Console.WriteLine($" \nA banda {nomeDaBanda} não foi encontrada");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
            

        }
    }
}
