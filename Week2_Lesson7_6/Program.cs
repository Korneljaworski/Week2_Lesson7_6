public class Program
{
    private static void Main(string[] args)
    {
        /*
            Napisz program w C#, który pobierze wzrost użytkownika i przypisze mu wymyśloną kategorię wzrostu.
            Dane testowe : 140
            Rezultat w terminalu : Jesteś krasnoludem
        */

        Console.WriteLine("Podaj ile masz wzrostu:");

        int userHeight = Int32.Parse(Console.ReadLine());

        if (userHeight >= 200)
        {
            Console.WriteLine("Jesteś żyrafą.");
        }
        else if (userHeight >= 150)
        {
            Console.WriteLine("Jesteś człowiekiem.");
        }
        else if (userHeight >= 120)
        {
            Console.WriteLine("Jesteś krasnoludem.");
        }
        else
        {
            Console.WriteLine("Jesteś karliczkiem.");
        }
    }

}
