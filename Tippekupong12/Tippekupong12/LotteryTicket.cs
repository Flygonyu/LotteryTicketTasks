using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tippekupong12
{
    
    internal class LotteryTicket
    {
        private Match[] _matches;

        public LotteryTicket(int matches)
        {
            _matches = new Match[matches];
        }

        public void SaveBets()
        {
            var betsText = Console.ReadLine().ToUpper();
            var bets = betsText.Split(',');
            for (var i = 0; i < 12; i++)
            {
                _matches[i] = new Match(bets[i]);
            }
        }

        public void RunMatches()
        {
            while (true)
            {
                Console.Write("Skriv kampnr. 1-12 for scoring eller X for alle kampene er ferdige\r\nAngi kommando: ");
                var command = Console.ReadLine().ToUpper();
                if (command == "X") break;
                var matchNo = Convert.ToInt32(command);
                Console.Write($"Scoring i kamp {matchNo}. \r\nSkriv H for hjemmelag eller B for bortelag: ");
                var team = Console.ReadLine().ToUpper(); ;
                var selectedIndex = matchNo - 1;
                var selectedMatch = _matches[selectedIndex];
                selectedMatch.AddGoal(team);
                var correctCount = 0;
                for (var index = 0; index < _matches.Length; index++)
                {
                    var match = _matches[index];
                    matchNo = index + 1;
                    var isBetCorrect = match.IsBetCorrect();
                    var isBetCorrectText = isBetCorrect ? "riktig" : "feil";
                    if (isBetCorrect) correctCount++;
                    Console.WriteLine($"Kamp {matchNo}: {match.GetScore()} - {isBetCorrectText}");
                }

                Console.WriteLine($"Du har {correctCount} rette.");
            }
        }
    }
}
