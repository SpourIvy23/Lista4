/*-------------------------------------------------------------------
Questão 1: Sistema de Cura de Personagem
• Contextualização: Em um jogo de RPG, o jogador pode usar poções de cura para
recuperar a vida do seu personagem durante a batalha. A quantidade de vida
recuperada depende do tipo de poção, do nível do personagem e da quantidade de
poções usadas.
• Comando: Crie um programa que receba o tipo de poção (Pequena, Média, Grande), o
nível do personagem e a quantidade de poções usadas. Crie uma função que calcule a
quantidade de vida recuperada com base nos seguintes critérios:
• Poção Pequena: 10 pontos de vida por poção.
• Poção Média: 20 pontos de vida por poção.
• Poção Grande: 30 pontos de vida por poção.
• Adicione 5 pontos adicionais para cada nível do personagem acima de 5.
• Exiba o total de vida recuperada
@Lista: 04 - Funções
@Autor: Murilo Pires
@Data: 03/09/2024
---------------------------------------------------------------------*/

using System;

class Program
{
    static void Main()
    {
        int nivel, vidaRecuperada, quantidade;
        string? tipoDepoçao;

        Console.WriteLine("Insira o tipo de poção");
        tipoDepoçao = Console.ReadLine();
        System.Console.WriteLine("Insira seu nível");
        int.TryParse(Console.ReadLine(), out nivel);
        System.Console.WriteLine("Quantas vezes a poção foi usada");
        int.TryParse(Console.ReadLine(), out quantidade);
        
        Console.Clear();
        
        vidaRecuperada = Calcular(nivel, quantidade, tipoDepoçao);
        System.Console.WriteLine("Você teve " + vidaRecuperada + " da sua vida recuperada!");

        System.Console.WriteLine("Aperte ENTER para fechar");
        Console.ReadLine();
        
       

    }
    static int Calcular(int nivel, int quantidade, string? tipoDepoçao)
    {
        int pontos = 0;
        int bonus = 0;
        int vidaRecuperada;
        switch (tipoDepoçao)
        {
            case "pequena":
                pontos = 10;
                break;
            case "média":
                pontos = 20;
                break;
            case "grande":
                pontos = 30;
                break;
        }
        vidaRecuperada = pontos * quantidade;

        if(nivel>5)
        {
             bonus = (nivel-5) * 5;
        }
        else
        {
            bonus=0;
        }

        return vidaRecuperada+bonus;
    }
}
