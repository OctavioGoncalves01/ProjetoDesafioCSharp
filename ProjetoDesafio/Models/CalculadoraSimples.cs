//*****************************************************************************************************

//By Octavio Goncalves 
//Data: 15/09/2024
//Versão: 0.0.1

//*****************************************************************************************************


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*
1. Calculadora Simples
Objetivo: Criar uma calculadora que possa realizar operações básicas como adição, subtração, multiplicação e divisão.
Recursos Utilizados: Estruturas condicionais (if, switch), operadores, métodos.
*/


namespace ProjetoDesafio.Models
{
    public class CalculadoraSimples
    {
        //Construtor Vazio
        public CalculadoraSimples(){}

       //Construtor contendo os numeros e o sinal de operação
        public CalculadoraSimples(double num1, double num2, string operacao){
            Numero1 = num1;
            Numero2 = num2;
            Sinal = operacao;

        }

        //Declaração de Variaveis
        public double Numero1 {get; set;}

        public double Numero2 {get; set;}

        public string Sinal {get; set;}



        //Metodos

        private double ValidacaoNumero(){
            
            double numero;

            while(true)
            {
                Console.Write("Digite um valor: ");
                string entradaUsuario = Console.ReadLine();

                try
                {    
                    numero = double.Parse(entradaUsuario);
                    return numero;
                }catch(Exception)
                {
                    Console.WriteLine("Entrada inválida.\nPor favor, digite um número.");
                }
            }

        }

        private string ValidacaoSinal(){
            
            string operacao;

            while (true){
                Console.WriteLine("Qual operação será: [ + - * / ] ");
                operacao = Console.ReadLine().Replace(" ", "");
            
                switch (operacao){
                    case "+":
                    case "-":
                    case "*":
                    case "/":
                        return operacao;
                    
                    default:
            
                        Console.WriteLine("Sinal inválido!!");                
                        break;
                }                    

            }

        }


        //Faz um switch case e verifica o sinal para realizar a operação
        public void Conta(){

            Console.WriteLine($"{Numero1}{Sinal}{Numero2} = ");
            switch (Sinal)
            { 
                case"+":
                    Console.WriteLine($"O resultado é {Numero1 + Numero2}");
                    break;

                case"-":
                    Console.WriteLine($"O resultado é {Numero1 - Numero2}");
                    break;
                
                case"*":
                    Console.WriteLine($"O resultado é {Numero1 * Numero2}");
                    break;
                
                case"/":
                    if(Numero2 == 0){
                        Console.WriteLine("Resultado impossivel de ser realizado!!");
                    }else{
                        Console.WriteLine($"O resultado é {Numero1 / Numero2}");
                    }
                    break;

                default:
                    Console.WriteLine("Operação inválida");
                    break;
            }
        }


        //Metodo para o menu inicial
        public void CalculadoraMenu(){
            
            Console.WriteLine("Digite o primeiro número: ");

            Numero1 = ValidacaoNumero();

            Console.WriteLine("Digite o segundo número: ");

            Numero2 = ValidacaoNumero();

            Sinal = ValidacaoSinal();

            Conta();
        }

    }
}