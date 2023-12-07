namespace _4b
{
    public enum Result { Win, Draw, Loss }
    public class Team : IComparable<Team>
    {
        private string _teamName;
        private int _wins;
        private int _draws;
        private int _losses;
        private int _games;
        private List<Player> _players = new List<Player>();

        public string TeamName
        {
            get { return _teamName; }
            private set { _teamName = value; }
        }

        public int Wins
        {
            get { return _wins; }
            private set { _wins = value; }
        }

        public int Draws
        {
            get { return _draws; }
            private set { _draws = value; }
        }

        public int Losses
        {
            get { return _losses; }
            private set { _losses = value; }
        }
        public int Games
        {
            get { return _games; }
            private set { _games = value; }
        }

        public int Points
        {
            get
            {
                return (_wins * 3) + _draws;
            }
        }

        public List<Player> Players
        {
            get { return _players; }
        }

        public Team(string teamName)
        {
            TeamName = teamName;
        }

        public string DisplayTeamTable()
        {
            return string.Format($"{TeamName, -15}{Points, -7}{Wins,-7}{Draws,-7}{Losses,-7}{Games,-7}");
        }

        public void AddResult(Result result)
        {
            if(result == Result.Win)
            {
                Wins++;
                Games++;
            }
            if(result == Result.Draw)
            {
                Draws++;
                Games++;
            }
            if(result == Result.Loss)
            {
                Losses++;
                Games++;
            }
        }

        public int CompareTo(Team other)
        {
            if (other == null) return 1;

            return Points.CompareTo(other.Points);
        }

        public static bool operator >(Team a, Team b)
        {
            return a.CompareTo(b) > 0;
        }
        public static bool operator <(Team a, Team b)
        {
            return a.CompareTo(b) < 0;
        }
        public static bool operator >=(Team a, Team b)
        {
            return a.CompareTo(b) >= 0;
        }
        public static bool operator <=(Team a, Team b)
        {
            return a.CompareTo(b) <= 0;
        }

        public void AddPlayer(Player player)
        {
            _players.Add(player);
        }
    }
}