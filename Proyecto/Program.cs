internal class Program
{
    private static void Main()
    {
        Console.WriteLine("Hello, World!");
    }

    private static double Leer(string msg)
    {
        double num;
        do
        {
            Console.Clear();
            Console.Write(msg);
        } while (double.TryParse(Console.ReadLine(), out num));
        return num;
    }

    private static void Sumar()
    {
        double num1, num2;
        num1 = Leer("\n\n\tIntroduce el primer sumando: ");
        num2 = Leer("\n\n\tIntroduce el segundo sumando: ");
        Console.WriteLine($"La suma de {num1} y {num2} es: {num1 + num2}");
    }

    private static void Mult()
    {
        double num1, num2;
        num1 = Leer("\n\n\tIntroduce el primer factor: ");
        num2 = Leer("\n\n\tIntroduce el segundo factor: ");
        Console.WriteLine($"La suma de {num1} y {num2} es: {num1 * num2}");
    }

    private static void Div()
    {
        double num1, num2;
        num1 = Leer("\n\n\tIntroduce el dividendo: ");
        num2 = Leer("\n\n\tIntroduce el divisor: ");
        Console.WriteLine($"La suma de {num1} y {num2} es: {num1 / num2}");
    }

    private static void restar()
    {
        double num1, num2;
        num1 = Leer("\n\n\tIntroduce el minuendo: ");
        num2 = Leer("\n\n\tIntroduce el sustraendo: ");
        Console.WriteLine($"La suma de {num1} y {num2} es: {num1 - num2}");
    }
}