using System;

namespace Estudos
{

    class Program
    {
        static void Main(string[] args)
        {   //solciitado o nome
            Console.WriteLine("Digite Seu Nome:");
            var nome = Console.ReadLine();
            var op = "";
            //Verifica se nome é vazio ou nulo
           if(string.IsNullOrEmpty(nome))
           {
               //se for nulo pergunta se quer preencher de novo
              Console.WriteLine("Você não Preencheu um nome");
              Console.WriteLine("Deseja Tentar novamente? Y/N");
              var yn = Console.ReadLine();
              //se sim
              if(yn == "y")
              {
                Console.WriteLine("Digite Seu Nome:");
                nome = Console.ReadLine();
                op = "";
                //se vazio de novo
                if(string.IsNullOrEmpty(nome))
                {
                    Console.WriteLine("Sistema Encerrado, Obrigado");
                }
                //se preenchido
                else
                {
                 do
            {   Console.WriteLine("Bem vindo" + " " + nome);
                Console.WriteLine("Sistema Inicializado em:" +" "+ DateTime.Now);
                Console.WriteLine("Selecione a Operação Desejada");
                Console.WriteLine("1- Sacar | 2 - Depositar | 3 - Saldo | 0 - Sair");
                op = Console.ReadLine();
            switch (op)
            {
                 case "1":
                Console.WriteLine("Saque Realizado");
                break;
                
                case "2":
                Console.WriteLine("Depositado R$100,00");
                break;
                
                case "3":
                Console.WriteLine("Seu Saldo é de R$100,00");
                break;
        }
            }
            while(op != "0");

            Console.WriteLine("Obrigado"+" "+nome+ " "+ "Por Usar Nosso Sistema");
               } 
               }
              //se não
              else
              { 
                  Console.WriteLine("Sistema Encerrado, Obrigado");
              }
           }
            //se nome preechido 
           else{
            
                 do
            {   Console.WriteLine("Bem vindo" + " " + nome);
                Console.WriteLine("Sistema Inicializado em:" +" "+ DateTime.Now);
                Console.WriteLine("Selecione a Operação Desejada");
                Console.WriteLine("1- Sacar | 2 - Depositar | 3 - Saldo | 0 - Sair");
                op = Console.ReadLine();
            switch (op)
            {
                 case "1":
                Console.WriteLine("Saque Realizado");
                break;
                
                case "2":
                Console.WriteLine("Depositado R$100,00");
                break;
                
                case "3":
                Console.WriteLine("Seu Saldo é de R$100,00");
                break;
        }
            }
            while(op != "0");

            Console.WriteLine("Obrigado"+" "+nome+ " "+ "Por Usar Nosso Sistema");
              }

           }

        }
    }

