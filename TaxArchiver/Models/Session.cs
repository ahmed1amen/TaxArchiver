using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaxArchiver.Models
{
    // Token: 0x02000439 RID: 1081
    internal class Session
    {
        // Token: 0x170013DF RID: 5087
        // (get) Token: 0x060048EB RID: 18667 RVA: 0x00222D39 File Offset: 0x00220F39
        // (set) Token: 0x060048EC RID: 18668 RVA: 0x00222D40 File Offset: 0x00220F40
        public static Utilisateur _utilisateur { get; set; }

        // Token: 0x060048ED RID: 18669 RVA: 0x00222D48 File Offset: 0x00220F48
        public Session()
        {
            Session._utilisateur = new Utilisateur();
        }

        // Token: 0x060048EE RID: 18670 RVA: 0x00222D5A File Offset: 0x00220F5A
        public Session(Utilisateur utilisateur, NiveauValidation niveauValidation)
        {
            Session._utilisateur = utilisateur;
        }
    }
}
