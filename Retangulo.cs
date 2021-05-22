using System;

namespace  Rentangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Digite a baixo a Altura(h)");
                //Captura a Altura (h)
                var h = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(h))
                {
                    Console.WriteLine("Por Favor Preencha com Números");
                }
                else
                {
                   
                       //Converte string para int
                        int ha = Int32.Parse(h);
                        Console.WriteLine("Qual a Base?(b)");
                        var b = Console.ReadLine();
                        int ba = Int32.Parse(b);
                        //Faz os Calculos Finais 
                        var haltura = ha * ba;
                        var baze = 2 * (ha + ba);
                        Console.WriteLine($"A Altura é de {haltura} e a base é de {baze}");
                        //Finaliza o Código 
                        Console.WriteLine("Calcular novamente? Y/N");
                        var YN = Console.ReadLine().ToUpper();
                       if(YN == "Y")
                    {
                        do
                        {
                            Console.WriteLine("Digite a baixo a Altura(h)");
                            h = Console.ReadLine();
                            if (String.IsNullOrEmpty(h)) 
                            {
                                Console.WriteLine("Preencha somente com numeros");
                            }else
                            {
                                ha = Int32.Parse(h);
                                Console.WriteLine("Qual a Base(b)");
                                b = Console.ReadLine();
                                ba = Int32.Parse(b);
                                haltura = ha * ba;
                                baze = 2*(ha + ba);
                                //finaliza os calculos

                                //apresenta os calculos

                                Console.WriteLine($"A Altura é de {haltura} e a base é de {baze}");
                                Console.WriteLine("Calcular Novamente? YN");
                                YN = Console.ReadLine().ToUpper();
                            }
                            


                        } while (YN != "N");
                    }else
                    {
                        Console.WriteLine("Obrigado, Volte Sempre");
                    }
                       
                    }
                } 
            catch(FormatException)
            {
                Console.WriteLine("Preencha somente com Números");
            }
        }
    }
}
