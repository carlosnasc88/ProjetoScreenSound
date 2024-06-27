
namespace PrimeiroProjeto.Menus;
internal class MenuRegistrarAlbum:Menu
{


    
    internal override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Registro de Albúm");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        Console.WriteLine("Digite o Albúm que deseja registrar");
        string tituloAlbum = Console.ReadLine()!;
        Console.WriteLine($"O àlbum  {tituloAlbum} de {nomeDaBanda} foi regisrado com sucesso");
        Thread.Sleep(4000);
        Console.Clear();
        
    }
}
