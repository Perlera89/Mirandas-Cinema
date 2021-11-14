using Mirandas_Cinema.Data.Base;
using Mirandas_Cinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mirandas_Cinema.Data.Services
{
    public interface IMovies
    {
        Task<IEnumerable<Movie>> GetAll();
        Task<Movie> GetById(int id);
        Task Add(Movie entity);
        Task Update(int id, Movie entity);
        Task Delete(int id);
        Task Search(Movie entity);

        //listas para los combobox
        Task<List<Cinema>> ListOfCinema();
        Task<List<Producer>> ListOfProducer();
    }
}
