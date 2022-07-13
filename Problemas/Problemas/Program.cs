Main();

static void Main()
{
    //Problema_01_InverterUmaString();
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


}