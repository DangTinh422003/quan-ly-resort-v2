using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quan_ly_resort_v2.utils
{
    internal class FormatCurrency
    {
        public static string FormatMoney(long amount)
        {
            CultureInfo cultureInfo = new CultureInfo("vi-VN");
            string formattedAmount = string.Format(cultureInfo, "{0:C0}", amount);
            return formattedAmount;
        }
    }
}
