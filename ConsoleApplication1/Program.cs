using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int voto = 0;
            Console.WriteLine("ciao a tutti");
            Console.WriteLine("inserisci un numero");
            N = Convert.ToInt32(Console.ReadLine());
            int[] migni = new int[N];
            for (int i = 0; i < migni.Length; i++)
            {
                Console.WriteLine("inserisci il {0}° voto", i + 1);
                migni[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }
            for (int i=0;i<N; i++)
            {
                Console.WriteLine("il {0}° elemeento dell'Aarray è {1}", i + 1, migni[i]);
                Console.WriteLine();
            }
            int ctr = 0;
            Console.WriteLine("che voto vuoi cercare?");
            voto = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < migni.Length; i++)
            {
                if (voto == migni[i])
                {
                    ctr = ctr + 1;
                }
            }
            Console.WriteLine(" ho trovato il numero {0} tot volte nella posizione {1}",voto, ctr);
            Console.ReadLine();
        }
    }
}
