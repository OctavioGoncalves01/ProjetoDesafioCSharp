//*****************************************************************************************************

//By Octavio Goncalves 
//Data: 16/09/2024
//Versão: 0.0.1

//*****************************************************************************************************


/*
2. Conversor de Unidades
Objetivo: Criar um programa que converta unidades de medida, como comprimento (metros para quilômetros), 
massa (gramas para quilogramas), e temperatura (Celsius para Fahrenheit).
Recursos Utilizados: Estruturas condicionais, métodos, loops

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ProjetoDesafio.Models
{
    public class ConversorDeUnidades
    {
        private double EntradaNumeral {get; set;}
        private string EscolhaConversao {get; set;}


        //Metodo para converter Metros em Km e KM em Metros
        private void ConverterComprimento(){
            double res;
            bool sair = true;
            
            while(sair){
            
                Console.WriteLine("A conversão será de:"
                +"\n1 - De metros para quilômetros:"+"\nOU\n" +
                "2 - De quilômetros para metros:");
            
                string usuario = Console.ReadLine().Replace(" ", "");

                if(usuario == "1"){
                    
                    res = EntradaNumeral / 1000;     
                    Console.WriteLine($"De metros para quilômetros  é {res}Km.");                      
                    sair = false;

                }else if(usuario == "2"){
                    
                    res = EntradaNumeral * 1000; 
                    Console.WriteLine($"De quilômetros para metros é {res}m.");
                    sair = false;
                }else{
                    Console.WriteLine("Valor inválido");
                }

            }


        }


        //Conversor de Massa
        private void ConverterMassa(){
            
            double res;
            bool sair = true;
            
            while(sair){
            
                Console.WriteLine("A conversão será de:"
                +"\n1 - De gramas para quilogramas:"+"\nOU\n" +
                "2 - De quilogramas para gramas:");
            
                string usuario = Console.ReadLine().Replace(" ", "");

                if(usuario == "1"){
                    
                    res = EntradaNumeral / 1000;     
                    Console.WriteLine($"De gramas para quilogramas é {res} quilogramas.");                      
                    sair = false;

                }else if(usuario == "2"){
                    
                    res = EntradaNumeral * 1000; 
                    Console.WriteLine($"De quilogramas para gramas é {res} gramas.");
                    sair = false;
                }else{
                    Console.WriteLine("Valor inválido");
                }

            }

        }


        //Converter Temperatura
        private void ConverterTemperatura(){

            double res;
            bool sair = true;
            
            while(sair){
            
                Console.WriteLine("A conversão será de:"
                +"\n1 - De Celsius para Fahrenheit:"+"\nOU\n" +
                "2 - De Fahrenheit para Celsius:");
            
                string usuario = Console.ReadLine().Replace(" ", "");

                if(usuario == "1"){
                    
                    res = (EntradaNumeral * 9 / 5) + 32;     
                    Console.WriteLine($"De Celsius para Fahrenheit é {res}°F.");                      
                    sair = false;

                }else if(usuario == "2"){
                    
                    res = (EntradaNumeral - 32) * 5 / 9;
                    Console.WriteLine($"De Fahrenheit para Celsius é {res}°C.");
                    sair = false;
                }else{
                    Console.WriteLine("Valor inválido");
                }

            }

        }


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

        private string ValidacaoEscolha(){
            
            string operacao;

            while (true){
                Console.WriteLine("Qual será a Conversão:" +
                "\n1 - Para Comprimento"+
                "\n2 - Para Massas"+
                "\n3 - Para Temperatura");
                operacao = Console.ReadLine().Replace(" ", "");
            
                switch (operacao){
                    case "1":
                    case "2":
                    case "3":
                        return operacao;
                    
                    default:
            
                        Console.WriteLine("Valor inválido!!");                
                        break;
                }                    

            }

        }


        //Metodo usado  para converter 
        public void Converter(){

            //O usuario Escolhe para qual a conversão 
            EscolhaConversao = ValidacaoEscolha();
            //Neste ele digite o valor
            EntradaNumeral = ValidacaoNumero();
            

            switch (EscolhaConversao)
            {
                case"1":
                    //Comprimento
                    ConverterComprimento();
                    break;
                
                case"2":
                    //Massa
                    ConverterMassa();
                    break;

                case"3":
                    //Temperatura
                    ConverterTemperatura();
                    break;
                
                default:
                    Console.WriteLine("Valor invalido");
                    break;
            }


        }

    }
}