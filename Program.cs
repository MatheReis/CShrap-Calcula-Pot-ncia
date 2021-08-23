using System;

namespace CShrap_Calcula_Potência
{
    class Program
    {
        static void Main(string[] args)
        {
          int N, p, Pote, J;

          Console.Write("Digite o número para ser potencializado: ");
          N = int.Parse(Console.ReadLine());

          Console.Write("Digite a potência desejada: ");
          p = int.Parse(Console.ReadLine());

          while ((p < 0) || (N <= 1))
          {
              Console.WriteLine("Entrada inválida");
              Console.WriteLine();
              Console.Write("Digite o número para ser potencializado: ");
              N = int.Parse(Console.ReadLine());
              Console.Write("Digite a potência desejada: ");
              p = int.Parse(Console.ReadLine());
          }

          Pote = 1;

          if (p > 0) //Se a potência é maior que zero
          {
              for (J = 1; J <= p; J++)  //calcula a potência com loop 
              {
                  Pote = Pote * N;
              }

          }

          Console.WriteLine();
          Console.WriteLine($"{N} elevado a {p} : {Pote}");
        } 
    }
}
