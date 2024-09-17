//*****************************************************************************************************

//By Octavio Goncalves 
//Data: 16/09/2024
//Versão: 0.0.1

//*****************************************************************************************************


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*
4. Calculadora de IMC (Índice de Massa Corporal)
Objetivo: Calcular o IMC com base na altura e peso do usuário e classificar o resultado em categorias (por exemplo, abaixo do peso, normal, sobrepeso).
Recursos Utilizados: Operações matemáticas, estruturas condicionais.
*/

/*

 peso / (altura * altura);

Interpretação dos resultados
Os valores de IMC são geralmente interpretados da seguinte forma:

Abaixo do peso: IMC abaixo de 18,5
Peso normal: IMC entre 18,5 e 24,9
Sobrepeso: IMC entre 25 e 29,9
Obesidade: IMC de 30 ou mais

*/

namespace ProjetoDesafio.Models
{
    public class Imc
    {
        private double Peso;
        private double Altura;
        private string TxtPeso = "Digite o seu Peso \n(em KG EX: XX,xx)\n";
        
        private string TxtAltura = "Digite a sua altura \n(em Metros EX: X,xx)\n";

        private double ValidacaoNumero(string Txt){
            
            double numero;

            while(true)
            {
                Console.Write(Txt);
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

        private void CalcularIMC(){
            double imc = Peso / (Altura * Altura);
            Console.WriteLine(Peso + "" + Altura);
            Console.WriteLine($"Seu IMC é {imc:F2}");

            if(imc < 18.5){
                Console.WriteLine("Abaixo do peso: IMC abaixo de 18,5");
            }else if(imc <=24.9){
                Console.WriteLine("Peso normal: IMC entre 18,5 e 24,9");
            }else if(imc >= 25 && imc <=29.9){
                Console.WriteLine("Sobrepeso: IMC entre 25 e 29,9");
            }else{
                Console.WriteLine("Obesidade: IMC de 30 ou mais");
            }
        }

        public void MostrarIMC(){
            
            Peso = ValidacaoNumero(TxtPeso);
            Altura = ValidacaoNumero(TxtAltura);

            CalcularIMC();

            


        }
    }
}