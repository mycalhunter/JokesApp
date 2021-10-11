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
                string currentHoliday = ""; // set current holiday variable
                var builder = new HtmlContentBuilder(); // create HtmlBuilder

                switch (holiday)
                {
                    case "1":
                        currentHoliday = "New Years Day";
                        break;
                    case "2":
                        currentHoliday = "Valentines Day";
                        break;
                    case "3":
                        currentHoliday = "St.Patrick's Day";
                        break;
                    case "4":
                        currentHoliday = "Arbor Day";
                        break;
                    case "5":
                        currentHoliday = "Memorial Day";
                        break;
                    case "6":
                        currentHoliday = "Native American Day";
                        break;
                    case "7":
                        currentHoliday = "Independence Day";
                        break;
                    case "8":
                        currentHoliday = "Coast Gaurd Birthday";
                        break;
                    case "9":
                        currentHoliday = "Labor Day";
                        break;
                    case "10":
                        currentHoliday = "Halloween";
                        break;
                    case "11":
                        currentHoliday = "Thanksgiving Day";
                        break;
                    case "12":
                        currentHoliday = "Christmas Day";
                        break;
                    default:
                        currentHoliday = "You are living outside of the Gregorian calendar, are you an Alien ?";
                        break;
                }
            return currentHoliday;
        }










    }
}
