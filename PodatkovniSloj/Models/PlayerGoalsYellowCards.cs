using MatchesPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodatkovniSloj.Models
{
    public class PlayerGoalsYellowCards
    {
        public string Name { get; set; }
        public int Goals { get; set; }
        public int YellowCards { get; set; }

        public static List<PlayerGoalsYellowCards> GetPlayerGoalsYellowCards(string stranica, string reprezentacija)
        {
            List<Match> matches = APIParser.ParseMatches(stranica, reprezentacija);
            List<PlayerGoalsYellowCards> playerGoalsYellowCards = new List<PlayerGoalsYellowCards>();
            List<StartingEleven> allplayers = APIParser.GetAllPlayers();
            

            List<TeamEvent> allHomeEvents = new List<TeamEvent>();
            List<TeamEvent> allAwayEvents = new List<TeamEvent>();

            foreach (var item in matches)
            {
                allHomeEvents.AddRange(item.HomeTeamEvents);
                allAwayEvents.AddRange(item.AwayTeamEvents);
            }

            foreach (var player in allplayers)
            {
                int countGoals = 0;
                int countYellow = 0;
                foreach (var item in allHomeEvents)
                {
                    if (item.Player.Equals(player.Name) && item.TypeOfEvent.Value.Equals("Goal"))
                    {
                        countGoals = countGoals + 1;
                    }
                    if (item.Player.Equals(player.Name) && item.TypeOfEvent.Value.Equals("YellowCard"))
                    {
                        countYellow = countYellow + 1;
                    }
                }
                foreach (var item in allAwayEvents)
                {
                    if (item.Player.Equals(player.Name) && item.TypeOfEvent.Value.Equals("Goal"))
                    {
                        countGoals = countGoals + 1;
                    }
                    if (item.Player.Equals(player.Name) && item.TypeOfEvent.Value.Equals("YellowCard"))
                    {
                        countYellow = countYellow + 1;
                    }
                }




                playerGoalsYellowCards.Add(new PlayerGoalsYellowCards { Name = player.Name, Goals = countGoals, YellowCards = countYellow });
            }
            return playerGoalsYellowCards;
        }
    }
}
