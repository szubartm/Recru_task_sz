using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruTask
{
    public class DateCultureFormat
    {
        ExistingCultures existingCultures = new ExistingCultures();
      
        DateTimeFormatInfo cultureFormatInfo = CultureInfo.CurrentCulture.DateTimeFormat;
        Messenger messenger = new Messenger();
    
        
        public DateTimeFormatInfo DateFormatInfo(string result)
        {
            
                
                if(existingCultures.CheckIfCultureExists(result))
                {
                    return cultureFormatInfo = CultureInfo.CreateSpecificCulture(result).DateTimeFormat;
                    
                }
                else
                {
                    Console.WriteLine( messenger.MessageIncorrectDateFormat());
                    return cultureFormatInfo;
                }
               
            
          
        }
       
    }
}
