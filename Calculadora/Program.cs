class Program
{
    static void Main()
    {
        Console.WriteLine("Calculadora");
        Console.Write($"Digite um valor: ");
        float n1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Agora digite +(soma), -(subtração), /(divisão) ou *(multiplicação) para continuarmos: ");
        string op = Console.ReadLine();
        if (op == "+")
        {
            Console.Write("Digite outro valor: ");
            float n2 = float.Parse(Console.ReadLine());
            double r = n1 + n2;
            Console.WriteLine($"A soma entre os valores {n1} e {n2} é igual a: {Math.Round(r,2)}");
        }
        if (op == "-")
        {
            Console.Write("Digite outro valor: ");
            float n2 = float.Parse(Console.ReadLine());
            double r = n1 - n2;
            Console.WriteLine($"A subtração entre os valores {n1} e {n2} é igual a: {r}");
        }
        if (op == "/")
        {
            Console.Write("Digite outro valor: ");
            float n2 = float.Parse(Console.ReadLine());
            double r = n1 / n2;
            Console.WriteLine($"A divisão entre os valores {n1} e {n2} é igual a: {r}");
        }
        if (op == "*")
        {
            Console.Write("Digite outro valor: ");
            float n2 = float.Parse(Console.ReadLine());
            double r = n1 * n2;
            Console.WriteLine($"A multiplicação entre os valores {n1} e {n2} é igual a: {r}");
        }
        Console.WriteLine("Deseja repetir o programa?(Responda com s(sim) ou n(não)): ");
        string Sn = Console.ReadLine();
        if (Sn == "s") 
        {
            Main();
        }
        else
        {

        }
    }
}