using Microsoft.AspNetCore.Html;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Web;

namespace JokesApp.Models
{
    public class Joke
    {
        public int Id { get; set; } // prop tab tab to create
        public string JokeQuestion { get; set; }
        public string JokeAnswer { get; set; }
        public static string Request { get; set; }

        public Joke() // ctor tab tab to create constructor
        {

        }

        public static string CheckOperatingSystem()
        {
            string osNameAndVersion = System.Runtime.InteropServices.RuntimeInformation.OSDescription; // get info of users operating system
            if(osNameAndVersion != null)
            {
                return osNameAndVersion; // output operating system name and version
            }
            return "No Operating System Found!";
        }

        public static string CheckCurrentTime()
        {
            string currentTime = DateTime.Now.ToString("h:mm:ss tt");
            if(currentTime != null)
            {
                return currentTime;
            }
            return "You have transcended time and space";
        }

    }
}
