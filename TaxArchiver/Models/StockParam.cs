using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaxArchiver.Models
{
    // Token: 0x020003A0 RID: 928
    public class StockParam
    {
        // Token: 0x170010E8 RID: 4328
        // (get) Token: 0x06003FE2 RID: 16354 RVA: 0x001F3608 File Offset: 0x001F1808
        // (set) Token: 0x06003FE3 RID: 16355 RVA: 0x001F360F File Offset: 0x001F180F
        public static Local _economatCentral { get; set; }

        // Token: 0x170010E9 RID: 4329
        // (get) Token: 0x06003FE4 RID: 16356 RVA: 0x001F3617 File Offset: 0x001F1817
        // (set) Token: 0x06003FE5 RID: 16357 RVA: 0x001F361E File Offset: 0x001F181E
        public static int _niveauValidationDemande { get; set; }

        // Token: 0x170010EA RID: 4330
        // (get) Token: 0x06003FE6 RID: 16358 RVA: 0x001F3626 File Offset: 0x001F1826
        // (set) Token: 0x06003FE7 RID: 16359 RVA: 0x001F362D File Offset: 0x001F182D
        public static int _mois { get; set; }

        // Token: 0x170010EB RID: 4331
        // (get) Token: 0x06003FE8 RID: 16360 RVA: 0x001F3635 File Offset: 0x001F1835
        // (set) Token: 0x06003FE9 RID: 16361 RVA: 0x001F363C File Offset: 0x001F183C
        public static int _annee { get; set; }

        // Token: 0x170010EC RID: 4332
        // (get) Token: 0x06003FEA RID: 16362 RVA: 0x001F3644 File Offset: 0x001F1844
        // (set) Token: 0x06003FEB RID: 16363 RVA: 0x001F364B File Offset: 0x001F184B
        public static int _NDecimal { get; set; }

        // Token: 0x170010ED RID: 4333
        // (get) Token: 0x06003FEC RID: 16364 RVA: 0x001F3653 File Offset: 0x001F1853
        // (set) Token: 0x06003FED RID: 16365 RVA: 0x001F365A File Offset: 0x001F185A
        public static string _formatDecimal { get; set; }

        // Token: 0x170010EE RID: 4334
        // (get) Token: 0x06003FEE RID: 16366 RVA: 0x001F3662 File Offset: 0x001F1862
        // (set) Token: 0x06003FEF RID: 16367 RVA: 0x001F3669 File Offset: 0x001F1869
        public static bool _numeroDemandeAchatAuto { get; set; }

        // Token: 0x170010EF RID: 4335
        // (get) Token: 0x06003FF0 RID: 16368 RVA: 0x001F3671 File Offset: 0x001F1871
        // (set) Token: 0x06003FF1 RID: 16369 RVA: 0x001F3678 File Offset: 0x001F1878
        public static bool _numeroCommandeAuto { get; set; }

        // Token: 0x170010F0 RID: 4336
        // (get) Token: 0x06003FF2 RID: 16370 RVA: 0x001F3680 File Offset: 0x001F1880
        // (set) Token: 0x06003FF3 RID: 16371 RVA: 0x001F3687 File Offset: 0x001F1887
        public static bool _inventaire { get; set; }

        // Token: 0x06003FF4 RID: 16372 RVA: 0x001F368F File Offset: 0x001F188F
        public StockParam()
        {
        }

        // Token: 0x06003FF5 RID: 16373 RVA: 0x001F3698 File Offset: 0x001F1898
        public StockParam(Local economatCentral, int mois, int annee, int niveauValidationDemande, int NDecimal, bool numeroDemandeAchatAuto, bool numeroCommandeAuto, bool inventaire)
        {
            StockParam._economatCentral = economatCentral;
            StockParam._niveauValidationDemande = niveauValidationDemande;
            StockParam._mois = mois;
            StockParam._annee = annee;
            StockParam._NDecimal = NDecimal;
            StockParam._formatDecimal = "{0:0.";
            for (int i = 0; i < StockParam._NDecimal; i++)
            {
                StockParam._formatDecimal += "0";
            }
            StockParam._formatDecimal += "}";
            StockParam._numeroDemandeAchatAuto = numeroDemandeAchatAuto;
            StockParam._numeroCommandeAuto = numeroCommandeAuto;
            StockParam._inventaire = inventaire;
        }
    }
}
