using System;

namespace GameOfThronesAPI.Models.GameOfThrones
{
    // API can filter Characters by name, gender, culture, born, died, isAlive as query params
    public class Characters
    {
        public String url { get; set; }
        public String name { get; set; }
        public String gender { get; set; }
        public String culture { get; set; }
        public String born { get; set; }
        public String died { get; set; }
        public String[] titles { get; set; }
        public String[] aliases { get; set; }
        public String father { get; set; }
        public String mother { get; set; }
        public String spouse { get; set; }
        public String[] allegiances { get; set; }
        public String[] books { get; set; }
        public String[] povBooks { get; set; }
        public String[] tvSeries { get; set; }
        public String[] playedBy { get; set; }
    }
}
