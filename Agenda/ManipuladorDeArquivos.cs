using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    public class ManipuladorDeArquivos
    {

        private static string EndArq = AppDomain.CurrentDomain.BaseDirectory + "contatos.txt";

        public static List<Contato> LerArquivo()
        {
            List<Contato> contatosList = new List<Contato>();
            if (File.Exists(@EndArq))
            {
                using (StreamReader sr = File.OpenText(@EndArq))
                {
                    while(sr.Peek() >= 0)
                    {
                        string linha = sr.ReadLine();
                        string[] linhaSplit = linha.Split(';');
                        if(linhaSplit.Count() == 3)
                        {
                            Contato contato = new Contato();
                            contato.Nome = linhaSplit[0];
                            contato.Email = linhaSplit[1];
                            contato.Telefone = linhaSplit[2];
                            contatosList.Add(contato);
                        }
                    }
                }
            }
            return contatosList;
        }
        public static void EscreverArquivo(List<Contato> contatosList)
        {

            using (StreamWriter sw = new StreamWriter(@EndArq, false))
            {
                foreach (Contato contato in contatosList)
                {
                    string linha = string.Format("{0};{1};{2}", contato.Nome, contato.Email, contato.Telefone);
                    sw.WriteLine(linha);
                }
                sw.Flush();
            }

        }
    }
}
