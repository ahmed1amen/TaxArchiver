using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaxArchiver.Models
{
    // Token: 0x020002A2 RID: 674
    internal class ControleParam
    {
        // Token: 0x17000BDF RID: 3039
        // (get) Token: 0x06002F16 RID: 12054 RVA: 0x001725EE File Offset: 0x001707EE
        // (set) Token: 0x06002F17 RID: 12055 RVA: 0x001725F5 File Offset: 0x001707F5
        public static int _NDecimal { get; set; }

        // Token: 0x17000BE0 RID: 3040
        // (get) Token: 0x06002F18 RID: 12056 RVA: 0x001725FD File Offset: 0x001707FD
        // (set) Token: 0x06002F19 RID: 12057 RVA: 0x00172604 File Offset: 0x00170804
        public static string _formatDecimal { get; set; }

        // Token: 0x06002F1A RID: 12058 RVA: 0x0017260C File Offset: 0x0017080C
        public ControleParam()
        {
            ControleParam._formatDecimal = "{0:0.";
            for (int i = 0; i < 2; i++)
            {
                ControleParam._formatDecimal += "0";
            }
            ControleParam._formatDecimal += "}";
        }

        // Token: 0x06002F1B RID: 12059 RVA: 0x00172660 File Offset: 0x00170860
        public ControleParam(int NDecimal)
        {
            ControleParam._NDecimal = NDecimal;
            ControleParam._formatDecimal = "{0:0.";
            for (int i = 0; i < ControleParam._NDecimal; i++)
            {
                ControleParam._formatDecimal += "0";
            }
            ControleParam._formatDecimal += "}";
        }
    }
}
