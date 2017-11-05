using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public Movie()
        {
            DateAdded = DateTime.Now;
        }

        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        public byte GenreId { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.DateTime, ErrorMessage = "Insert a valid release date.")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }

        [Display(Name = "Number in Stock")]
        [Range(1,20)]
        public int NumberInStock { get; set; }

        [Display(Name = "Number Available")]
        [Range(1, 20)]
        public int NumberAvailable { get; set; }
    }
}