Main();

static void Main()
{
    //Resolver_01_InverterUmaString();
    //Resolver_02_ContarCaracteres();
    try
    {
        Resolver_03_DistanciaDeHamming();
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

// 01 - Inverta a string gorila
static void Resolver_01_InverterUmaString()
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
static void Resolver_02_ContarCaracteres()
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

// 03 - Distância de Hamming (Na teoria da informação,
// a distância de Hamming entre duas strings de mesmo comprimento
// é o número de posições nas quais elas diferem entre si.
// Vista de outra forma, ela corresponde ao menos número de
// substituições necessárias para tranformar uma string
// na outra, ou o número de erros que transforma uma na outra.)
static void Resolver_03_DistanciaDeHamming()
{
    // Para realizar este tipo de medição, contagem, as duas
    // strings precisam ter o mesmo tamanho/quantidade de caracteres
    // Então a rotina vai verificar quantas vezes é as duas strings 
    // são diferentes, quantos possíveis erros ocorrem para que 
    // as duas strings sejam completamente iguais

    string text_01 = "patinho";
    string text_02 = "patonho";

    int distance = 0;

    if (text_01.Length != text_02.Length)
    {
        throw new Exception("Tamanhos diferentes");
    }
    for (int i = 0; i < text_01.Length; i++)
    {
        if (text_01[i] != text_02[i])
        {
            distance++;
        }
    }
    Console.WriteLine("Diferença= " + distance);
}