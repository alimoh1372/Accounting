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
        public static DateTime ToMiladi(this string shamsiStringDate)
        {
            int year =Convert.ToInt32( shamsiStringDate.Substring(0, 4));
            int month = Convert.ToInt32(shamsiStringDate.Substring(5, 2));
            int day = Convert.ToInt32(shamsiStringDate.Substring(8, 2));
            PersianCalendar pc = new PersianCalendar();
            DateTime dt = new DateTime(year, month, day, pc);
            return dt;
        }
        public static string DeleteSomecharFromString(this string text, char deleteChar)
        {
            return text.Replace(deleteChar.ToString(), string.Empty);
        }
    }
}
