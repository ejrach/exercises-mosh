using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
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

		public int? Id { get; set; }

		[Required]
		[StringLength(255)]
		public string Name { get; set; }

		[Display(Name = "Genre")]
		[Required]
		public byte? GenreId { get; set; }

		[Display(Name = "Release Date")]
		[Required]
		public DateTime? ReleaseDate { get; set; }

		[Display(Name = "Number in Stock")]
		[Range(1, 20)]
		[Required]
		public byte? NumberInStock { get; set; }

		public string Title
		{
			get
			{
				return Id != 0 ? "Edit Movie" : "New Movie";
			}
		}

		public MovieFormViewModel()
		{
			Id = 0;
		}

		public MovieFormViewModel(Movie movie)
		{
			Id = movie.Id;
			Name = movie.Name;
			ReleaseDate = movie.ReleaseDate;
			NumberInStock = movie.NumberInStock;
			GenreId = movie.GenreId;
		}
	}
}