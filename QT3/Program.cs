/*-------------------------------------------------------------------
Questão 2: Informações do Personagem
Contextualização:Em combates, o jogador pode realizar ataques críticos que causam
danos adicionais. O dano causado depende do ataque base, do multiplicador crítico e
da arma utilizada.
• Comando: Crie um programa que receba o valor do ataque base, o multiplicador crítico
(1.5x, 2x, 3x) e o tipo de arma (Espada, Arco, Cajado). Crie uma função que calcule o
dano crítico da seguinte forma:
• Espada: +10 pontos ao dano total.
• Arco: +5 pontos ao dano total.
• Cajado: +15 pontos ao dano total.
• Exiba o dano total causado pelo ataque crítico.
@Lista: 04 
@Autor: Murilo Pires
@Data: 10/09/2024
---------------------------------------------------------------------*/
using System;


class Program
{
    static void Main()
    {
        int ataque;
        double valorCritico, danoFinal;
        string? arma;

        System.Console.WriteLine("Digite o ataque base");
        int.TryParse(Console.ReadLine(), out ataque);
        System.Console.WriteLine("Digite o valor do critico");
        double.TryParse(Console.ReadLine(), out valorCritico);
        System.Console.WriteLine("Digite a arma");
        arma = Console.ReadLine();
        while (arma != "arco" && arma != "cajado" && arma != "espada")
        {
            System.Console.WriteLine("Arma invalida, tente novamente");
            arma = Console.ReadLine();
        }

        Console.Clear();

        danoFinal = Criticos(ataque, valorCritico, arma);
        
        System.Console.WriteLine("O dano final é: " + danoFinal + " !");
        System.Console.WriteLine("Aperte ENTER para fechar.");
        System.Console.ReadLine();
    }

    static double Criticos(int ataque, double valorCritico, string arma)
    {   int dano = 0;
    double final;
        switch(arma)
        {
            case "arco":
            dano = 5;
            break;
            case "cajado":
            dano = 15;
            break;
            case "espada":
            dano = 10;
            break;


        }
        final = (valorCritico*ataque) + dano;
        return final;
    }

}

