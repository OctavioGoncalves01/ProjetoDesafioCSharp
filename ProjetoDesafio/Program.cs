//*****************************************************************************************************

//By Octavio Goncalves 
//Data: 15/09/2024
//Versão: 0.0.2

//*****************************************************************************************************


using ProjetoDesafio.Models;



CalculadoraSimples c1 = new CalculadoraSimples();
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
            Console.WriteLine("Abrindo Calculadora...");
            c1.CalculadoraMenu();
            break;
        
        case "3":
            Console.WriteLine("Ainda não implementado");
            break;

        default:
            Console.WriteLine("Opção inválida. Por favor, selecione 0 para sair ou 1 para jogar.");
            break;
    }
}

