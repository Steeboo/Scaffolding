﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Scaffold.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        
        public int GenreID { get; set; }
        public Genre Genre { get; set; }
        public decimal Price { get; set; } 
    }    

    public class Genre
    {
        public int ID { get; set; }

        public string Name { get; set; }
    }
}
