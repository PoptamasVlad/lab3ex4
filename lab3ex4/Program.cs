using System;

namespace lab3ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Se citeste de la tastatura un vector continant n numere intregi, n fiind si el citit la randul sau citit de la tastatura. 
             Scrieti functii care vor returna
            • Cel mai mare numar din vector
            • Cel mai mic numar din vector
            • Numerele divizibile cu 3
            • Numerele prime din vector
            Apelati functiile si afisati-le rezultatele. */

            int n = int.Parse(Console.ReadLine());
            int[] vector = new int[n];
            for(int i = 0; i<n; i++)
            {
                vector[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Cel mai mare numar este " + Maxim(n, vector));
            Console.WriteLine("Cel mai mic numar este " + Minim(n, vector));
            Console.WriteLine("Numerele divizibile cu 3 sunt: " + string.Join(" ", Div3(n, vector)));
            Console.WriteLine("Numerele prime sunt: " + string.Join(" ", NrPrime(n, vector)));


            static int Maxim(int n, int[] vector)
            {
                int maxim = vector[0];
                for (int i = 1; i < n; i++)
                {
                    if (vector[i] > maxim)
                    {
                        maxim = vector[i];
                    }
                }
                return maxim;
            }

            static int Minim(int n, int[] vector)
            {
                int minim = vector[0];
                for(int i = 1; i<n; i++)
                {
                    if(vector[i] < minim)
                    {
                        minim = vector[i];
                    }
                }
                return minim;
            }

            static int[] Div3(int n, int[] vector)
            {
                int div = 0, lungime = 0;
                int i;

                for(i = 0; i < n; i++)
                {
                    if (vector[i] % 3 == 0)
                    {
                        lungime++;
                    }
                }

                int[] vector2 = new int[lungime];

                for (i = 0; i< n; i++)
                {
                    if(vector[i] % 3 == 0)
                    {
                        vector2[div] = vector[i];
                        div++;
                    }
                }

                return vector2;
            }

            static int[] NrPrime(int n, int[] vector)
            {
                int prim = 0, lungime =0;
                int i;

                for (i = 0; i < n; i++)
                {
                    if (NumarPrim(vector[i]))
                    {
                        lungime++;
                    }
                }

                int[] vector2 = new int[lungime];

                for(i = 0; i < n; i++)
                {
                    if(NumarPrim(vector[i]))
                    {
                        vector2[prim] = vector[i]; 
                        prim++;
                    }
                }
                return vector2;

            }

            static bool NumarPrim(int n)
            {
                int nrDiv = 0;
                for(int i = 1; i<=n; i++)
                {
                    if(n % i == 0)
                    {
                        nrDiv++;
                    }
                }
                if(nrDiv == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }


        }
    }
}
