using System.Text.RegularExpressions;

namespace Tippekupong12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LotteryTicket twelveMatches = new LotteryTicket(12);

            Console.Write("Gyldig tips: \r\n - H, U, B\r\n - halvgardering: HU, HB, UB\r\n - helgardering: HUB\r\nSkriv inn dine 12 tips med komma mellom: ");
            twelveMatches.SaveBets();
            twelveMatches.RunMatches();
        }
    }
}