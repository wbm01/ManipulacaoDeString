using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        string nome, nome2;
        int contador = 0;
        int resultado;

        Console.Write("Informe o nome: ");
        nome = Console.ReadLine();

        Console.WriteLine("\nForam informados {0} caracteres.", nome.Length);

        resultado = Vogais(nome);

        int Vogais(string nome)
        {

            for (int i = 0; i < nome.Length; i++)
            {
                if (nome[i] == 'a' || nome[i] == 'e' || nome[i] == 'i'
                    || nome[i] == 'o' || nome[i] == 'u')
                {
                    contador++;
                }
            }
            return contador;
        }

        Console.WriteLine("A string possui {0} vogais.", resultado);


        Console.Write("\nInforme o nome 2: ");
        nome2 = Console.ReadLine();

            bool resultante = nome.Equals(nome2);

            if (resultante == true)
            {
                Console.WriteLine("As strings são iguais!");
            }
            else
            {
                Console.WriteLine("As strings não são iguais!");
            }
        }
    }