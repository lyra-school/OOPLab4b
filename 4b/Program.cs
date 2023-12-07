namespace _4b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Team SligoRovers = new Team("Sligo Rovers");
            Team FinnHarps = new Team("Finn Harps");
            Team GalwayUnited = new Team("Galway United");
            Team DerryCity = new Team("Derry City");
            Team Dundalk = new Team("Dundalk");

            List<Team> teams = new List<Team>
            {
                SligoRovers,
                FinnHarps,
                GalwayUnited,
                DerryCity,
                Dundalk
            };

            SligoRovers.AddResult(Result.Win);
            FinnHarps.AddResult(Result.Loss);
            FinnHarps.AddResult(Result.Draw);
            GalwayUnited.AddResult(Result.Win);
            Dundalk.AddResult(Result.Loss);

            teams.Sort();
            teams.Reverse();
            Display(teams);

            SligoRovers.AddPlayer(new Player("Ed McGinty", "Goalkeeper"));
            SligoRovers.AddPlayer(new Player("John Mahon", "Defender"));
            SligoRovers.AddPlayer(new Player("Ronan Coughlan", "Forward"));

            PlayerDisplay(SligoRovers);
        }

        static void Display(List<Team> teams)
        {
            Console.WriteLine("{0,-15}{1,-7}{2,-7}{3,-7}{4,-7}{5,-7}", "NAME", "POINTS", "WINS", "DRAWS", "LOSSES", "PLAYED");

            foreach (Team team in teams)
            {
                Console.WriteLine(team.DisplayTeamTable());
            }
        }

        static void PlayerDisplay(Team team)
        {
            Console.WriteLine(team.TeamName + " Teamsheet");
            foreach(Player player in  team.Players)
            {
                Console.WriteLine(player.Name + " - " + player.Position);
            }
        }
    }
}