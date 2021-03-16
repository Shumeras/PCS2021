using System;
using System.Collections.Generic;
using System.Linq;
using EFMSQLDemo.Model;
using Microsoft.EntityFrameworkCore;

namespace EFMSQLDemo
{
    class Program
    {
        static private List<int> some;

        static void Main(string[] args)
        {
            using var context = new sakilaContext();

            var actors = context.Actors
                .Include(a => a.FilmActors)
                .Where(a => a.FilmActors.Count>35)
                .ToList();


            foreach(var a in actors)
            {
                System.Console.WriteLine($"{a.ActorId}. \t{a.LastName}, {a.FirstName};\t Acted in {a.FilmActors.Count} movies;");
                // var target =
                //     from actor in actors
                //     where actor.FilmActors.Count > 35
                //     select actor.FilmActors.Last();


                //context.FilmActors.Remove(a.FilmActors.LastOrDefault());

            }

            // context.Actors.Add( new Actor(){
            //     FirstName = "Jonas", LastName = "Jonaitis" 
            // });

            var j = context.Actors.FirstOrDefault((a) => a.FirstName == "Jonas");
            j.LastName="Petraitis";

            System.Console.WriteLine($"{j.ActorId}. \t{j.LastName}, {j.FirstName};\t Acted in {j.FilmActors.Count} movies;");

            context.SaveChanges();
        }
    }
}
