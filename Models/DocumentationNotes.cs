using Microsoft.AspNetCore.Html;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JokesApp.Models
{
    public class DocumentationNotes
    {







        public static string Holiday()  {
                DateTime today = DateTime.Today; // get todays date
                string holiday = today.Month.ToString(); // convert int month to string
                string currentHoliday = holiday switch
                {
                    "1" => "New Years Day",
                    "2" => "Valentines Day",
                    "3" => "St.Patrick's Day",
                    "4" => "Arbor Day",
                    "5" => "Memorial Day",
                    "6" => "Native American Day",
                    "7" => "Independence Day",
                    "8" => "Coast Guard Birthday",
                    "9" => "Labor Day",
                    "10" => "Halloween",
                    "11" => "Thanksgiving Day",
                    "12" => "Christmas Day",
                    _ => "You are living outside of the Gregorian calendar, are you an Alien ?",
                };
                return currentHoliday;
        }










    }
}
