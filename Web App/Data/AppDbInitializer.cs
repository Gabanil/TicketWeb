using Microsoft.EntityFrameworkCore;
using Web_App.Data;

namespace Web_App.Models
{
    public static class AppDbInitializer
    {
        //seeding database
        public static void Seed(IServiceProvider serviceProvider)
        {            
            using (var context = new AppDbContext(serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
            {

                context.Database.EnsureCreated();

                //cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Cinema 1",
                            Logo = "https://media.istockphoto.com/id/1453036806/vector/cinema-logo.jpg?s=612x612&w=0&k=20&c=SZD5H9xFrZ362AGUkYfvNG4Dkd6iBpW7XI8vZ-3wU0k=",
                            Description = "This is a description of cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 2",
                            Logo = "https://media.istockphoto.com/id/1453036806/vector/cinema-logo.jpg?s=612x612&w=0&k=20&c=SZD5H9xFrZ362AGUkYfvNG4Dkd6iBpW7XI8vZ-3wU0k=",
                            Description = "This is a description of cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 3",
                            Logo = "https://media.istockphoto.com/id/1453036806/vector/cinema-logo.jpg?s=612x612&w=0&k=20&c=SZD5H9xFrZ362AGUkYfvNG4Dkd6iBpW7XI8vZ-3wU0k=",
                            Description = "This is a description of cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 4",
                            Logo = "https://media.istockphoto.com/id/1453036806/vector/cinema-logo.jpg?s=612x612&w=0&k=20&c=SZD5H9xFrZ362AGUkYfvNG4Dkd6iBpW7XI8vZ-3wU0k=",
                            Description = "This is a description of cinema"
                        }
                    });
                    context.SaveChanges();
                }

                //actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Actor 1",
                            Bio = "This is bio of actor",
                            ProfilePictureURL = "https://i.pinimg.com/originals/dd/2c/a3/dd2ca3352dcbd2de03d86d67cb0fbffb.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 2",
                            Bio = "This is bio of actor",
                            ProfilePictureURL = "https://lichnosti.net/photos/657/main.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 3",
                            Bio = "This is bio of actor",
                            ProfilePictureURL = "https://focus.ua/static/storage/thumbs/920x465/8/66/845400e7-242a60e3c4a86a21f398ec3885167668.jpg?v=8474_1"

                        },
                        new Actor()
                        {
                            FullName = "Actor 4",
                            Bio = "This is bio of actor",
                            ProfilePictureURL = "https://i.pinimg.com/originals/dd/2c/a3/dd2ca3352dcbd2de03d86d67cb0fbffb.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 5",
                            Bio = "This is bio of actor",
                            ProfilePictureURL = "https://i.pinimg.com/originals/dd/2c/a3/dd2ca3352dcbd2de03d86d67cb0fbffb.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 6",
                            Bio = "This is bio of actor",
                            ProfilePictureURL = "https://i.pinimg.com/originals/dd/2c/a3/dd2ca3352dcbd2de03d86d67cb0fbffb.jpg"
                        },
                    });
                    context.SaveChanges();
                }

                //producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Prod 1",
                            Bio = "This is bio of producer",
                            ProfilePictureURL = "https://i.pinimg.com/originals/dd/2c/a3/dd2ca3352dcbd2de03d86d67cb0fbffb.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Prod 2",
                            Bio = "This is bio of producer",
                            ProfilePictureURL = "https://lichnosti.net/photos/657/main.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Prod 3",
                            Bio = "This is bio of producer",
                            ProfilePictureURL = "https://focus.ua/static/storage/thumbs/920x465/8/66/845400e7-242a60e3c4a86a21f398ec3885167668.jpg?v=8474_1"
                        },
                    });
                    context.SaveChanges();
                }

                //movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Transformers",
                            Description = "This is a desc of movie",
                            Price = 120,
                            imageURL = "https://assets-prd.ignimgs.com/2023/04/27/transformers-rise-of-the-beast-new-button-1682603563738.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "True Detective",
                            Description = "This is a desc of series",
                            Price = 100,
                            imageURL = "https://m.media-amazon.com/images/M/MV5BMmRlYmE0Y2UtNDk2Yi00NzczLWEwZTEtZmE2OTcyYzcxYmU5XkEyXkFqcGdeQXVyNTMxMjgxMzA@._V1_FMjpg_UX1000_.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = 2,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Thriller
                        },
                        new Movie()
                        {
                            Name = "Dallas Buyers Club",
                            Description = "This is a desc of movie",
                            Price = 120,
                            imageURL = "https://d1hwmph06ue357.cloudfront.net/new_test/wp-content/uploads/2018/12/img-keyart-dallas-buyers-club.png",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaId = 3,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "Film 4",
                            Description = "This is a desc of series",
                            Price = 100,
                            imageURL = "https://m.media-amazon.com/images/M/MV5BMmRlYmE0Y2UtNDk2Yi00NzczLWEwZTEtZmE2OTcyYzcxYmU5XkEyXkFqcGdeQXVyNTMxMjgxMzA@._V1_FMjpg_UX1000_.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Thriller
                        },
                        new Movie()
                        {
                            Name = "Film 5",
                            Description = "This is a desc of series",
                            Price = 100,
                            imageURL = "https://m.media-amazon.com/images/M/MV5BMmRlYmE0Y2UtNDk2Yi00NzczLWEwZTEtZmE2OTcyYzcxYmU5XkEyXkFqcGdeQXVyNTMxMjgxMzA@._V1_FMjpg_UX1000_.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Thriller
                        },
                        new Movie()
                        {
                            Name = "Film 6",
                            Description = "This is a desc of series",
                            Price = 100,
                            imageURL = "https://m.media-amazon.com/images/M/MV5BMmRlYmE0Y2UtNDk2Yi00NzczLWEwZTEtZmE2OTcyYzcxYmU5XkEyXkFqcGdeQXVyNTMxMjgxMzA@._V1_FMjpg_UX1000_.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Thriller
                        },
                        new Movie()
                        {
                            Name = "Film 7",
                            Description = "This is a desc of series",
                            Price = 100,
                            imageURL = "https://m.media-amazon.com/images/M/MV5BMmRlYmE0Y2UtNDk2Yi00NzczLWEwZTEtZmE2OTcyYzcxYmU5XkEyXkFqcGdeQXVyNTMxMjgxMzA@._V1_FMjpg_UX1000_.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Thriller
                        },
                    });
                    context.SaveChanges();
                }

                //actors & movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 1,
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 1,
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 1,
                        },
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 2,
                        },new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 2,
                        },new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 2,
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
