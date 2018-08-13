using System;

namespace GameOfThronesAPI.Models.GameOfThrones
{
    // API can filter books by name, fromReleaseDate, and toReleaseDate as query params
    public class Books
    {
        public String url { get; set; }
        public String name { get; set; }
        public String isbn { get; set; }
        public String[] authors { get; set; }
        public int numberOfPages { get; set; }
        public String publisher { get; set; }
        public String country { get; set; }
        public String mediaType { get; set; }
        public String released { get; set; }
        public String[] characters { get; set; }
        public String[] povCharacters { get; set; }
    }
}
