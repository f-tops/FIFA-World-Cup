using MatchesPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PodatkovniSloj.Models
{
    public class RangListaBrojPosjetitelja
    {
        public string Lokacija { get; set; }
        public int BrojPosjetitelja { get; set; }
        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }


        public static List<RangListaBrojPosjetitelja> GetRangListaBrojPosjetitelja(string stranica, string reprezentacija)
        {
            List<MatchesPage.Match> matches = APIParser.ParseMatches(stranica, reprezentacija);
            List<RangListaBrojPosjetitelja> rangListaBrojPosjetiteljas = new List<RangListaBrojPosjetitelja>();


            foreach (var match in matches)
            {
                rangListaBrojPosjetiteljas.Add(new RangListaBrojPosjetitelja
                {
                    AwayTeam = match.AwayTeam.Country.ToString(),
                    HomeTeam = match.HomeTeam.Country.ToString(),
                    BrojPosjetitelja = (int)match.Attendance.GetValueOrDefault(),
                    Lokacija = match.Location.ToString()
                });
            }
            List<RangListaBrojPosjetitelja> SortedList = rangListaBrojPosjetiteljas.OrderByDescending(o => o.BrojPosjetitelja).ToList();
            return SortedList;
            

        }
    }
}
