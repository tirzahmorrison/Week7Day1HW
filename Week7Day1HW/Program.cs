using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace Week7Day1HW
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new DataBaseContext())
            {
                var movie = new Movie
                {
                    Title = "The Never Ending Story",
                    YearReleased = 1988,
                    Genre = "Horror",
                    Tagline = "Said your mom",
                    Rating = 9.8m,
                };
                db.Movies.Add(movie);
                db.SaveChanges();
                var movies = db.Movies.Where(m => m.YearReleased == 1988);
                foreach (var m in movies)
                {
                    m.Rating = 10m;
                }
                db.SaveChanges();
                var horror = db.Movies.Where(h => h.Genre == "Horror");
                var bestMovieInTheWorld = db.Movies.First(n => n.Title == "The Never Ending Story");
                db.Movies.Remove(bestMovieInTheWorld);
                db.SaveChanges();
            }
            Console.WriteLine("Hi, I'm watching you");
            Console.ReadLine();
        }
    }
}
