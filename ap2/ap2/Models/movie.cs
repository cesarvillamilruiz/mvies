using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace ap2.Models
{
    public class movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [Display(Name ="ReleaseDate")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:d}",ApplyFormatInEditMode =true)]

        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }

    public class MovieDBContext : DbContext
    {
        public DbSet<movie> movies { get; set; }
    }
}