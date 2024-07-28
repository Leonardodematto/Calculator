using System;
using System.Collections;

namespace Calculator
{

    class Program
    {
        static void Main(string[] args)
        {

            Operacao();
        }



        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("digite o primeiro valor");
            double v1 = double.Parse(Console.ReadLine());
            Console.WriteLine("digite o segundo valor:");
            double v2 = double.Parse(Console.ReadLine());
            double resultado = v1 + v2;

            Console.WriteLine("");
            Console.WriteLine($" a soma de {v1} e {v2} é {resultado}");
            Console.ReadKey();
            Voltar();
        }
        static void Subtracao()

        {



            Console.Clear();
            Console.WriteLine("digite o primeiro valor:");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("digite o segundo valor:");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            double resultado = v1 - v2;
            Console.WriteLine($" a subtração de {v1}  e {v2} é {resultado}");
            Console.ReadKey();
            Voltar();




        }
        static void Divisao()
        {

            Console.Clear();

            Console.WriteLine("digite o primeiro valor:");
            double v1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("digite o segundo valor:");
            double v2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("");


            double resultado = v1 / v2;
            Console.WriteLine($" a divisão de {v1} e {v2} é {resultado}");
            Console.ReadKey();
            Voltar();



        }
        static void Multiplicacao()
        {

            Console.Clear();
            Console.WriteLine("digite o primeiro valor:");
            double v1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("digite o segundo valor:");
            double v2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("");

            double resultado = v1 * v2;

            Console.WriteLine($"a multiplacação de {v1}  e {v2} é {resultado}");
            Console.ReadKey();
            Voltar();


        }
        static void Operacao()
        {

            Console.Clear();

            Console.WriteLine("escolha qual operação deseja executar");
            Console.WriteLine("1 ---- Soma");
            Console.WriteLine("2 ---- Subtração");
            Console.WriteLine("3 ---- Divisão");
            Console.WriteLine("4 ---- Multiplicação");
            Console.WriteLine("-------------------");
            Console.WriteLine("Escolha a operação:");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                default:
                    Console.WriteLine("Porfavor digite somente uma das 4 alternatias");
                    Console.ReadKey();
                    Operacao(); break;


            }














        }

        static void Voltar()
        {


            //for (short voltar = 0; voltar == 7;)
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("deseja fazer novamente?");
                Console.WriteLine("--------------");
                Console.WriteLine(" se SIM digite(6) se NÃO  digite(7)");
                double voltar = short.Parse(Console.ReadLine());

                switch (voltar)
                {

                    case 6: Operacao(); break;
                    case 7:
                        Console.WriteLine("calculadora encerrada.");
                        System.Environment.Exit(0); break;




                }

            }



        }


    }
}

