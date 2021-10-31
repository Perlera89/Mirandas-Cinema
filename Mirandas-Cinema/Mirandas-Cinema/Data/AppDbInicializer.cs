using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Mirandas_Cinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mirandas_Cinema.Data
{
    public class AppDbInicializer
    {
        public static void Seed(IApplicationBuilder app) 
        {
            using (var serviceScope = app.ApplicationServices.CreateScope()) 
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Miranda's Home",
                            Logo = "/resources/cinemas/home.png",
                            Description = "Aqui va la descripcion del primer cine"
                        },
                        new Cinema()
                        {
                            Name = "Miranda's Gold",
                            Logo = "/resources/cinemas/gold.png",
                            Description = "Aqui va la descripcion del segundo cine"
                        },
                        new Cinema()
                        {
                            Name = "Miranda's Express",
                            Logo = "/resources/cinemas/express.png",
                            Description = "Aqui va la descripcion del tercer cine"
                        }
                        });

                    context.SaveChanges();
                }

                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Adam Tandy",
                            Bio = "es un productor y director de televisión británico, quizás más conocido por sus colaboraciones " +
                            "con Armando Iannucci. Como tal, ha trabajado en The Saturday Night Armistice, The Armando Iannucci Shows, " +
                            "Time Trumpet y The Thick of It.",
                            ProfilePictureURL = "/resources/producers/adam-tandy.jpg"

                        },
                        new Producer()
                        {
                            FullName = "Chris Carreras",
                            Bio = "Mejor conocido como Asistente de Dirección basado en créditos en ese papel en 33 películas",
                            ProfilePictureURL = "/resources/producers/chris-carreras.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Aaron Fjellman",
                            Bio = "Aaron Fjellman es un escritor y director estadounidense. Recientemente, hizo su debut cinematográfico " +
                            "con Caged, un thriller psicológico sobre los horribles y alucinantes efectos del confinamiento solitario.",
                            ProfilePictureURL = "/resources/producers/aaron-fjellman.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Toño Lopez",
                            Bio = "Toño López nació en 1971 en Ourense, Galicia, España. Es director y editor, conocido por Matalobos (2009), " +
                            "4º sen ascensor (2005) y La revoltosa (2010).",
                            ProfilePictureURL = "/resources/producers/tonio-lopez.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Brian Baugh",
                            Bio = "Brian Baugh es un director, guionista y productor estadounidense conocido por su compromiso de contar historias humanas " +
                            "inspiradoras y socialmente relevantes que abarcan géneros.",
                            ProfilePictureURL = "/resources/producers/brian-baugh.jpg"
                        }
                    });

                    context.SaveChanges();
                }

                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Katherine McNamara",
                            Bio = "Katherine McNamara, nombrada una de las 'Breakout Bunch' de Vanity Fair, es una actriz, bailarina, cantante y compositora" +
                            " consumada y acaba de recibir el premio People's Choice Award de 2018 como Mejor Actriz de Televisión Femenina por su papel principal " +
                            "de 'Clary Fray' en la serie Freeform",
                            ProfilePictureURL = "/resources/actors/katerine-mcNamara.jpg"

                        },
                        new Actor()
                        {
                            FullName = "Timothée Chalamet",
                            Bio = "Timothée Hal Chalamet nació en Manhattan, de Nicole Flender, una corredora de bienes raíces y bailarina, y Marc Chalamet, " +
                            "un editor de UNICEF. Su madre, que es de Nueva York, es judía, de ascendencia judía rusa y judía austriaca.",
                            ProfilePictureURL = "/resources/actors/timothee-chalamet.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Jack Dylan Grazer",
                            Bio = "Jack Dylan Grazer nació en Los Ángeles, California, de padres Angela LaFever y Gavin Grazer. Al crecer en el mundo del entretenimiento " +
                            "y sus alrededores, no pasó mucho tiempo antes de que se descubriera el talento de Jack y se le animara a intentar actuar profesionalmente.",
                            ProfilePictureURL = "/resources/actors/jack-dylan-grazer.jpg"
                        },
                        new Actor()
                        {
                            FullName = "María Vázquez",
                            Bio = "María Vázquez nació el 19 de marzo de 1979 en Vigo, Pontevedra, España como María Rodríguez Vázquez. Es actriz, conocida por Mataharis (2007), " +
                            "Quien a hierro mata (2019) y Trote (2018).",
                            ProfilePictureURL = "/resources/actors/maria-vasquez.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Edi Gathegi",
                            Bio = "Edi Gathegi nació el 10 de marzo de 1979 en Nairobi, Kenia como Edi Mue Gathegi. Es actor y productor, conocido por StartUp (2016),",
                            ProfilePictureURL = "/resources/actors/edi-gathegi.jpg"
                        }
                    });
                    context.SaveChanges();
                }

                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Dune",
                            Description = "El hijo de una familia noble trata de vengarse de la muerte de su padre al mismo tiempo" +
                            " que salva un planeta rico en especias que se le encomienda proteger. Nueva adaptación al cine de las " +
                            "novelas de Frank Herbert.",
                            Price = 19.50,
                            ImagenURL = "/resources/movies/dune.jpg",
                            StartDate = DateTime.Now.AddDays(-5),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 2,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Ron da Error",
                            Description = "Ambientada en un mundo donde los robots se han convertido en los mejores amigos de los niños, " +
                            "Ron’s Gone Wrong cuenta la historia de un niño de 11 años que descubre que su amigo robot no funciona del todo.",
                            Price = 29.50,
                            ImagenURL = "/resources/movies/ron-da-error.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaId = 1,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Cartoon
                        },
                        new Movie()
                        {
                            Name = "Finding You",
                            Description = "Finley, una talentosa aspirante a violinista, conoce a Beckett, una joven estrella de cine, cuando está en " +
                            "Irlanda en su semestre de universidad fuera del país. Entre ellos surge un romance inesperado. Una pelicula llena de romance.",
                            Price = 39.50,
                            ImagenURL = "/resources/movies/finding-you.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = 3,
                            ProducerId = 5,
                            MovieCategory = MovieCategory.Romance
                        },
                        new Movie()
                        {
                            Name = "Cuñados",
                            Description = "Eduardo (Miguel de Lira) y su cuñado Sabonis (Xosé A. Touriñán) acaban de meter la pata en uno" +
                            " de sus negocios y necesitan dinero. Mucho dinero. Será Sabonis quien encuentre la solución al problema secuestrando" +
                            " a Modesto (Federico Pérez Rey).",
                            Price = 19.50,
                            ImagenURL = "/resources/movies/cuniados.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaId = 2,
                            ProducerId = 4,
                            MovieCategory = MovieCategory.Comedy
                        },
                        new Movie()
                        {
                            Name = "Enjaulado",
                            Description = "Un hombre afroamericano es encarcelado y puesto en confinamiento solitario " +
                            "después de ser declarado culpable de asesinar a su esposa, ya que es perseguido por demonios " +
                            "internos y su esposa muerta, y empujado al límite por una guardia abusiva.",
                            Price = 29.50,
                            ImagenURL = "/resources/movies/enjaulado.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Horror
                        }
                    });

                    context.SaveChanges();
                }

                //Actors-Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 1
                        },

                         new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 2
                        },
                         new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 2
                        },

                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 3
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 4
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 5
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
