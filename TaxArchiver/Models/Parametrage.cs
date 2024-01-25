using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaxArchiver.Models
{
    // Token: 0x0200005A RID: 90
    public class Parametrage
    {
        // Token: 0x17000159 RID: 345
        // (get) Token: 0x0600057C RID: 1404 RVA: 0x000368F2 File Offset: 0x00034AF2
        // (set) Token: 0x0600057D RID: 1405 RVA: 0x000368F9 File Offset: 0x00034AF9
        public static DateTime _date { get; set; }

        // Token: 0x1700015A RID: 346
        // (get) Token: 0x0600057E RID: 1406 RVA: 0x00036901 File Offset: 0x00034B01
        // (set) Token: 0x0600057F RID: 1407 RVA: 0x00036908 File Offset: 0x00034B08
        public static string _nom { get; set; }

        // Token: 0x1700015B RID: 347
        // (get) Token: 0x06000580 RID: 1408 RVA: 0x00036910 File Offset: 0x00034B10
        // (set) Token: 0x06000581 RID: 1409 RVA: 0x00036917 File Offset: 0x00034B17
        public static int _niveauvalidationdemandeachat { get; set; }

        // Token: 0x1700015C RID: 348
        // (get) Token: 0x06000582 RID: 1410 RVA: 0x0003691F File Offset: 0x00034B1F
        // (set) Token: 0x06000583 RID: 1411 RVA: 0x00036926 File Offset: 0x00034B26
        public static int _nombredecimalstock { get; set; }

        // Token: 0x1700015D RID: 349
        // (get) Token: 0x06000584 RID: 1412 RVA: 0x0003692E File Offset: 0x00034B2E
        // (set) Token: 0x06000585 RID: 1413 RVA: 0x00036935 File Offset: 0x00034B35
        public static bool _autonumdemandeachat { get; set; }

        // Token: 0x1700015E RID: 350
        // (get) Token: 0x06000586 RID: 1414 RVA: 0x0003693D File Offset: 0x00034B3D
        // (set) Token: 0x06000587 RID: 1415 RVA: 0x00036944 File Offset: 0x00034B44
        public static bool _autonumcommande { get; set; }

        // Token: 0x1700015F RID: 351
        // (get) Token: 0x06000588 RID: 1416 RVA: 0x0003694C File Offset: 0x00034B4C
        // (set) Token: 0x06000589 RID: 1417 RVA: 0x00036953 File Offset: 0x00034B53
        public static int _nombredecimalpdv { get; set; }

        // Token: 0x17000160 RID: 352
        // (get) Token: 0x0600058A RID: 1418 RVA: 0x0003695B File Offset: 0x00034B5B
        // (set) Token: 0x0600058B RID: 1419 RVA: 0x00036962 File Offset: 0x00034B62
        public static string _adresse { get; set; }

        // Token: 0x17000161 RID: 353
        // (get) Token: 0x0600058C RID: 1420 RVA: 0x0003696A File Offset: 0x00034B6A
        // (set) Token: 0x0600058D RID: 1421 RVA: 0x00036971 File Offset: 0x00034B71
        public static string _adresse2 { get; set; }

        // Token: 0x17000162 RID: 354
        // (get) Token: 0x0600058E RID: 1422 RVA: 0x00036979 File Offset: 0x00034B79
        // (set) Token: 0x0600058F RID: 1423 RVA: 0x00036980 File Offset: 0x00034B80
        public static bool _dallas { get; set; }

        // Token: 0x17000163 RID: 355
        // (get) Token: 0x06000590 RID: 1424 RVA: 0x00036988 File Offset: 0x00034B88
        // (set) Token: 0x06000591 RID: 1425 RVA: 0x0003698F File Offset: 0x00034B8F
        public static bool _web { get; set; }

        // Token: 0x17000164 RID: 356
        // (get) Token: 0x06000592 RID: 1426 RVA: 0x00036997 File Offset: 0x00034B97
        // (set) Token: 0x06000593 RID: 1427 RVA: 0x0003699E File Offset: 0x00034B9E
        public static string _langage { get; set; }

        // Token: 0x17000165 RID: 357
        // (get) Token: 0x06000594 RID: 1428 RVA: 0x000369A6 File Offset: 0x00034BA6
        // (set) Token: 0x06000595 RID: 1429 RVA: 0x000369AD File Offset: 0x00034BAD
        public static bool _pms { get; set; }

        // Token: 0x17000166 RID: 358
        // (get) Token: 0x06000596 RID: 1430 RVA: 0x000369B5 File Offset: 0x00034BB5
        // (set) Token: 0x06000597 RID: 1431 RVA: 0x000369BC File Offset: 0x00034BBC
        public static bool _envoiemail { get; set; }

        // Token: 0x17000167 RID: 359
        // (get) Token: 0x06000598 RID: 1432 RVA: 0x000369C4 File Offset: 0x00034BC4
        // (set) Token: 0x06000599 RID: 1433 RVA: 0x000369CB File Offset: 0x00034BCB
        public static string _emailfrom { get; set; }

        // Token: 0x17000168 RID: 360
        // (get) Token: 0x0600059A RID: 1434 RVA: 0x000369D3 File Offset: 0x00034BD3
        // (set) Token: 0x0600059B RID: 1435 RVA: 0x000369DA File Offset: 0x00034BDA
        public static string _emailto { get; set; }

        // Token: 0x17000169 RID: 361
        // (get) Token: 0x0600059C RID: 1436 RVA: 0x000369E2 File Offset: 0x00034BE2
        // (set) Token: 0x0600059D RID: 1437 RVA: 0x000369E9 File Offset: 0x00034BE9
        public static string _host { get; set; }

        // Token: 0x1700016A RID: 362
        // (get) Token: 0x0600059E RID: 1438 RVA: 0x000369F1 File Offset: 0x00034BF1
        // (set) Token: 0x0600059F RID: 1439 RVA: 0x000369F8 File Offset: 0x00034BF8
        public static int _port { get; set; }

        // Token: 0x1700016B RID: 363
        // (get) Token: 0x060005A0 RID: 1440 RVA: 0x00036A00 File Offset: 0x00034C00
        // (set) Token: 0x060005A1 RID: 1441 RVA: 0x00036A07 File Offset: 0x00034C07
        public static string _objetmail { get; set; }

        // Token: 0x1700016C RID: 364
        // (get) Token: 0x060005A2 RID: 1442 RVA: 0x00036A0F File Offset: 0x00034C0F
        // (set) Token: 0x060005A3 RID: 1443 RVA: 0x00036A16 File Offset: 0x00034C16
        public static bool _gestionCommerciale { get; set; }

        // Token: 0x1700016D RID: 365
        // (get) Token: 0x060005A4 RID: 1444 RVA: 0x00036A1E File Offset: 0x00034C1E
        // (set) Token: 0x060005A5 RID: 1445 RVA: 0x00036A25 File Offset: 0x00034C25
        public static string _typeDallas { get; set; }

        // Token: 0x1700016E RID: 366
        // (get) Token: 0x060005A6 RID: 1446 RVA: 0x00036A2D File Offset: 0x00034C2D
        // (set) Token: 0x060005A7 RID: 1447 RVA: 0x00036A34 File Offset: 0x00034C34
        public static string _logo { get; set; }

        // Token: 0x1700016F RID: 367
        // (get) Token: 0x060005A8 RID: 1448 RVA: 0x00036A3C File Offset: 0x00034C3C
        // (set) Token: 0x060005A9 RID: 1449 RVA: 0x00036A43 File Offset: 0x00034C43
        public static byte[] _logo64 { get; set; }

        // Token: 0x17000170 RID: 368
        // (get) Token: 0x060005AA RID: 1450 RVA: 0x00036A4B File Offset: 0x00034C4B
        // (set) Token: 0x060005AB RID: 1451 RVA: 0x00036A52 File Offset: 0x00034C52
        public static int _decimalpdv { get; set; }

        // Token: 0x17000171 RID: 369
        // (get) Token: 0x060005AC RID: 1452 RVA: 0x00036A5A File Offset: 0x00034C5A
        // (set) Token: 0x060005AD RID: 1453 RVA: 0x00036A61 File Offset: 0x00034C61
        public static int _decimalcontrol { get; set; }

        // Token: 0x17000172 RID: 370
        // (get) Token: 0x060005AE RID: 1454 RVA: 0x00036A69 File Offset: 0x00034C69
        // (set) Token: 0x060005AF RID: 1455 RVA: 0x00036A70 File Offset: 0x00034C70
        public static bool _blk { get; set; }

        // Token: 0x17000173 RID: 371
        // (get) Token: 0x060005B0 RID: 1456 RVA: 0x00036A78 File Offset: 0x00034C78
        // (set) Token: 0x060005B1 RID: 1457 RVA: 0x00036A7F File Offset: 0x00034C7F
        public static bool _blk1 { get; set; }

        // Token: 0x17000174 RID: 372
        // (get) Token: 0x060005B2 RID: 1458 RVA: 0x00036A87 File Offset: 0x00034C87
        // (set) Token: 0x060005B3 RID: 1459 RVA: 0x00036A8E File Offset: 0x00034C8E
        public static int _montant { get; set; }

        // Token: 0x17000175 RID: 373
        // (get) Token: 0x060005B4 RID: 1460 RVA: 0x00036A96 File Offset: 0x00034C96
        // (set) Token: 0x060005B5 RID: 1461 RVA: 0x00036A9D File Offset: 0x00034C9D
        public static int _report { get; set; }

        // Token: 0x17000176 RID: 374
        // (get) Token: 0x060005B6 RID: 1462 RVA: 0x00036AA5 File Offset: 0x00034CA5
        // (set) Token: 0x060005B7 RID: 1463 RVA: 0x00036AAC File Offset: 0x00034CAC
        public static int _marge { get; set; }

        // Token: 0x17000177 RID: 375
        // (get) Token: 0x060005B8 RID: 1464 RVA: 0x00036AB4 File Offset: 0x00034CB4
        // (set) Token: 0x060005B9 RID: 1465 RVA: 0x00036ABB File Offset: 0x00034CBB
        public static int _montantmin { get; set; }

        // Token: 0x17000178 RID: 376
        // (get) Token: 0x060005BA RID: 1466 RVA: 0x00036AC3 File Offset: 0x00034CC3
        // (set) Token: 0x060005BB RID: 1467 RVA: 0x00036ACA File Offset: 0x00034CCA
        public static string _signature { get; set; }

        // Token: 0x17000179 RID: 377
        // (get) Token: 0x060005BC RID: 1468 RVA: 0x00036AD2 File Offset: 0x00034CD2
        // (set) Token: 0x060005BD RID: 1469 RVA: 0x00036AD9 File Offset: 0x00034CD9
        public static byte[] _signature64 { get; set; }

        // Token: 0x1700017A RID: 378
        // (get) Token: 0x060005BE RID: 1470 RVA: 0x00036AE1 File Offset: 0x00034CE1
        // (set) Token: 0x060005BF RID: 1471 RVA: 0x00036AE8 File Offset: 0x00034CE8
        public static bool _cloture { get; set; }

        // Token: 0x1700017B RID: 379
        // (get) Token: 0x060005C0 RID: 1472 RVA: 0x00036AF0 File Offset: 0x00034CF0
        // (set) Token: 0x060005C1 RID: 1473 RVA: 0x00036AF7 File Offset: 0x00034CF7
        public static bool _csv { get; set; }

        // Token: 0x1700017C RID: 380
        // (get) Token: 0x060005C2 RID: 1474 RVA: 0x00036AFF File Offset: 0x00034CFF
        // (set) Token: 0x060005C3 RID: 1475 RVA: 0x00036B06 File Offset: 0x00034D06
        public static string _qrCode { get; set; }

        // Token: 0x1700017D RID: 381
        // (get) Token: 0x060005C4 RID: 1476 RVA: 0x00036B0E File Offset: 0x00034D0E
        // (set) Token: 0x060005C5 RID: 1477 RVA: 0x00036B15 File Offset: 0x00034D15
        public static byte[] _qrCode64 { get; set; }

        // Token: 0x1700017E RID: 382
        // (get) Token: 0x060005C6 RID: 1478 RVA: 0x00036B1D File Offset: 0x00034D1D
        // (set) Token: 0x060005C7 RID: 1479 RVA: 0x00036B24 File Offset: 0x00034D24
        public static string _messageQrCode { get; set; }

        // Token: 0x1700017F RID: 383
        // (get) Token: 0x060005C8 RID: 1480 RVA: 0x00036B2C File Offset: 0x00034D2C
        // (set) Token: 0x060005C9 RID: 1481 RVA: 0x00036B33 File Offset: 0x00034D33
        public static string _emailto1 { get; set; }

        // Token: 0x17000180 RID: 384
        // (get) Token: 0x060005CA RID: 1482 RVA: 0x00036B3B File Offset: 0x00034D3B
        // (set) Token: 0x060005CB RID: 1483 RVA: 0x00036B42 File Offset: 0x00034D42
        public static string _emailto2 { get; set; }

        // Token: 0x17000181 RID: 385
        // (get) Token: 0x060005CC RID: 1484 RVA: 0x00036B4A File Offset: 0x00034D4A
        // (set) Token: 0x060005CD RID: 1485 RVA: 0x00036B51 File Offset: 0x00034D51
        public static string _qrCode1 { get; set; }

        // Token: 0x17000182 RID: 386
        // (get) Token: 0x060005CE RID: 1486 RVA: 0x00036B59 File Offset: 0x00034D59
        // (set) Token: 0x060005CF RID: 1487 RVA: 0x00036B60 File Offset: 0x00034D60
        public static byte[] _qrCode641 { get; set; }

        // Token: 0x17000183 RID: 387
        // (get) Token: 0x060005D0 RID: 1488 RVA: 0x00036B68 File Offset: 0x00034D68
        // (set) Token: 0x060005D1 RID: 1489 RVA: 0x00036B6F File Offset: 0x00034D6F
        public static string _messageQrCode1 { get; set; }

        // Token: 0x060005D2 RID: 1490 RVA: 0x00036B78 File Offset: 0x00034D78
        public Parametrage()
        {
            Parametrage._date = default(DateTime);
            Parametrage._nom = "";
            Parametrage._niveauvalidationdemandeachat = 0;
            Parametrage._nombredecimalstock = 0;
            Parametrage._autonumdemandeachat = false;
            Parametrage._autonumcommande = false;
            Parametrage._nombredecimalpdv = 0;
            Parametrage._adresse = "";
            Parametrage._adresse2 = "";
            Parametrage._dallas = false;
            Parametrage._langage = "fr";
            Parametrage._web = false;
            Parametrage._pms = false;
            Parametrage._envoiemail = false;
            Parametrage._emailfrom = "";
            Parametrage._emailto = "";
            Parametrage._host = "smtp.google.com";
            Parametrage._port = 25;
            Parametrage._objetmail = "";
            Parametrage._gestionCommerciale = false;
            Parametrage._typeDallas = "1wire";
            Parametrage._logo = "";
            Parametrage._logo64 = null;
            Parametrage._decimalpdv = 2;
            Parametrage._decimalcontrol = 2;
            Parametrage._blk = false;
            Parametrage._blk1 = false;
            Parametrage._montant = 0;
            Parametrage._report = 0;
            Parametrage._marge = 0;
            Parametrage._montantmin = 0;
            Parametrage._signature = "";
            Parametrage._signature64 = null;
            Parametrage._cloture = true;
            Parametrage._csv = false;
            Parametrage._qrCode = "";
            Parametrage._qrCode64 = null;
            Parametrage._messageQrCode = "";
            Parametrage._emailto1 = "";
            Parametrage._emailto2 = "";
            Parametrage._qrCode1 = "";
            Parametrage._qrCode641 = null;
            Parametrage._messageQrCode1 = "";
        }

        // Token: 0x060005D3 RID: 1491 RVA: 0x00036CDC File Offset: 0x00034EDC
        public Parametrage(DateTime date, string nom, int niveauvalidationdemandeachat, int nombredecimalstock, bool autonumdemandeachat, bool autonumcommande, int nombredecimalpdv, string adresse, bool dallas, string langage, bool web, bool pms, bool envoiemail, string emailfrom, string emailto, string host, int port, string objetmail, bool gestionCommerciale, string typeDallas, string logo, int decimalpdv, int decimalcontrol, bool blk, bool blk1, int montant, int report, int marge, int montantmin, string signature, string adresse2, bool cloture, bool csv, string qrCode, string messageQrCode, string emailto1, string emailto2, string qrCode1, string messageQrCode1)
        {
            Parametrage._date = date;
            Parametrage._nom = nom;
            Parametrage._niveauvalidationdemandeachat = niveauvalidationdemandeachat;
            Parametrage._nombredecimalstock = nombredecimalstock;
            Parametrage._autonumdemandeachat = autonumdemandeachat;
            Parametrage._autonumcommande = autonumcommande;
            Parametrage._nombredecimalpdv = nombredecimalpdv;
            Parametrage._adresse = adresse;
            Parametrage._adresse2 = adresse2;
            Parametrage._dallas = dallas;
            Parametrage._langage = langage;
            Parametrage._web = web;
            Parametrage._pms = pms;
            Parametrage._envoiemail = envoiemail;
            Parametrage._emailfrom = emailfrom;
            Parametrage._emailto = emailto;
            Parametrage._host = host;
            Parametrage._port = port;
            Parametrage._objetmail = objetmail;
            Parametrage._gestionCommerciale = gestionCommerciale;
            Parametrage._typeDallas = typeDallas;
            Parametrage._logo = logo;
            if (Parametrage._logo.Length != 0)
            {
                Parametrage._logo64 = Convert.FromBase64String(Parametrage._logo);
            }
            Parametrage._decimalcontrol = decimalcontrol;
            Parametrage._decimalpdv = decimalpdv;
            Parametrage._blk = blk;
            Parametrage._blk1 = blk1;
            Parametrage._montant = montant;
            Parametrage._report = report;
            Parametrage._marge = marge;
            Parametrage._montantmin = montantmin;
            Parametrage._signature = signature;
            if (Parametrage._signature.Length != 0)
            {
                Parametrage._signature64 = Convert.FromBase64String(Parametrage._signature);
            }
            Parametrage._cloture = cloture;
            Parametrage._csv = csv;
            Parametrage._qrCode = qrCode;
            if (Parametrage._qrCode.Length != 0)
            {
                Parametrage._qrCode64 = Convert.FromBase64String(Parametrage._qrCode);
            }
            Parametrage._messageQrCode = messageQrCode;
            Parametrage._emailto1 = emailto1;
            Parametrage._emailto2 = emailto2;
            Parametrage._qrCode1 = qrCode1;
            if (Parametrage._qrCode1.Length != 0)
            {
                Parametrage._qrCode641 = Convert.FromBase64String(Parametrage._qrCode1);
            }
            Parametrage._messageQrCode1 = messageQrCode1;
        }
    }
}
