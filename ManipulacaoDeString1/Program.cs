using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        string nome, nome2, troca, mudar, mudar2, resu;
        int contador = 0;
        int contador2 = 0;
        int resultado, resultado2;

        Console.Write("Informe o nome: ");
        nome = Console.ReadLine();

        Console.WriteLine("\nForam informados {0} caracteres.", nome.Length);

        resultado = Vogais(nome);
        resultado2 = Consoantes(nome);
        mudar = Mudarstring(nome);

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

        int Consoantes(string nome)
        {
            

            for (int i = 0;i < nome.Length;i++)
            {
                char[] r = new char[nome.Length];
                if (nome[i] != 'a' && nome[i] != 'e' && nome[i] != 'i'
                && nome[i] != 'o' && nome[i] != 'u')
                {
                    r[i] = nome[i];
                }
                if (char.IsLetter(r[i]))
                {
                    contador2++;
                }
            }
            return contador2;
        }

        string Mudarstring(string nome)
        {
            troca = new string(nome.Reverse().ToArray());
            return troca;
        }

        Console.WriteLine("A string possui {0} vogais.", resultado);
        Console.WriteLine("A string possui {0} consoantes.", resultado2);
        Console.WriteLine("String ao contrário: {0}", mudar);

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