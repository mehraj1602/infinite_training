using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week8_CodingTest_Part2.Models;

namespace Week8_CodingTest_Part2.Repository
{
    internal interface IMovieRepository
    {
        IEnumerable<Movies> GetAll();
        Movies GetById(int id);
        void Add(Movies movie);
        void Update(Movies movie);
        void Delete(int id);
        IEnumerable<Movies> GetByYear(int year);
        IEnumerable<Movies> GetByDirector(string director);
    }
}
