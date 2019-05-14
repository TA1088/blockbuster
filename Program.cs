using System;
using System.Collections.Generic;

namespace Blockbuster
{
    class Program
    {
        static void Main(string[] args)
        {
           var hp1 = new Movie(){
               Title = "Harry Potter and the Sorcereesrews Stone"
           };
           var hp11 = new Movie(){
               Title = "Harry Potter and the Sorcereesrews Stone"
           };

           var x = hp1 == hp1 11;


           var hollywoodVideo = new Store();
           hollywoodVideo.Name = "Hollywood Vidoe";
           hollywoodVideo.Address = "123 N. Dunder Street";
           hollywoodVideo.AvailableMovies = new List<Movie>();
           hollywoodVideo.RentedMovies = new List<Movie>();
           hollywoodVideo.ShowGreeting();

        }
    }
}
