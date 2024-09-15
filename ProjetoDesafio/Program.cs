/*1. Calculadora Simples
Objetivo: Criar uma calculadora que possa realizar operações básicas como adição, subtração, multiplicação e divisão.
Recursos Utilizados: Estruturas condicionais (if, switch), operadores, métodos.
2. Conversor de Unidades
Objetivo: Criar um programa que converta unidades de medida, como comprimento (metros para quilômetros), massa (gramas para quilogramas), e temperatura (Celsius para Fahrenheit).
Recursos Utilizados: Estruturas condicionais, métodos, loops
1. Calculadora de IMC (Índice de Massa Corporal)
Objetivo: Calcular o IMC com base na altura e peso do usuário e classificar o resultado em categorias (por exemplo, abaixo do peso, normal, sobrepeso).
Recursos Utilizados: Operações matemáticas, estruturas condicionais.
2. Conversor de Moedas
Objetivo: Converter valores entre diferentes moedas (por exemplo, reais para dólares, euros para libras). Pode usar taxas de câmbio fixas ou integradas com uma API para obter taxas atualizadas.
Recursos Utilizados: Operações matemáticas, estruturas condicionais, manipulação de dados (se usar uma API).
3. Calculadora de Juros Compostos
Objetivo: Calcular o valor futuro de um investimento com base em uma taxa de juros composta.
Recursos Utilizados: Fórmulas matemáticas, operações matemáticas, entrada de dados do usuário.
4. Gerador de Senhas Aleatórias
Objetivo: Gerar senhas aleatórias com diferentes critérios (comprimento, inclusão de caracteres especiais, números e letras).
Recursos Utilizados: Manipulação de strings, randomização.
5. Conversor de Tempo
Objetivo: Converter unidades de tempo (por exemplo, horas para minutos, minutos para segundos).
Recursos Utilizados: Operações matemáticas, estruturas condicionais.
6. Calculadora de Área e Perímetro
Objetivo: Calcular a área e o perímetro de formas geométricas básicas (por exemplo, quadrado, retângulo, círculo).
Recursos Utilizados: Fórmulas matemáticas, operações matemáticas.
7. Calculadora de Descontos
Objetivo: Aplicar um desconto a um preço original e calcular o preço final.
Recursos Utilizados: Operações matemáticas, estruturas condicionais.
*/

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