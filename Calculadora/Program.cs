internal class Program
{
    private static void Main(string[] args)
    {
        bool status = false;
        while (!status)
        {
            Console.WriteLine(Calculadora());
            Console.WriteLine("Do You Want to calculate more? y/n");
            string userInput = Console.ReadLine();
            if (userInput == "n") {
                status = false;
                break;
            }
        }
    }

    public static int Calculadora()

    {
        Console.WriteLine("Please write a number");
        string InputUser1 = Console.ReadLine();
        Console.WriteLine("Please write a second number");
        string InputUser2 = Console.ReadLine();

        int num1 = int.Parse(InputUser1);
        int num2 = int.Parse(InputUser2);

        Console.WriteLine("Please select what do you want to do: +. -, *, /");
        string InputUser3 = Console.ReadLine();

        if (InputUser3 == "+")
        {
            return num1 + num2;
        }
        else if (InputUser3 == "-")
        {
            return num1 - num2;
        }
        else if (InputUser3 == "*")
        {
            return num1 * num2;
        }
        else if (InputUser3 == "/")
        {
            return num1 / num2;
        }
        else
        {
            throw new("You can´t do that");
        }
    }
}