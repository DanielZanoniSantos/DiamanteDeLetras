Console.Write("Digite uma letra: ");
string letra = (Console.ReadLine());

string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
int posicao = alfabeto.IndexOf(letra);
letra = Convert.ToString(alfabeto[posicao]);

int divisoria = posicao - 1;
int espaco = 0;

//parte superior
for (int i = 0; i <= posicao; i++)
{
    Console.Write(" ");
}
Console.Write(alfabeto[0]);
Console.WriteLine();

for (int i = 0; i <= posicao-1; i++)
{
    for(int j = 0; j <= divisoria; j++)
    {
        Console.Write(" ");
    }
    for(int k = 0; k <= 1; k++)
    {
        Console.Write(alfabeto[i+1]);
        for (int l = 0; l <= espaco; l++)
        {
            Console.Write(" ");
        }
    }
    Console.WriteLine();
    divisoria--;
    espaco = espaco + 2;
}

//parte inferior
for (int i = posicao - 1; i >= 1; i--)
{
    for (int j = 0; j >= divisoria; j--)
    {
        Console.Write(" ");
    }
    for (int k = 0; k <= 1; k++)
    {
        Console.Write(alfabeto[i]);
        for (int l = 0; l < espaco - 3; l++)
        {
            Console.Write(" ");
        }
    }
    Console.WriteLine();
    divisoria--;
    espaco = espaco - 2;
}
for (int i = 0; i <= posicao; i++)
{
    Console.Write(" ");
}
Console.Write(alfabeto[0]);