using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

namespace TaxArchiver.Functions
{
    public class Converting
    {
        // Token: 0x060048B0 RID: 18608 RVA: 0x002228C1 File Offset: 0x00220AC1
        public Converting()
        {
        }

        // Token: 0x060048B1 RID: 18609 RVA: 0x002228C9 File Offset: 0x00220AC9
        public Converting(string formatDecimal)
        {
            Converting._formatDecimal = formatDecimal;
        }

        // Token: 0x060048B2 RID: 18610 RVA: 0x002228D7 File Offset: 0x00220AD7
        public static string decimalToString(decimal _decimal)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-FR");
            return string.Format(Converting._formatDecimal, _decimal.ToString(CultureInfo.InvariantCulture));
        }

        // Token: 0x060048B3 RID: 18611 RVA: 0x00222904 File Offset: 0x00220B04
        public static string doubleToString(double _double)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-FR");
            return string.Format(Converting._formatDecimal, new decimal(Convert.ToDouble(_double)).ToString(CultureInfo.InvariantCulture));
        }

        // Token: 0x060048B4 RID: 18612 RVA: 0x00222948 File Offset: 0x00220B48
        public static string valueToString(string _value)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-FR");
            return string.Format(Converting._formatDecimal, new decimal(Convert.ToDouble(_value.ToString().Trim())).ToString(CultureInfo.InvariantCulture));
        }

        // Token: 0x060048B5 RID: 18613 RVA: 0x00222995 File Offset: 0x00220B95
        public string stringToCurentFormat(string _value, string formatDecimal, int nDecimal)
        {
            return string.Format(formatDecimal, Math.Round(new decimal(Convert.ToDouble(_value)), nDecimal));
        }

        // Token: 0x04002C34 RID: 11316
        private static string _formatDecimal;
    }
}
