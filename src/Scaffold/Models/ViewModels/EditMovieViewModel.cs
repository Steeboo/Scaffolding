using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scaffold.Models.ViewModels
{
    public class EditMovieViewModel
    {
        public Movie Movie { get; set; }

        public SelectList Genres { get; set; }
    }
}
