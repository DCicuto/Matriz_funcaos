//comento o codigo todo para estudar e não esquecer o que fiz. 
// mostro menu para o usuário escolher a operação
int opcao;
int qtdlinhas = 3, qtdcolunas = 4;
int[,] matriz1 = new int[qtdlinhas, qtdcolunas]; // Defini a primeira matriz c/ 3 linhas e 3 colunas
int[,] matriz2 = new int[qtdlinhas, qtdcolunas]; // Defini a segunda matriz c/ 3 linhas e 3 colunas

// Primeira função, a que preenche a matriz com números aleatórios entre 1 e 10
void PreencherMatriz(int[,] matriz)
{
    Random rand = new Random();
    for (int i = 0; i < matriz.GetLength(0); i++)
    {
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            matriz[i, j] = rand.Next(1, 11); // números aleatórios de 1 a 10
        }
    }
}

// segunda função p/ imprimir a matriz
void ImprimirMatriz(int[,] matriz)
{
    for (int i = 0; i < matriz.GetLength(0); i++)
    {
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            Console.Write(matriz[i, j] + "\t"); // imprime o elemento da matriz
        }
        Console.WriteLine();
    }
}
// terceira função para mostrar o menu das operações
int MostrarMenu()
{
    int opcao;
    Console.WriteLine("\n Escolha uma operação:");
    Console.WriteLine("1. Soma das Matrizes");
    Console.WriteLine("2. Subtração das Matrizes");
    Console.WriteLine("3. Multiplicação das Matrizes");
    Console.WriteLine("4. Divisão das Matrizes");
    Console.Write("Digite o número da opção desejada: ");

    opcao = int.Parse(Console.ReadLine());
    return opcao;
}

// quarta função p/ somar duas matrizes
int[,] SomarMatrizes(int[,] matriz1, int[,] matriz2)
{
    int[,] resultado = new int[qtdlinhas, qtdcolunas]; // Matriz para armazenar o resultado da soma
    for (int linha = 0; linha < resultado.GetLength(0); linha++)
    {
        for (int coluna = 0; coluna < resultado.GetLength(1); coluna++)
        {
            resultado[linha, coluna] = matriz1[linha, coluna] + matriz2[linha, coluna]; // Soma dos elementos correspondentes
        }
    }
    return resultado;
}

// quinta função p/ subtrair duas matrizes
int[,] SubtrairMatrizes(int[,] matriz1, int[,] matriz2)
{
    int[,] resultado = new int[qtdlinhas, qtdcolunas]; // matiz p/ armazenar o resultado da subtração
    for (int linha = 0; linha < resultado.GetLength(0); linha++)
    {
        for (int coluna = 0; coluna < resultado.GetLength(1); coluna++)
        {
            resultado[linha, coluna] = matriz1[linha, coluna] - matriz2[linha, coluna]; // subtração dos elementos correspondentes
        }
    }
    return resultado;
}

//sexta função p/ multiplicar duas matrizes
int[,] MultiplicarMatrizes(int[,] matriz1, int[,] matriz2)
{
    int[,] resultado = new int[qtdlinhas, qtdcolunas]; //matriz q armazena resultado da mult
    for (int linha = 0; linha < resultado.GetLength(0); linha++)
    {
        for (int coluna = 0; coluna < resultado.GetLength(1); coluna++)
        {
            for (int k = 0; k < resultado.GetLength(0); k++)
            {
                resultado[linha, coluna] += matriz1[linha, k] * matriz2[k, coluna]; //multiplicação dos elementos correspondentes
            }
        }
    }
    return resultado;
}

// setima função p/ dividir duas matrizes
int[,] DividirMatrizes(int[,] matriz1, int[,] matriz2)
{
    int[,] resultado = new int[qtdlinhas, qtdcolunas]; //matriz p/ armazenar o resultado da divi
    for (int linha = 0; linha < resultado.GetLength(0); linha++)
    {
        for (int coluna = 0; coluna < resultado.GetLength(1); coluna++)
        {
            if (matriz2[linha, coluna] != 0) //aqui verifica se o divisor ñ é zero para evitar divisão por zero
            {
                resultado[linha, coluna] = matriz1[linha, coluna] / matriz2[linha, coluna]; //divisão dos elementos correspondentes
            }
            else
            {
                Console.WriteLine("Na divisão por zero! O resultado será zero.");
            }
        }
    }
    return resultado;
}

// preenche as matrizes com números aleatórios
PreencherMatriz(matriz1);
PreencherMatriz(matriz2);

// exibe as matrizes preenchidas
Console.WriteLine("Matriz 1:");
ImprimirMatriz(matriz1);

Console.WriteLine("\nMatriz 2:");
ImprimirMatriz(matriz2);



// Realizando a operação selecionada
opcao = MostrarMenu();
switch (opcao)
{
    case 1:
        Console.WriteLine("\n Soma das Matrizes:");
        ImprimirMatriz(SomarMatrizes(matriz1, matriz2));
        break;
    case 2:
        Console.WriteLine("\n Subtração das Matrizes:");
        ImprimirMatriz(SubtrairMatrizes(matriz1, matriz2));
        break;
    case 3:
        Console.WriteLine("\n Multiplicação das Matrizes:");
        ImprimirMatriz(MultiplicarMatrizes(matriz1, matriz2));
        break;
    case 4:
        Console.WriteLine("\n Divisão das Matrizes:");
        ImprimirMatriz(DividirMatrizes(matriz1, matriz2));
        break;
    default:
        Console.WriteLine("\n Opção inválida!");
        break;
}

