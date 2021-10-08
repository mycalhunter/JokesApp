using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace JokesApp.Models
{
    public class Joke
    {

        public int Id { get; set; } // prop tab tab to create
        public string JokeQuestion { get; set; }
        public string JokeAnswer { get; set; }
        public Joke() // ctor tab tab to create constructor
        {

        }
    }
}
