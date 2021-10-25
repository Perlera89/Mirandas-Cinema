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
                            Logo = "https://i.pinimg.com/originals/3f/11/82/3f11820bf22ebb3dbc57679db3591c77.png",
                            Description = "Aqui va la descripcion del primer cine"
                        },
                        new Cinema()
                        {
                            Name = "Miranda's Gold",
                            Logo = "https://www.kindpng.com/picc/m/731-7317749_golden-cinema-logo-hd-png-download.png",
                            Description = "Aqui va la descripcion del segundo cine"
                        },
                        new Cinema()
                        {
                            Name = "Miranda's Express",
                            Logo = "https://yt3.ggpht.com/ytc/AKedOLRucw4LUwG-MRu8ndydJvXJ711Uhcf2fsId7PaQ=s900-c-k-c0x00ffffff-no-rj",
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
                            ProfilePictureURL = "http://t3.gstatic.com/licensed-image?q=tbn:ANd9GcQlgLaet3rZfarinMI9tfWymfJrhiU_apKwN7K-IX-nZDorGhE5n6qi0Y0Du0Dx"

                        },
                        new Producer()
                        {
                            FullName = "Chris Carreras",
                            Bio = "Mejor conocido como Asistente de Dirección basado en créditos en ese papel en 33 películas",
                            ProfilePictureURL = "https://images.mubicdn.net/images/cast_member/161192/cache-485869-1573127753/image-w856.jpg?size=160x"
                        },
                        new Producer()
                        {
                            FullName = "Aaron Fjellman",
                            Bio = "Aaron Fjellman es un escritor y director estadounidense. Recientemente, hizo su debut cinematográfico " +
                            "con Caged, un thriller psicológico sobre los horribles y alucinantes efectos del confinamiento solitario.",
                            ProfilePictureURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSIkljqLrJRAGcrj2Gf1zZ4hXhhtikr4yriMgmpTTc3xjpin-w0"
                        },
                        new Producer()
                        {
                            FullName = "Toño Lopez",
                            Bio = "Toño López nació en 1971 en Ourense, Galicia, España. Es director y editor, conocido por Matalobos (2009), " +
                            "4º sen ascensor (2005) y La revoltosa (2010).",
                            ProfilePictureURL = "http://t3.gstatic.com/licensed-image?q=tbn:ANd9GcQZw6BHUNY6-3pqIokXwKWpAcR7Rt8z6X5qWuqO96tn7ni9jOk4NHJBl__a3dSY"
                        },
                        new Producer()
                        {
                            FullName = "Brian Baugh",
                            Bio = "Brian Baugh es un director, guionista y productor estadounidense conocido por su compromiso de contar historias humanas " +
                            "inspiradoras y socialmente relevantes que abarcan géneros.",
                            ProfilePictureURL = "https://m.media-amazon.com/images/M/MV5BYjY0MDBjZDMtNTA2Yy00ZDA0LTk5ZmUtZTQ1OTM3OTRiYmU2XkEyXkFqcGdeQXVyMjQwMDg0Ng@@._V1_.jpg"
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
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/68/Katherine_McNamara_2014_%28cropped%29.jpg/1200px-Katherine_McNamara_2014_%28cropped%29.jpg"

                        },
                        new Actor()
                        {
                            FullName = "Timothée Chalamet",
                            Bio = "Timothée Hal Chalamet nació en Manhattan, de Nicole Flender, una corredora de bienes raíces y bailarina, y Marc Chalamet, " +
                            "un editor de UNICEF. Su madre, que es de Nueva York, es judía, de ascendencia judía rusa y judía austriaca.",
                            ProfilePictureURL = "https://th.bing.com/th/id/R.c00691ba9adbeb611b85cd2732486cdd?rik=FK6nGoEN2PlaZQ&pid=ImgRaw&r=0"
                        },
                        new Actor()
                        {
                            FullName = "Jack Dylan Grazer",
                            Bio = "Jack Dylan Grazer nació en Los Ángeles, California, de padres Angela LaFever y Gavin Grazer. Al crecer en el mundo del entretenimiento " +
                            "y sus alrededores, no pasó mucho tiempo antes de que se descubriera el talento de Jack y se le animara a intentar actuar profesionalmente.",
                            ProfilePictureURL = "https://es.web.img3.acsta.net/c_310_420/pictures/19/03/27/23/41/0862266.jpg"
                        },
                        new Actor()
                        {
                            FullName = "María Vázquez",
                            Bio = "María Vázquez nació el 19 de marzo de 1979 en Vigo, Pontevedra, España como María Rodríguez Vázquez. Es actriz, conocida por Mataharis (2007), " +
                            "Quien a hierro mata (2019) y Trote (2018).",
                            ProfilePictureURL = "http://t2.gstatic.com/licensed-image?q=tbn:ANd9GcRLL7hFMSEU0jcesd_mPQQEWL3aQDXdF3YhEkvK8tvyCOWwvIf7RCHlthdUfISO"
                        },
                        new Actor()
                        {
                            FullName = "Edi Gathegi",
                            Bio = "Edi Gathegi nació el 10 de marzo de 1979 en Nairobi, Kenia como Edi Mue Gathegi. Es actor y productor, conocido por StartUp (2016),",
                            ProfilePictureURL = "https://musicimage.xboxlive.com/catalog/video.contributor.9c1f6500-0200-11db-89ca-0019b92a3933/image?locale=es-es&target=circle"
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
                            "novelas de Frank Herbert, que ya fueron trasladadas a la gran pantalla por David Lynch en 1984.",
                            Price = 19.50,
                            ImagenURL = "https://image.tmdb.org/t/p/w185_and_h278_bestv2/ymTPj60S2T9HoQIsh4VBLu3jDM5.jpg",
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
                            ImagenURL = "https://image.tmdb.org/t/p/w185_and_h278_bestv2/9I3A0EMeRiiMdvO8I5GQa67hYUU.jpg",
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
                            "Irlanda en su semestre de universidad fuera del país. Entre ellos surge un romance inesperado.",
                            Price = 39.50,
                            ImagenURL = "https://image.tmdb.org/t/p/w185_and_h278_bestv2/9uopgvuSrjnr9LaIEXeZOjG20Es.jpg",
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
                            " a Modesto (Federico Pérez Rey), cuñado de Alicia Zamora, la empresaria que les engañó y dejó tirados. Solo hay un pequeño " +
                            "problema: Alicia no piensa pagar ni un euro por su cuñado. Sin embargo, es el propio Modesto quien urde un nuevo plan con " +
                            "el que Eduardo y Sabonis podrán salvar la bodega familiar. Estos tres cuñados lo tienen todo para fracasar, pero como diría " +
                            "Sabonis, malo será.",
                            Price = 19.50,
                            ImagenURL = "https://image.tmdb.org/t/p/w185_and_h278_bestv2/34mk9BfGmIjERETs4JLBhS6ifxr.jpg",
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
                            ImagenURL = "https://image.tmdb.org/t/p/w185_and_h278_bestv2/gkBGXYNXWhcW7VI9POpeLLNgtSd.jpg",
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
