using System;

namespace GameOfThronesAPI.Models.GameOfThrones
{
    // API can filter Characters by name, region, words, hasWords, hasTitles, hasSeats, hasDiedOut,
    // hasAncestralWeapons as query params
    public class Houses
    {
        public String url { get; set; }
        public String name { get; set; }
        public String region { get; set; }
        public String coatOfArms { get; set; }
        public String words { get; set; }
        public String[] titles { get; set; }
        public String[] seats { get; set; }
        public String currentLord { get; set; }
        public String heir { get; set; }
        public String overlord { get; set; }
        public String founded { get; set; }
        public String founder { get; set; }
        public String diedOut { get; set; }
        public String[] ancestralWeapons { get; set; }
        public String[] cadetBranches { get; set; }
        public String[] swornMembers { get; set; }
    }
}
