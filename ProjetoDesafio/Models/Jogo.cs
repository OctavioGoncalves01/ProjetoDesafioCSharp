//*****************************************************************************************************

//By Octavio Goncalves 
//Data: 15/09/2024
//Versão: 0.0.1

//*****************************************************************************************************


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

//O "ERRO" se da ao foto de que 
//"Conversão de literal nula ou possível valor nulo em tipo não anulável"
// no metodo Usuario(), o erro é tratado por uma Exception em tempo de codigo.


namespace ProjetoDesafio.Models
{
    public class Jogo
    {

        //Importa a classe random        
        Random aleatorio = new Random();

        //Metodo privado, ele serve para entrada do usuario,
        // o mesmo valida a entrada se ela é um numero, 
        //e se o mesmo é um numero do range pedido
        private int Usuario(){
            int NumeroUsuario;
            
            while (true)
            {
                Console.Write("Digite um número entre 1 e 10: ");
                string entrada = Console.ReadLine();
                
                try
                {
                    NumeroUsuario = int.Parse(entrada);

                    //Verifica se o numero esta na range pedido
                    if (NumeroUsuario > 10 || NumeroUsuario < 0){

                        Console.WriteLine("Digite um valor válido!!");
                    //se a entrada for aceita ele retorna para o codigo
                    }else{
                        return NumeroUsuario;
                    }
                    
                //Caso caia em uma Exception ele mostra essa mensagem
                }catch (Exception){
                    Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
                }
            }
        }


        //Metodo usado para jogar
        public void Jogar(){
            //Variavel onde ira receber o Metodo usuario
            int NumeroUsuario;
            //Gera um numero aleatorio
            int  NumeroRandon = aleatorio.Next(1, 11);
            //Numero de tentativas
            int TentativasRestantes = 3;


            while (TentativasRestantes > 0)
            {
                
                NumeroUsuario = Usuario();

                if (NumeroUsuario == NumeroRandon)
                {
                    Console.WriteLine("Parabéns!! Você conseguiu acertar!!");
                    break; 
                }
                else
                {
                    Console.WriteLine("Você errou!!");
                    TentativasRestantes--;

                    if (TentativasRestantes > 0)
                    {
                        Console.WriteLine("Tente novamente.");
                        Console.WriteLine($"Tentativas restantes: {TentativasRestantes}");
                    }
                    else
                    {
                        Console.WriteLine("Você não tem mais tentativas.");
                        Console.WriteLine($"Número da CPU - {NumeroRandon}");

                    }
                }
            }





        }        
    }
}