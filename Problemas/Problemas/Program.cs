using System.Text.RegularExpressions;

Main();

static void Main()
{
    //Resolver_01_InverterUmaString();
    //Resolver_02_ContarCaracteres();
    //try
    //{
    //    Resolver_03_DistanciaDeHamming();
    //}
    //catch (Exception ex)
    //{
    //    Console.WriteLine(ex.Message);
    //}
    //Resolver_04_ContasPalavras();
    //Resolver_05_ContasNumeros();
    //Exercicio_01();
    //Exercicio_03();
    //Exercicio_04();
    Exercicio_05();
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

// 02 - Conte quantas vezes se repete o "a" caractere
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
// na outra, ou o número de erros necessário para transformar uma na outra.)
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

// 04 - Contar palavras em uma string
static void Resolver_04_ContasPalavras()
{
    string text = "  um texto    tem quantas palavras      ";
    int n = 0;

    text = Regex.Replace(text, @"\s+", " "); // Aqui utilizamos a expressão regular
                                             // para substituir dois ou mais espaços por apenas um espaço
    text = text.Trim();  // Trim não altera o valor da variável text origem - É um método imutável
    var words = text.Split(" "); // Split também é um método ímutável
    n = words.Length;

    Console.WriteLine($"Números de palavras: {n}");
}

// 05 - Contas números em uma string
static void Resolver_05_ContasNumeros()
{
    string text = "an18jq???daº895,748598mAnsIIpo";
    string pattern = @"[0-9]";
    var regex = new Regex(pattern);
    int n = regex.Matches(text).Count;
    Console.WriteLine("Total de números = " + n);


    string pattern_02 = @"[a-zA-Z]";
    regex = new Regex(pattern_02);
    int l = regex.Matches(text).Count;
    Console.WriteLine("Total de letras = " + l);
}

// Praticando
static void Exercicio_01()
{
    Console.WriteLine("gorila");
    string text = "gorila";
    string result = null;

    for (int i = text.Length; i > 0; i--)
    {
        result += text[i - 1];
    }

    Console.WriteLine(result);

    Console.WriteLine();

    Console.WriteLine("gorila");
    char[] textChar = text.ToCharArray();
    Array.Reverse(textChar);
    Console.WriteLine(textChar);
}
static void Exercicio_02()
{
    string text = "Amanhã é um novo dia para vencer na vida";
    int count = 0;

    foreach (var c in text)
    {
        if (c == 'a' || c == 'A')
        {
            count++;
        }
    }
    Console.WriteLine($"Total de letras a ou A = {count}");

    char ctr = 'a';
    int n = text.Where((x) => x == ctr).Count();
    Console.WriteLine($"Total de letras a = {n}");
}
static void Exercicio_03()
{
    string text = "salvador";
    string text2 = "sauvator";
    int n = 0;

    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] != text2[i])
        {
            n++;
        }
    }
    Console.WriteLine("Números de erros: " + n);
}
static void Exercicio_04()
{
    string text = "  um texto    tem quantas palavras      ";
    int n = 0;
    string patter = @"\s+";

    text = text.Trim();
    text = Regex.Replace(text, patter, " ");
    Console.WriteLine(text);
    var words = text.Split(" ");
    n = words.Length;
    Console.WriteLine(n);
}
static void Exercicio_05()
{
    string text = "anbjk85pooasd9214AsdfsP64548";
    string patter = @"[0-9]";
    //var regex = Regex.Matches(patter, text).Count;
    var regex = new Regex(patter);
    int l = regex.Matches(text).Count;
    Console.WriteLine("Total de números : {0}", l);
}