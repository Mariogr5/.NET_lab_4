using System.ComponentModel.DataAnnotations;

namespace Ogrodnik_lab4_zad2.Components.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        [DataType(DataType.Date)]
        public DateTime? RelaseDate { get; set; }
        public float? Rate { get; set; }

        public string Url { get; set; }
    }
}
