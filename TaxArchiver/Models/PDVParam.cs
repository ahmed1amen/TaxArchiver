using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaxArchiver.Models
{
    public class PDVParam
    {
        // Token: 0x17000702 RID: 1794
        // (get) Token: 0x06001B80 RID: 7040 RVA: 0x000E8A34 File Offset: 0x000E6C34
        // (set) Token: 0x06001B81 RID: 7041 RVA: 0x000E8A3B File Offset: 0x000E6C3B
        public static int _NDecimal { get; set; }

        // Token: 0x17000703 RID: 1795
        // (get) Token: 0x06001B82 RID: 7042 RVA: 0x000E8A43 File Offset: 0x000E6C43
        // (set) Token: 0x06001B83 RID: 7043 RVA: 0x000E8A4A File Offset: 0x000E6C4A
        public static string _formatDecimal { get; set; }

        // Token: 0x06001B84 RID: 7044 RVA: 0x000E8A52 File Offset: 0x000E6C52
        public PDVParam()
        {
        }

        // Token: 0x06001B85 RID: 7045 RVA: 0x000E8A5C File Offset: 0x000E6C5C
        public PDVParam(int NDecimal)
        {
            PDVParam._NDecimal = NDecimal;
            PDVParam._formatDecimal = "{0:0.";
            for (int i = 0; i < PDVParam._NDecimal; i++)
            {
                PDVParam._formatDecimal += "0";
            }
            PDVParam._formatDecimal += "}";
        }
    }
}
