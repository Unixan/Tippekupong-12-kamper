namespace Tippekupong_12_kamper
{
    internal class Matches
    {
        private List<Match> _matches;
        private int _wins;
        public Matches()
        {
            _matches = new List<Match>();
        }
        public void AddMatch(Match match)
        {
            _matches.Add(match);
        }
        public void PlayMatches()
        {
            foreach (var match in _matches)
            {
                match.Play();
            }
        }
        public void ShowResults()
        {
            for (var i = 0; i < _matches.Count; i++)
            {
                var matchNo = i + 1;
                var match = _matches[i];
                var won = match.RightBet() ? "vant" : "tapte";
                Console.WriteLine($"Score for kamp nr {matchNo} ble {match.Score()}\nDu {won}\n");
                if (match.RightBet()) _wins++;
            }
        }
        public string FinalResult()
        {
            if (_wins == 0)
            {
                return "ingen";
            }
            return _wins.ToString();
        }
    }
}
