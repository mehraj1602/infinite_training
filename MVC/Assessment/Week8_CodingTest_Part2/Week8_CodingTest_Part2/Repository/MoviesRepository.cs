using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Week8_CodingTest_Part2.Models;

namespace Week8_CodingTest_Part2.Repository
{
  
        public class MovieRepository : IMovieRepository
        {
            MoviesDbContext db = new MoviesDbContext();

            public IEnumerable<Movies> GetAll() => db.Movie.ToList();

            public Movies GetById(int id) => db.Movie.Find(id);

            public void Add(Movies movie)
            {
                db.Movie.Add(movie);
                db.SaveChanges();
            }

            public void Update(Movies movie)
            {
                db.Entry(movie).State = EntityState.Modified;
                db.SaveChanges();
            }

            public void Delete(int id)
            {
                var movie = db.Movie.Find(id);
                db.Movie.Remove(movie);
                db.SaveChanges();
            }

            public IEnumerable<Movies> GetByYear(int year)
            {
                return db.Movie
                         .Where(m => m.DateofRelease.Year == year)
                         .ToList();
            }

            public IEnumerable<Movies> GetByDirector(string director)
            {
                return db.Movie
                         .Where(m => m.DirectorName == director)
                         .ToList();
            }
        }
    }
