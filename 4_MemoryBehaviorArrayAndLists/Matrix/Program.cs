namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número para definir a ordem da matriz:");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++) //Um for para percorrer o número de linhas n.
            {
                Console.WriteLine("Digite três números, separados por espaço, para preencher a linha:");
                string[] values = Console.ReadLine().Split(' '); //Aqui ele recebe os dados e salva num array. Será criada uma linha da matriz a cada volta do for.

                for (int j = 0; j < n; j++) // Um segundo for para percorrer o número de colunas, nesse caso, tbm n.
                    matrix[i, j] = int.Parse(values[j]); //Aqui ele salva cada um dos dados da linha que foi salva no array 'values'. Com base no index da linha 'i' e da coluna 'j' ele armazena os valores no array multidimensional 'matrix'.

                {

                }
            }

            Console.WriteLine("Main diagonal:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(matrix[i, i] + " "); //Percorre a matriz identificando a diagonal principal (matrix[0,0], matrix [1,1], ...), a partir da quantidade de elementos existe nessa diagonal.
            }


            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Total of negative numbers: {count}");

        }
    }
}