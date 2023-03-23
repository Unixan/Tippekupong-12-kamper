namespace Tippekupong_12_kamper
{
    internal class Program
    {
        public static string[] betsList;
        static void Main()
        {
            while (betsList == null || betsList.Length != 12)
            {
                Console.Write(
                    "Gyldig tips: \r\n - H, U, B\r\n - halvgardering: HU, HB, UB\r\n - helgardering: HUB\r\nSkriv inn dine 12 tips med komma mellom: ");
                var bets = Console.ReadLine();
                betsList = bets.Replace(" ", "").Split(',');
                if (betsList.Length != 12)
                {
                    Console.WriteLine("Må ha 12 tips");
                }
            }
            Console.Clear();
            var matchlist = new Matches();
            for (var i = 0; i < betsList.Length; i++)
            {
                matchlist.AddMatch(new Match(betsList[i]));
            }
            matchlist.PlayMatches();
            matchlist.ShowResults();
            Console.WriteLine($"Du tippet riktig på {matchlist.FinalResult()} kamper");
        }
    }
}