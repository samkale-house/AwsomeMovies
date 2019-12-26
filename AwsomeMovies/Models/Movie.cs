using System;
using System.ComponentModel.DataAnnotations;

namespace AwsomeMovies.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate{ get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }

        //added new field in model Rating..let's use code forst data migration to alter DB
        public string Rating { get; set; }
    }
}
