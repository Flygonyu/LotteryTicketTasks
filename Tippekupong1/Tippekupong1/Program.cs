namespace Tippekupong1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Match match1 = new Match(true);

            match1.ShowMenu();

            while (match1.MatchIsRunning)
            {  
                Console.Write("Kommandoer: \r\n - H = scoring hjemmelag\r\n - B = scoring bortelag\r\n - X = kampen er ferdig\r\nAngi kommando: ");
                var command = Console.ReadLine().ToUpper();
                match1.ScoreGoal(command);
            }
            match1.PayOut();
        }
    }
}