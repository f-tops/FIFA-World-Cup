using MatchesPage;
using TeamsPage;
using System;
using System.Collections.Generic;
using System.Net;
using PodatkovniSloj.Models;
using System.Linq;

namespace PodatkovniSloj
{
    public class APIParser
    {

        private const string MEN_MATCHES = "http://world-cup-json-2018.herokuapp.com/matches/country?fifa_code=";
        private const string WOMEN_MATCHES = "http://worldcup.sfg.io/matches/country?fifa_code=";
        public static List<Match> ParseMatches(string stranica, string reprezentacija)
        {
            List<Match> matches = new List<Match>();
            try
            {
                using (WebClient wc = new WebClient())
                {
                    var json = wc.DownloadString($"{stranica}{reprezentacija}");
                    matches = Match.FromJson(json);
                    

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return matches;
        }


        public static List<TeamsPage.Team> ParseTeams(string stranica)
        {
            List<TeamsPage.Team> teams = new List<TeamsPage.Team>();
            try
            {
                using (WebClient wc = new WebClient())
                {
                    var json = wc.DownloadString($"{stranica}");
                    teams = TeamsPage.Team.FromJson(json);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return teams;
        }

        public static List<StartingEleven> GetAllPlayers()
        {
            List<StartingEleven> allplayers = new List<StartingEleven>();
            FillPlayersAndFavourite(allplayers, true);
            FillPlayersAndFavourite(allplayers, false);
            return allplayers;
        }

        public static Dictionary<string, string> GetSuprotniTeams(string code)
        {
            List<Match> matches = ParseMatches(GetPage(), code);
            Dictionary<string, string> teams = new Dictionary<string, string>();
            foreach (var item in matches)
            {
                if (item.HomeTeam.Code.Equals(code))
                {
                    teams.Add(item.AwayTeamCountry.ToString(), item.AwayTeam.Code.ToString());
                }
                else if (item.AwayTeam.Code.Equals(code))
                {
                    teams.Add(item.HomeTeamCountry.ToString(), item.HomeTeam.Code.ToString());
                }
            }
            return teams;
        }

        public static Match getSpecificMatch(string timA, string timB)
        {
            List<Match> allmatches = ParseMatches(GetPage(), timA);
            Match match = new Match();
            foreach (var item in allmatches)
            {
                if(item.AwayTeam.Code.Equals(timA) && item.HomeTeam.Code.Equals(timB))
                {
                    match = item;
                }else if (item.AwayTeam.Code.Equals(timB) && item.HomeTeam.Code.Equals(timA))
                {
                    match = item;
                }

            }
            return match;
        }

        public static Dictionary<string, string> GetDictionaryTeams(List<TeamsPage.Team> teams)
        {
            Dictionary<string, string> teams2 = new Dictionary<string, string>();
            foreach (var item in teams)
            {
                teams2.Add(item.Country.ToString(), item.FifaCode.ToString());
            }
            return teams2;
        }

        public static void FillPlayersAndFavourite(List<StartingEleven> allPlayers, bool favourite)
        {
            Match matchOne = ParseMatches(GetPage(), GetCode()).FirstOrDefault();
            if (CheckIfHome(GetCode(), matchOne))
            {
                foreach (MatchesPage.StartingEleven player in matchOne.HomeTeamStatistics.StartingEleven)
                {
                    if ((player.Favourite == favourite) || (player.Favourite.HasValue == favourite))
                    {
                        allPlayers.Add(player);
                    }

                }
                foreach (MatchesPage.StartingEleven player in matchOne.HomeTeamStatistics.Substitutes)
                {
                    if ((player.Favourite == favourite) || (player.Favourite.HasValue == favourite))
                    {
                        allPlayers.Add(player);
                    }

                }
            }
            else
            {
                foreach (MatchesPage.StartingEleven player in matchOne.AwayTeamStatistics.StartingEleven)
                {
                    if ((player.Favourite == favourite) || (player.Favourite.HasValue == favourite))
                    {
                        allPlayers.Add(player);
                    }

                }
                foreach (MatchesPage.StartingEleven player in matchOne.AwayTeamStatistics.Substitutes)
                {
                    if ((player.Favourite == favourite) || (player.Favourite.HasValue == favourite))
                    {
                        allPlayers.Add(player);
                    }

                }
            }
        }

        public static bool CheckIfHome(string code, MatchesPage.Match match)
        {
            try
            {
                if (match.HomeTeam.Code.Equals(code))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return false;
            }

        }

        public static string GetCode()
        {
            return Repo.GetStringLineFromFile(3, FilePath.Path);
        }

        public static string GetPage()
        {
            if (Repo.GetStringLineFromFile(1, FilePath.Path).Equals("Žensko"))
            {
                return WOMEN_MATCHES;
            }
            else
            {
                return MEN_MATCHES;
            }
        }

    }
}
