
using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero A");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero B");
            int b = int.Parse(Console.ReadLine());

            int medAri = 0;
            int vt = 0;

            if (a >= 0) {
                if (b >= 0)
                {
                    if (a < b)
                    {
                        
                        for (int i = a; i <= b; i++)
                        {
                            if (i % 2 == 0)
                            {
                                Console.WriteLine("");
                            }
                            else
                            {
                                vt = vt + i;
                            }
                        }
                            Console.WriteLine("o valor total é"+ vt);
                    }
                    if (a > b)
                    {
                        for(int i = a; i <= b; i++)
                        {
                            if(i % 3 == 0)
                            {
                                medAri = medAri + i;
                                
                            }
                        }
                        Console.WriteLine("A media é: " + medAri);
                    }
                }
            }
        }
    }
}