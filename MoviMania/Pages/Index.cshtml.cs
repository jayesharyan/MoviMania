using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace MoviMania.Pages
{
    public class IndexModel : PageModel
    {
        // Define a list of movies with properties like Title, PosterUrl, and Description
        public List<Movie> Movies { get; set; }

        public void OnGet()
        {
            // Populate the Movies list with real movie data
            Movies = new List<Movie>
            {
                new Movie { Title = "The Shawshank Redemption", PosterUrl = "https://via.placeholder.com/200x300", Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency." },
                new Movie { Title = "The Godfather", PosterUrl = "https://via.placeholder.com/200x300", Description = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son." },
                new Movie { Title = "The Dark Knight", PosterUrl = "https://via.placeholder.com/200x300", Description = "When the menace known as The Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham." },
                new Movie { Title = "Schindler's List", PosterUrl = "https://via.placeholder.com/200x300", Description = "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis." },
                new Movie { Title = "Pulp Fiction", PosterUrl = "https://via.placeholder.com/200x300", Description = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption." },
                new Movie { Title = "Forrest Gump", PosterUrl = "https://via.placeholder.com/200x300", Description = "The presidencies of Kennedy and Johnson, the Vietnam War, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an IQ of 75, whose only desire is to be reunited with his childhood sweetheart." },
                new Movie { Title = "The Matrix", PosterUrl = "https://via.placeholder.com/200x300", Description = "A computer hacker learns from mysterious rebels about the true nature of his reality and his role in the war against its controllers." },
                new Movie { Title = "Goodfellas", PosterUrl = "https://via.placeholder.com/200x300", Description = "The story of Henry Hill and his life in the mob, covering his relationship with his wife Karen Hill and his mob partners Jimmy Conway and Tommy DeVito in the Italian-American crime syndicate." },
                new Movie { Title = "The Lord of the Rings: The Fellowship of the Ring", PosterUrl = "https://via.placeholder.com/200x300", Description = "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron." },
                new Movie { Title = "Fight Club", PosterUrl = "https://via.placeholder.com/200x300", Description = "An insomniac office worker and a devil-may-care soap maker form an underground fight club that evolves into much more." },
            };
        }
    }

    // Define a Movie class
    public class Movie
    {
        public string Title { get; set; }
        public string PosterUrl { get; set; }
        public string Description { get; set; }
    }
}
