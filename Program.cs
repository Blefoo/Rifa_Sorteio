using Rifa_Sorteio.Models;
using Rifa_Sorteio.Services;

Console.WriteLine("====== Rifa Sorteio ======");
Console.WriteLine("1. Sortear números");
Console.WriteLine("2. Verificar números premiados");
Console.WriteLine("3. Sair");
int[] numerosSorteados = new int[5];
bool continuar = true;
while (continuar)
{
    if (int.TryParse(Console.ReadLine(), out int opcao))
    {
        switch (opcao)
        {
            case 1:
                numerosSorteados = RifaService.sortear();
                Console.WriteLine("Números sorteados: " + string.Join(", ", numerosSorteados));
                break;
            case 2:
                Presentes presentes = new Presentes();
                for (int i = 0; i < presentes.premios.Length; i++)
                {
                    bool resultado = RifaService.verificar(numerosSorteados, presentes.premios[i]);
                    if (resultado)
                    {
                        Console.WriteLine("Parabéns! Você ganhou um prêmio!");
                        break;
                    }
                }
                Console.WriteLine("Que pena! Você não ganhou nenhum prêmio.");
                break;
            case 3:
                Console.WriteLine("Saindo do programa...");
                continuar = false;
                break;
            default:
                Console.WriteLine("Opção inválida. Tente novamente.");
                break;
        }
    }
}