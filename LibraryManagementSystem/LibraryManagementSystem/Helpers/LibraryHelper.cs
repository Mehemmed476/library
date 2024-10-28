using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.ExtendedProperties;
using DocumentFormat.OpenXml.Office.CustomUI;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Helpers
{
    public static class LibraryHelper
    {
        public static void CalculateAge(this LibraryItem obj)
        {
            int age = DateTime.Now.Year
                      - obj.PublicationYear.Year;
        }

        public static void ToTitleCase(this LibraryItem obj)
        {
            string strTitle = obj.Title;
            StringBuilder result = new StringBuilder();

            result.Append(char.ToUpper(strTitle[0]));
            result.Append(strTitle.Substring(1, strTitle.Length - 1).ToLower());
            
            obj.Title = result.ToString();
        }
    }
}
