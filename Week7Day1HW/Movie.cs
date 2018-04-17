using System;

namespace Week7Day1HW
{
    public class Movie
    {
        public Movie() { }
        public int ID { get; set; }
        public string Title { get; set; }
        public int YearReleased { get; set; }
        public string Genre { get; set; }
        public string Tagline { get; set; }
        public decimal Rating { get; set; }
    }
}
