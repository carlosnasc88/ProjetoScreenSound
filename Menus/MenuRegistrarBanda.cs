
namespace PrimeiroProjeto.Menus;

internal class MenuRegistrarBanda:Menu
{

   

    internal override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {

        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Registro das Bandas");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        Banda banda = new Banda(nomeDaBanda);
        bandasRegistradas.Add(nomeDaBanda,banda);
        //listaDasBandas.Add(nomeDaBanda);
        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
        Thread.Sleep(4000);
        Console.Clear();
        

    }
}
