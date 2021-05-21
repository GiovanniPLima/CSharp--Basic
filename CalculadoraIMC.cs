using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
        
         Console.WriteLine("Calculadora de IMC");
        //perunta o peso
         Console.WriteLine("Qual seu peso(KG)?");
         try{
          //captura o peso em String   
         var Peso = Console.ReadLine();
         //converte o peso para INT
         int peso = Int32.Parse(Peso);

         Console.WriteLine("Qual sua Altura?(Metros)");
         //captura altura em String
         var Altura = Console.ReadLine();
         //Converte Altura para Decimal
         decimal altura = Convert.ToDecimal(Altura);
         //Multiplica a altura decimal pelo peso int
         var result = altura * peso;
         Console.WriteLine($"Seu IMC é de {result}");
            //Finaliza dando tudo certo
        //Quer ir de novo?
        Console.WriteLine("Quer Calcular Novamente? Y/N");
        var YN = Console.ReadLine();
        do
        {
        if(YN == "Y")
        {
         Console.WriteLine("Calculadora de IMC");
        //perunta o peso
         Console.WriteLine("Qual seu peso(KG)?");
         Peso = Console.ReadLine();
         peso = Int32.Parse(Peso);
           Console.WriteLine("Qual sua Altura?(Metros)");
         //captura altura em String
          Altura = Console.ReadLine();
         //Converte Altura para Decimal
          altura = Convert.ToDecimal(Altura);
         // a altura decimal pelo peso int
          result = altura * peso;
         Console.WriteLine($"Seu IMC é de {result}");
         //finaliza 
          Console.WriteLine("Quer Calcular Novamente? Y/N");
            YN = Console.ReadLine();
        }
        } while(YN != "N");
                 Console.WriteLine("Obrigado Por Usar a Calculadora");
         } catch (FormatException)
         {      //se preencher com Letras veem para cá
             Console.WriteLine("Preencha com Números");
         }




        
        }
    }
}
