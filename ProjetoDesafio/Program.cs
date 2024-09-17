//*****************************************************************************************************

//By Octavio Goncalves 
//Data: 16/09/2024
//Versão: 0.0.3

//*****************************************************************************************************


using ProjetoDesafio.Models;

//
Imc imcCalcular = new Imc();
ConversorDeUnidades conversorObjeto = new ConversorDeUnidades();
CalculadoraSimples calculadoraObjeto = new CalculadoraSimples();
Jogo jogoObjeto = new Jogo();

bool menu = true;

//Menu de interação
while (menu)
{
    Console.WriteLine("-----------------------------------------------------------------------------");
    Console.WriteLine("O que deseja fazer: ");
    Console.WriteLine("Jogar - 1");
    Console.WriteLine("Calculadora Simples - 2");
    Console.WriteLine("Conversor de Unidades - 3");
    Console.WriteLine("Calculadora de IMC - 4");
    Console.WriteLine("Sair - 0");

    string entrada = Console.ReadLine();

    Console.WriteLine("-----------------------------------------------------------------------------");

    switch (entrada)
    {
        case "0":
            Console.WriteLine("Saindo...");
            menu = false;
            break;
        case "1":
            Console.WriteLine("Abrido jogo de Adivinhação...");
            jogoObjeto.Jogar();
            break;
        
        case "2":
            Console.WriteLine("Abrindo Calculadora...");
            calculadoraObjeto.CalculadoraMenu();
            break;
        
        case "3":
            Console.WriteLine("Abrindo Conversor...");
            conversorObjeto.Converter();
            break;

        case "4":
            Console.WriteLine("Entrando na Aplicação...");
            imcCalcular.MostrarIMC();
            break;

        default:
            Console.WriteLine("Opção inválida. Por favor, selecione de 0 a 3.");
            break;
    }
}

