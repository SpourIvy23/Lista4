/*-------------------------------------------------------------------
Questão 2: Informações do Personagem
Contextualização:Em um jogo de aventuras, o jogador ganha pontos ao completar
missões. A pontuação é calculada com base na dificuldade da missão, na quantidade 
de inimigos derrotados e no tempo gasto para completar.
Comando: Crie um programa que receba a dificuldade da missão (Fácil, Média, Difícil),
o número de inimigos derrotados e o tempo gasto (em minutos). Crie uma função para 
calcular a pontuação da missão usando os seguintes critérios:
Fácil: 5 pontos por inimigo, sem penalidade de tempo.
Média: 10 pontos por inimigo, -2 pontos por minuto acima de 10 minutos.
Difícil: 15 pontos por inimigo, -5 pontos por minuto acima de 15 minutos.
Exiba a pontuação final do jogador
@Lista: 04 
@Autor: Murilo Pires
@Data: 10/09/2024
---------------------------------------------------------------------*/
using System;

class Program
{
    static void Main()
    {
        string? dificuldade;
        int inimigosDerrotados, tempo, pontuacao;

        System.Console.WriteLine("Digite a dificuldade");
        dificuldade = System.Console.ReadLine()?.Trim().ToLower();
        while (dificuldade != "facil" && dificuldade != "media" && dificuldade != "dificil")
        {
            System.Console.WriteLine("Dificuldade invalida tente novamente");
            dificuldade = System.Console.ReadLine()?.Trim().ToLower();
        }
        System.Console.WriteLine("Digite o número de inimigos derrotados");
        int.TryParse(Console.ReadLine(), out inimigosDerrotados);
        System.Console.WriteLine("Digite o tempo da missão");
        int.TryParse(Console.ReadLine(), out tempo);

        Console.Clear();

        pontuacao = Calcularponto(dificuldade, inimigosDerrotados, tempo);

        System.Console.WriteLine("Você alcançou " + pontuacao + " pontos nessa missão!");
        System.Console.WriteLine("Aperte ENTER para fechar");
        Console.ReadLine();



    }

    static int Calcularponto(string dificuldade, int inimigosDerrotados, int tempo)
    {
        int pontosPorinimigo = 0, tempoLimite = 0, pontuacao, penalidade = 0, tempoPenalidade = 0;
        switch (dificuldade)
        {
            case "facil":
                pontosPorinimigo = 5;
                tempoLimite = int.MaxValue;
                break;
            case "media":
                pontosPorinimigo = 10;
                tempoLimite = 10;
                tempoPenalidade = 2;
                break;
            case "dificil":
                pontosPorinimigo = 15;
                tempoLimite = 15;
                tempoPenalidade = 5;
                break;

            default:
                System.Console.WriteLine("Dificuldade invalida, tente denovo");
                return 0;


        }

        pontuacao = pontosPorinimigo * inimigosDerrotados;

        if (tempo > tempoLimite)
        {
            penalidade = tempo - tempoLimite;
            pontuacao -= penalidade * tempoPenalidade;

        }
        if (pontuacao < 0)
        {
            pontuacao = 0;
        }


        return pontuacao;
    }
}