using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
	//In this view model, encapsulating all of the data required for 
	//displaying data within the Movie form.
	//This ViewModel needs to exist in order to pass a view object within MoviesController
	//Using ViewModels allows us to obtain and display data from multiple models
	public class MovieFormViewModel
	{        
		//List of genre types for the dropdown list
		public IEnumerable<Genre> Genres { get; set; }

		//Let's reuse the Movie model
		public Movie Movie { get; set; }

		public string Title
		{
			get
			{
				if (Movie != null && Movie.Id != 0)
					return "Edit Movie";
				return "New Movie";
			}
		}
	}
}