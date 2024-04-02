namespace ATV5_CJ3022528
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ex;
            Console.WriteLine("Escolha um exercício: ");
            Console.WriteLine("Digite 1 para 01");
            Console.WriteLine("Digite 2 para 02");
            Console.WriteLine("Digite 3 para 03");
            Console.WriteLine("Digite 4 para 04");
            Console.WriteLine("Digite 5 para 05");
            Console.WriteLine("Digite 6 para 06");
            Console.WriteLine("Digite 7 para 07");
            ex = int.Parse(Console.ReadLine());

            switch (ex)
            {
                case 1:
                    int n, contador = 0;

                    Console.WriteLine("Digite um número: ");
                    n = int.Parse(Console.ReadLine());

                    for (contador = 0; contador <= n; contador++)
                        Console.WriteLine(contador);
                    contador++;
                    break;
                case 2:
                    int n1, contado = 0;

                    Console.WriteLine("Digite um número: ");
                    n1 = int.Parse(Console.ReadLine());

                    for (contado = 0; contado <= n1; contado++)
                    {
                        Console.WriteLine(contado);
                        contado++;
                    }
                    break;
                case 3:
                    int n2, contad = 1000;

                    Console.WriteLine("Digite um número menor que 1000: ");
                    n2 = int.Parse(Console.ReadLine());

                    for (contad = 1000; contad <= n2; contad--)
                    {
                        Console.WriteLine(contad);
                        contad--;
                    }

                    break;
                case 4:
                    int n4, positivos = 0;

                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine("Digite um número: ");
                        n4 = int.Parse(Console.ReadLine());

                        if (n4 > 0)
                        {
                            positivos += n4;
                            Console.WriteLine(n4);
                        }

                        if (positivos >= 200)
                            break;
                    }

                    if (positivos < 200)
                        Console.WriteLine("A soma dos números positivos é menor que 200.");
                    break;

                case 5:
                    int n5;
                    Console.WriteLine("Digite um número inteiro: ");
                    n5 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Divisores de ", n5, ":");

                    for (int i = 1; i <= n5; i++)
                    {
                        if (n5 % i == 0)
                        {
                            Console.WriteLine(i + " ");
                        }
                    }
                    Console.ReadLine();


                    break;


            }







        }
    }
}


