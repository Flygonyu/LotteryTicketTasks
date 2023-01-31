using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tippekupong1
{
    internal class Match
    {
        private int _homeGoals;
        private int _awayGoals;
        public bool MatchIsRunning { get; private set; }
        private string _bet;

        public Match(bool matchIsRunning)
        {
            MatchIsRunning = matchIsRunning;
        }

        public void ShowMenu()
        {
            Console.Write("Gyldig tips: \r\n - H, U, B\r\n - halvgardering: HU, HB, UB\r\n - helgardering: HUB\r\nHva har du tippet for denne kampen? ");
            var bet = Console.ReadLine().ToUpper();
            AcceptBet(bet);
            Console.WriteLine();
        }

        private void AcceptBet(string command)
        {
            _bet = command;
        }

        public void ScoreGoal(string command)
        {
            if (command == "H") _homeGoals++;
            else if (command == "B") _awayGoals++;
            Console.WriteLine($"---Stillingen er {_homeGoals}-{_awayGoals}---");
            Console.WriteLine();
            CheckIfMatchIsRunning(command);
        }

        public void PayOut()
        {
            var result = _homeGoals == _awayGoals ? "U" : _homeGoals > _awayGoals ? "H" : "B";
            var isBetCorrect = _bet.Contains(result);
            var isBetCorrectText = isBetCorrect ? "riktig" : "feil";
            Console.WriteLine($"Du tippet {isBetCorrectText}.");
        }

        private void CheckIfMatchIsRunning(string command)
        {
            if (command == "X") MatchIsRunning = false;
        }
    }
}
