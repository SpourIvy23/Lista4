/*-------------------------------------------------------------------
Questão 5: Informações do Personagem
Contextualização: No jogo, o jogador pode usar habilidades especiais durante a
batalha. A escolha da habilidade depende da quantidade de mana disponível, do tipo de
inimigo e da distância do alvo.
• Comando: Crie um programa que receba a quantidade de mana, o tipo de inimigo
(Normal, Forte, Boss) e a distância do alvo (em metros). Crie uma função que sugira
qual habilidade usar com base nos seguintes critérios:
• Mana maior que 50: Use Habilidade Poderosa.
• Inimigo Forte ou Boss: +10 mana necessária.
• Distância menor que 10 metros: Reduz a mana necessária em 5.
• Exiba a habilidade sugerida.
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
            Console.WriteLine("AI SIM! BEM SUCEDIDO!");
        }
        else
        {
            Console.WriteLine("BEEEEEEEEEEP CÊ FALHOU!!!!");
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

