using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tippekupong12
{
    internal class Match
    {
        private string _bet;
        private int _homeGoals;
        private int _awayGoals;

        public Match(string bet)
        {
            _bet = bet;
        }

        public void AddGoal(string team)
        {
            if (team == "H") _homeGoals++;
            else _awayGoals++;
        }

        public string GetScore()
        {
            return $"---Stillingen er {_homeGoals}-{_awayGoals}---";
        }

        public bool IsBetCorrect()
        {
            var result = _homeGoals == _awayGoals ? "U" : _homeGoals > _awayGoals ? "H" : "B";
            if (_bet.Contains(result)) return true;
            else return false;
        }
    }
}
