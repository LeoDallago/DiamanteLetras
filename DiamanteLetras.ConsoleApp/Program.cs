namespace DiamanteLetras.ConsoleApp
{
    internal class Program
    {
        static string alphabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        static char[] alphabetoArray = alphabeto.ToCharArray();

        static bool continuar = true;

        static void Main(string[] args)
        {
            Console.WriteLine("Diamante X");

            while (continuar)
            {

                Console.WriteLine("Por favor, Informe uma LETRA MAIUSCULA");
                char tamanhoDiamante = Convert.ToChar(Console.ReadLine());

                int tamanhoNumerado = Array.IndexOf(alphabetoArray, tamanhoDiamante);

                int quantidadeDeX = 1;
                int contador = 0;


                for (int linha = 0; linha < tamanhoNumerado; linha++)
                {
                    FazLinha(tamanhoNumerado, quantidadeDeX, contador);
                    contador++;
                    quantidadeDeX += 2;

                    Console.WriteLine();

                }

                for (int linha = 0; linha < tamanhoNumerado + 1; linha++)
                {
                    FazLinha(tamanhoNumerado, quantidadeDeX, contador);
                    contador--;
                    quantidadeDeX -= 2;

                    Console.WriteLine();
                }

                Console.WriteLine("Deseja realizar outra operacao? pressione S para continuar") ;
               string opcao =  Console.ReadLine() ; 
                
                if (opcao == "S" || opcao== "s") {
                    continuar = true;
                    Console.Clear();
                }

                else { 

                    continuar = false; 
                }

            }

        }



        private static void FazLinha(int tamanhoNumerado, int quantidadeDeX, int contador)
        {
            for (int espaco = contador; espaco < tamanhoNumerado; espaco++)
            {
                Console.Write(" ");
            }



            for (int X = 0; X < quantidadeDeX; X++)
            {
                Console.Write(alphabetoArray[contador]);
            }


        }
    }
}
