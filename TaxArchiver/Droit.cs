using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaxArchiver
{
    // Token: 0x02000463 RID: 1123
    public class Droit
    {
        // Token: 0x170014DD RID: 5341
        // (get) Token: 0x06004BF1 RID: 19441 RVA: 0x0022FD80 File Offset: 0x0022DF80
        // (set) Token: 0x06004BF2 RID: 19442 RVA: 0x0022FD88 File Offset: 0x0022DF88
        public int _id { get; set; }

        // Token: 0x170014DE RID: 5342
        // (get) Token: 0x06004BF3 RID: 19443 RVA: 0x0022FD91 File Offset: 0x0022DF91
        // (set) Token: 0x06004BF4 RID: 19444 RVA: 0x0022FD99 File Offset: 0x0022DF99
        public ListDroit _listDroit { get; set; }

        // Token: 0x170014DF RID: 5343
        // (get) Token: 0x06004BF5 RID: 19445 RVA: 0x0022FDA2 File Offset: 0x0022DFA2
        // (set) Token: 0x06004BF6 RID: 19446 RVA: 0x0022FDAA File Offset: 0x0022DFAA
        public bool _droit { get; set; }

        // Token: 0x06004BF7 RID: 19447 RVA: 0x0022FDB3 File Offset: 0x0022DFB3
        public Droit()
        {
            this._id = 0;
            this._listDroit = new ListDroit();
            this._droit = false;
        }

        // Token: 0x06004BF8 RID: 19448 RVA: 0x0022FDD4 File Offset: 0x0022DFD4
        public Droit(int id, ListDroit listDroit, bool droit)
        {
            this._id = id;
            this._listDroit = listDroit;
            this._droit = droit;
        }
    }
}
