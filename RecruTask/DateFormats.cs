using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruTask
{
    public class DateFormats
    {
        CultureInfo[] allCultures = CultureInfo.GetCultures(CultureTypes.AllCultures);

        public void ShowAllDateFormats()
        {
            
            foreach (var culture in allCultures)
            {
                Console.Write(culture+"|");
            }
        }

       
    }
}
