using PrimeiroProjeto.Modelos;

namespace PrimeiroProjeto.Menus;

internal class MenuAvaliarUmaBanda:Menu
{
    
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        ///Digiar banda que deseja avaliar
        /// Se banda existir no diacionário >> Atribui uma nota
        /// Se não existir volta ao menu principal.

        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Avaliar badna");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.WriteLine($"Qual a nota que a banda {nomeDaBanda} merede?");
            Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
            banda.AdicionarNota(nota);
            Console.WriteLine($"A nota {nota.Nota} foi registrada com seucesso para a bada {nomeDaBanda} ");
            Thread.Sleep(2000);
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
