using System;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            string mesAno;

            Console.WriteLine("Digite o número do mês que quer ou o nome: ");
            mesAno = Console.ReadLine();

             
            if (mesAno == "1")
             {
                 Console.WriteLine("JANEIRO: Esse mês tem 31 dias");
             }
             else if (mesAno == "Janeiro")
             {
                 Console.WriteLine("JANEIRO tem 31 dias");
             }
             else if (mesAno == "2")
             {
                 Console.WriteLine("FEVEREIRO: Esse mês tem 28 ou 29 dias");
             }
             else if (mesAno == "Fevereiro")
             {
                 Console.WriteLine("FEVEREIRO tem 28 ou 29 dias");
             }
              else if (mesAno == "3")
             {
                 Console.WriteLine("MARÇO: Esse mês tem 31 dias");
             }
             else if (mesAno == "Março")
             {
                 Console.WriteLine("MARÇO tem 31 dias");
             }
             else if (mesAno == "4")
             {
                 Console.WriteLine("ABRIL: Esse mês tem 30 dias");
             }
             else if (mesAno == "Abril")
             {
                 Console.WriteLine("ABRIL tem 30 dias");
             } 
             else if (mesAno == "5")
             {
                 Console.WriteLine("MAIO: Esse mês tem 31 dias");
             }
             else if (mesAno == "Maio")
             {
                 Console.WriteLine("MAIO tem 31 dias");
             }
              else if (mesAno == "6")
             {
                 Console.WriteLine("JUNHO: Esse mês tem 30 dias");
             }
             else if (mesAno == "Junho")
             {
                 Console.WriteLine("JUNHO tem 30 dias");
             }
              else if (mesAno == "7")
             {
                 Console.WriteLine("JULHO: Esse mês tem 31 dias");
             }
             else if (mesAno == "Julho")
             {
                 Console.WriteLine("JULHO tem 31 dias");
             }
              else if (mesAno == "8")
             {
                 Console.WriteLine("AGOSTO: Esse mês tem 31 dias");
             }
             else if (mesAno == "Agosto")
             {
                 Console.WriteLine("AGOSTO tem 31 dias");
             }
              else if (mesAno == "9")
             {
                 Console.WriteLine("SETEMBRO: Esse mês tem 30 dias");
             }
             else if (mesAno == "Setembro")
             {
                 Console.WriteLine("SETEMBRO tem 30 dias");
             }
              else if (mesAno == "10")
             {
                 Console.WriteLine("OUTUBRO: Esse mês tem 31 dias");
             }
             else if (mesAno == "Outubro")
             {
                 Console.WriteLine("OUTUBRO tem 31 dias");
             }
              else if (mesAno == "11")
             {
                 Console.WriteLine("NOVEMBRO: Esse mês tem 30 dias");
             }
             else if (mesAno == "Novembro")
             {
                 Console.WriteLine("NOVEMBRO tem 30 dias");
             }
             else if (mesAno == "12")
             {
                 Console.WriteLine("DEZEMBRO: Esse mês tem 31 dias");
             }
             else if (mesAno == "Dezembro")
             {
                 Console.WriteLine("DEZEMBRO tem 31 dias");
             } 
             else
             {
                 Console.WriteLine("Houve algum erro! Por favor verifica a forma de digitação!!");
             }
        }
    }
}
