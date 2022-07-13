Main();

static void Main()
{
    //Problema_01_InverterUmaString();
    Problema_02_ContarCaracteres();
}

// 01 - Inverta a string gorila
static void Problema_01_InverterUmaString()
{
    string text = "gorila"; // Observe que temos uma string contendo 5 elementos de caractere em 5 índices (0 a 5)
    //             012345
    string result;

    Console.WriteLine(text);

    for (int i = text.Length; i > 0; i--)
    {
        result = text[i - 1].ToString();
        Console.Write(result);
    }

    Console.WriteLine("\n");

    // Alternativa para a solução do problema
    char[] chars = text.ToCharArray();

    Array.Reverse(chars);

    result = new string(chars);

    Console.WriteLine(result);
}

// 02 - Conte quantas vezes se repete um "a" caractere
static void Problema_02_ContarCaracteres()
{
    string text = "iausioAAduhsdjqaaaadssdsSJIOadLkkkkass295sdaa4d";
    char caracter = 'a';
    int counter = 0;

    for (int i = text.Length; i > 0; i--)
    {
        if (text[i - 1] == caracter)
        {
            counter++;
        }
    }
    Console.WriteLine($"Exite {counter} vezes o caractere 'a' na string.");

    Console.WriteLine();
    // Caso considerar A e a, podemos:
    caracter = 'A';
    counter = 0;
    text = text.ToUpper();
    for (int i = text.Length; i > 0; i--)
    {
        if (text[i - 1] == caracter)
        {
            counter++;
        }
    }
    Console.WriteLine($"Exite {counter} vezes o caractere 'a' na string.");

    Console.WriteLine();
    // Alternativa para resolução do problema
    counter = 0;
    foreach (var c in text)
    {
        if (c == caracter)
        {
            counter++;
        }
    }
    Console.WriteLine($"Exite {counter} vezes o caractere 'a' na string.");

    Console.WriteLine();
    // Alternativa para resolução do problema
    int n = text.Where(c => c == caracter).Count();  // Utilizando o método Where de Link
    Console.WriteLine($"Exite {n} vezes o caractere 'a' na string.");
}