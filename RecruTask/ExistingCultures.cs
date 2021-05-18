using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruTask
{
    public class ExistingCultures
    {
        CultureInfo[] allCultures = CultureInfo.GetCultures(CultureTypes.AllCultures);
        public bool CheckIfCultureExists(string culture)
        {
            var result = false;
            foreach (var _culture in allCultures)
            {

                if (_culture.ToString().Equals(culture))
                {

                    result = true;
                }

            }
            return result;
        }
    }
}
