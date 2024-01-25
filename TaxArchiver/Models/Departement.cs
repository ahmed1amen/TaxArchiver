using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaxArchiver.Models
{
    // Token: 0x020001EB RID: 491
    public class Departement
    {
        // Token: 0x170008B7 RID: 2231
        // (get) Token: 0x0600222D RID: 8749 RVA: 0x00117FA4 File Offset: 0x001161A4
        // (set) Token: 0x0600222E RID: 8750 RVA: 0x00117FAC File Offset: 0x001161AC
        public int _id { get; set; }

        // Token: 0x0600222F RID: 8751 RVA: 0x00117FB5 File Offset: 0x001161B5
        public Departement()
        {
            this._id = 0;
        }
    }
}
