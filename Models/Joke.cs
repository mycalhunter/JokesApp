using Microsoft.AspNetCore.Html;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Web;
using System.Threading.Tasks;

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

            bool osWindows = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(OSPlatform.Windows); // if OS is Windows
            bool osLinux = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(OSPlatform.Linux); // if OS is Linux
            bool osOSX = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(OSPlatform.OSX); // if OS is Mac OSX

            if (osNameAndVersion != null)
            {
                return osNameAndVersion; // output operating system name and version
            }
            return "No Operating System Found!";
        }

        public static string CheckCurrentTime()
        {
            string currentTime = DateTime.Now.ToString("h:mm tt");
            if(currentTime != null)
            {
                return currentTime;
            }
            return "You have transcended time and space";
        }


        





    }
}
