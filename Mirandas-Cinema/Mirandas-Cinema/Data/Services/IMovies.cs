using Mirandas_Cinema.Data.Base;
using Mirandas_Cinema.Data.ViewModels;
using Mirandas_Cinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mirandas_Cinema.Data.Services
{
    public interface IMovies : IEntityBase<Movie>
    {
        Task<Movie> GetMovieById(int id);
        Task<DropDownListVM> GetMovieDropDown();
        Task AddMovie(MovieVM data);
        Task UpdateMovie(MovieVM data);
    }
}
