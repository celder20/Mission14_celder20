using System.ComponentModel.DataAnnotations;

namespace Mission14_API.Data
{
    public class Movie
    {
        //Manually building out the model with all its data (matches up with the information already in the database)
        [Key]
        public int MovieId { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
        public string Rating { get; set; }
        public string Edited { get; set; }
        public string LentTo { get; set; }
        public string Notes { get; set; }

    }
}
