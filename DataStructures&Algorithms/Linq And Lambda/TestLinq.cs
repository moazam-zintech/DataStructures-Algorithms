namespace DataStructures_Algorithms.Linq_And_Lambda
{
    class Game
    {
        public int Rate { get; set; }
        public string Name { get; set; }
    }
    public class TestLinq
    {
        public static void Function()
        {
            var gameList = new List<Game>
            {
                new Game{
                    Rate=42
                    ,Name="Asif"
                },

                new Game{
                    Name="Ali",
                    Rate=43
                },

                new Game{
                    Rate=41
                    ,Name="Ahmad"
                },

                new Game{
                    Rate=44
                },

                new Game{
                    Rate=45
                },
            };
            var mostRated = gameList.Where(g => g.Rate > 41);

            foreach (Game game in mostRated)
            {
                Console.WriteLine(game.Name);
            }
        }
    }
}
