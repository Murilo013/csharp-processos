using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Primos
{
    class Program
    {
        private static int total = 0;


        public static bool isPrimo(int x)
        {
            int f = x/2 + 1;
            for (int i=2;i<f;++i)
                if (x%i == 0) return false;
            return true;
        }

        public static void processo(int comeco,int final)
        {
            DateTime inicio, fim;
            inicio = DateTime.Now;
            int k = 0;
            for (int i = comeco; i < final; ++i)
                if (isPrimo(i))
                {
                    k++;
                }
            fim = DateTime.Now;

            Console.WriteLine("Foram encontrados " + k + " numeros primos.");
            Console.WriteLine("Tempo = " + (fim - inicio));
            Console.ReadKey();

        }

        static void Main(string[] args)
        {
            int a = 1;
            int b = 3000;
            for (int i = 0; i < 100; ++i)
            {
                Thread mythread = new Thread(() => processo(a,b));
                mythread.Start();
                a = b+1;
                b = b + 3000;
            }
            //Thread mythread1 = new Thread(() => processo(1,210000));
            //Thread mythread2 = new Thread(() => processo(210001, 300000));
            //mythread1.Start();
            //mythread2.Start();
        }
    }
}
