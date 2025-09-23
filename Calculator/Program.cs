namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string laskutoimitus = Kysylaskutoimitus();
            int luku1 = Kysyensimmainenluku();
            int luku2 = Kysytoinenluku();
            int summa = luku1 + luku2;
            int erotus = luku1 - luku2;
            int tulo = luku1 * luku2;
            int jako = luku1 / luku2;
            while (true)
            {
                if (laskutoimitus == "+")
                {
                    Console.WriteLine($"{luku1} {laskutoimitus} {luku2} = {summa}");
                    break;
                }
                else if (laskutoimitus == "-")
                {
                    Console.WriteLine($"{luku1} {laskutoimitus} {luku2} = {erotus}");
                    break;
                }
                else if (laskutoimitus == "*")
                {
                    Console.WriteLine($"{luku1} {laskutoimitus} {luku2} = {tulo}");
                    break;
                }
                else if (laskutoimitus == "/")
                {
                    Console.WriteLine($"{luku1} {laskutoimitus} {luku2} = {jako}");
                    break;
                }
            }
            
        }
        static string Kysylaskutoimitus()

        {

            while (true)
            {
                Console.Write("Valitse laskutoimitus (+, -, *, /) :");
                string? input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input) && (input == "+" || input == "-" || input == "*" || input == "/"))
                    return input.Trim();
                else
                    Console.WriteLine("Virheellinen syöte. Valitse joku seuraavista: +, -, *, /.");
            }
        }
        static int Kysyensimmainenluku()
        {

            while (true)
            {
                Console.Write("Anna ensimmäinen luku: ");
                string? input = Console.ReadLine();
                if (int.TryParse(input, out int luku1))
                    return luku1;
                else
                    Console.WriteLine("Virheellinen syöte. Anna jokin numero.");
            }

        }
        static int Kysytoinenluku()
        {

            while (true)
            {
                Console.Write("Anna toinen luku: ");
                string? input = Console.ReadLine();
                if (int.TryParse(input, out int luku2))
                    return luku2;
                else
                    Console.WriteLine("Virheellinen syöte. Anna jokin numero.");
            }
        }









    }
}

