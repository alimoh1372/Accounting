using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Accounting.Utility
{
    public static class Convertor
    {
        public static string ToShamsiDate(this DateTime MiladiDateTime)
        {
            
            PersianCalendar pc = new PersianCalendar();
            string ShamsiDate = pc.GetYear(MiladiDateTime)+"/"+pc.GetMonth(MiladiDateTime).ToString("00")+"/"+pc.GetDayOfMonth(MiladiDateTime).ToString("00");
            return ShamsiDate;
        }
        public static string DeleteSomecharFromString(this string text, char deleteChar)
        {
            return text.Replace(deleteChar.ToString(), string.Empty);
        }
    }
}
