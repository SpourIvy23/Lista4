/*-------------------------------------------------------------------
Questão 4: Informações do Personagem
Contextualização:Em um jogo de exploração, o jogador precisa resgatar aliados
perdidos em um labirinto. O sucesso do resgate depende da quantidade de energia, da
distância até o aliado e do nível de ameaça no caminho.
• Comando: Crie um programa que receba a energia do jogador, a distância até o aliado
(em metros) e o nível de ameaça (baixo, médio, alto). Crie uma função que determine
se o resgate é possível com base nas seguintes condições:
• Energia maior que 50: Resgate bem-sucedido.
• Distância menor que 20 metros: +10 de energia.
• Nível de ameaça:
o Baixo: Sem penalidade.
o Médio: -10 de energia.
o Alto: -20 de energia.
• Exiba se o resgate foi bem-sucedido ou falhou.
@Lista: 04 
@Autor: Murilo Pires
@Data: 10/09/2024
---------------------------------------------------------------------*/
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digita a energia do jogador: ");
        int energia = int.Parse(Console.ReadLine());

        Console.WriteLine("Digita a distância até o aliado (em metros): ");
        int distancia = int.Parse(Console.ReadLine());

        Console.WriteLine("Digita o nível de ameaça: baixo, médio, alto ");
        string nivelAmeaca = Console.ReadLine().ToLower();

        bool resgateBemSucedido = VerificarResgate(energia, distancia, nivelAmeaca);

        if (resgateBemSucedido)
        {
            Console.WriteLine("Deu tudo certo!");
        }
        else
        {
            Console.WriteLine("Você falhou!");
        }
    }

    static bool VerificarResgate(int energia, int distancia, string nivelAmeaca)
    {
        if (distancia < 20)
        {
            energia += 10;
        }

        switch (nivelAmeaca)
        {
            case "baixo":
                break;
            case "médio":
            case "medio":
                energia -= 10;
                break;
            case "alto":
                energia -= 20;
                break;
            default:
                Console.WriteLine("Nível de ameaça inválido");
                return false;
        }

        return energia > 50;
    }
}
