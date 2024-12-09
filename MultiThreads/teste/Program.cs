using System;
using System.Threading;
using System.Threading.Tasks;

namespace ExemploParallel
{
    class Program
    {
        public static void processo1()
        {
            Console.WriteLine("Iniciando Processo1");
            Thread.Sleep(5000);
            Console.WriteLine("Finalizando Processo1");
            processo4();
        }
        public static void processo2()
        {
            Console.WriteLine("Iniciando Processo2");
            Thread.Sleep(4000);
            Console.WriteLine("Finalizando Processo2");
            processo5();
        }

        public static void processo3()
        {
            Console.WriteLine("Iniciando Processo3");
            Thread.Sleep(3000);
            Console.WriteLine("Finalizando Processo3");

        }

        public static void processo4()
        {
            Console.WriteLine("Iniciando Processo4");
            Thread.Sleep(3000);
            Console.WriteLine("Finalizando Processo4");

        }

        public static void processo5()
        {
            Console.WriteLine("Iniciando Processo5");
            Thread.Sleep(5000);
            Console.WriteLine("Finalizando Processo5");

        }

        public static void processo6()
        {
            Console.WriteLine("Iniciando Processo6");
            Thread.Sleep(1000);
            Console.WriteLine("Finalizando Processo6");

        }

        static void Main(string[] args)
        {
            DateTime inicio, fim;

            inicio = DateTime.Now;
            Parallel.Invoke(
               new Action(processo1),
               new Action(processo2),
               new Action(processo3)
            );
            processo6();
            fim = DateTime.Now;
            Console.WriteLine("Tudo encerrado após " + (fim - inicio) + " segundos.");
            Console.ReadKey();
        }
    }
}