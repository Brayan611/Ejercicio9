internal class Program
{
    private static void Main(string[] args)
    {
        int entrada = 0;
        while (entrada != 5)
        {
            Console.WriteLine("Introduzca:\n1 para sumar\n2 para multiplicar\n3 para dividir\n4 para restar\n5 para salir del programa");
            while (!int.TryParse(Console.ReadLine(), out entrada) || entrada < 0 || entrada > 5)
                Console.Write("Valor introducido incorrecto\nPor favor introduzca un valor entre 1 y 4: ");
            if (entrada == 1)
            {

            }
            if (entrada == 2)
            {

            }
            if (entrada == 3)
            {

            }
            if (entrada == 4)
            {

            }
        }
        
    }
}