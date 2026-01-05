using System;

namespace calculadora
{
    class Program
    {
        static void Main(string [] args)
        {
            Menu();
        }

    
        static void Menu()
        {
            try
            {
                

            Console.Clear();

            Console.WriteLine("CALCULADORA");
            Console.WriteLine("--------------");

            Console.WriteLine("1 - SOMA");
            Console.WriteLine("");
            Console.WriteLine("2 - SUBSTRAÇÃO");
            Console.WriteLine("");
            Console.WriteLine("3 - MULTIPLICAÇÃO");
            Console.WriteLine("");
            Console.WriteLine("4 - DIVISÃO");
            Console.WriteLine("");
            Console.WriteLine("0 - FECHAR APLICAÇÃO");

            Console.WriteLine("------------");
            Console.WriteLine("Selecione uma opção:");

            int res;
            if(!int.TryParse(Console.ReadLine(),out res))
            {
                Console.WriteLine("Digite uma opção valída");
                Console.ReadKey();
                return;
            }
            switch (res)
            {
                case 1: Soma();break;
                case 2: Subtracacao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: break;

            }
            
            }
            catch
            {
                Menu();
            }
               

        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Segundo Valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float Resultado = v1 + v2;
            Console.WriteLine($"O resultado é {Resultado}");
            Console.ReadKey();
            Menu();

        }

        static void Subtracacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor:");
            float v1;
            if(!float.TryParse(Console.ReadLine(),out v1))
                {
                    Console.WriteLine("Digite somente números");
                    Console.ReadKey();
                    return;
                }
            Console.WriteLine("");

            Console.WriteLine("Segundo Valor:");
            float v2;
            if(!float.TryParse(Console.ReadLine(), out v2))
                {
                    Console.WriteLine("Digite somente números");
                    Console.ReadKey();
                    return;
                }

            Console.WriteLine("");

            float Resultado = v1 - v2;
            Console.WriteLine($"O Resultado é {Resultado}");
            Console.ReadKey();
            Menu();

        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor:");
            float v1;
            if(float.TryParse(Console.ReadLine(),out v1))
                {
                    Console.WriteLine("Digite somente números");
                    Console.ReadKey();
                    return;
                }
            Console.WriteLine("");

            Console.WriteLine("Segundo Valor:");
            float v2;
            if(float.TryParse(Console.ReadLine(), out v2))
                {
                    Console.WriteLine("Digite somente números");
                    Console.ReadKey();
                    return;
                }

            Console.WriteLine("");

            float Resultado = v1 * v2;
            Console.WriteLine($"O Resultado é {Resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor:");
            float v1;
            if(float.TryParse(Console.ReadLine(),out v1))
                {
                    Console.WriteLine("Digite somente números");
                    Console.ReadKey();
                    return;
                }
            Console.WriteLine("");

            Console.WriteLine("Segundo Valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.Write("");

            float Resultado = v1 / v2;
            Console.WriteLine($"O Resultado é {Resultado}");
            Console.ReadKey();
            Menu();

        }        
            
        
    }
    
}
}
