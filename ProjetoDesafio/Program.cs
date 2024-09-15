//*****************************************************************************************************

//By Octavio Goncalves 
//Data: 15/09/2024
//Versão: 0.0.1

//*****************************************************************************************************


using ProjetoDesafio.Models;

Jogo p1 = new Jogo();

bool menu = true;

while (menu)
{
    Console.WriteLine("-----------------------------------------------------------------------------");
    Console.WriteLine("O que deseja fazer: ");

    Console.WriteLine("Jogar - 1");
    Console.WriteLine("Calculadora Simples - 2");
    Console.WriteLine("Conversor de Unidades - 3");
    Console.WriteLine("Sair - 0");

    string entrada = Console.ReadLine();

    switch (entrada)
    {
        case "0":
            Console.WriteLine("Saindo...");
            menu = false;
            break;
        case "1":
            p1.Jogar();
            break;
        
        case "2":
            Console.WriteLine("Ainda não implementado");
            break;
        
        case "3":
            Console.WriteLine("Ainda não implementado");
            break;

        default:
            Console.WriteLine("Opção inválida. Por favor, selecione 0 para sair ou 1 para jogar.");
            break;
    }
}