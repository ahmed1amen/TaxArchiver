using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaxArchiver.Models {
    // Token: 0x0200013C RID: 316
    public class Service
    {
        // Token: 0x1700058F RID: 1423
        // (get) Token: 0x060015D7 RID: 5591 RVA: 0x000BAA9D File Offset: 0x000B8C9D
        // (set) Token: 0x060015D8 RID: 5592 RVA: 0x000BAAA5 File Offset: 0x000B8CA5
        public int _id { get; set; }

        // Token: 0x17000590 RID: 1424
        // (get) Token: 0x060015D9 RID: 5593 RVA: 0x000BAAAE File Offset: 0x000B8CAE
        // (set) Token: 0x060015DA RID: 5594 RVA: 0x000BAAB6 File Offset: 0x000B8CB6
        public string _libelle { get; set; }

        // Token: 0x17000591 RID: 1425
        // (get) Token: 0x060015DB RID: 5595 RVA: 0x000BAABF File Offset: 0x000B8CBF
        // (set) Token: 0x060015DC RID: 5596 RVA: 0x000BAAC7 File Offset: 0x000B8CC7
        public bool _ouvert { get; set; }

        // Token: 0x17000592 RID: 1426
        // (get) Token: 0x060015DD RID: 5597 RVA: 0x000BAAD0 File Offset: 0x000B8CD0
        // (set) Token: 0x060015DE RID: 5598 RVA: 0x000BAAD8 File Offset: 0x000B8CD8
        public DateTime _dateOuverture { get; set; }

        // Token: 0x17000593 RID: 1427
        // (get) Token: 0x060015DF RID: 5599 RVA: 0x000BAAE1 File Offset: 0x000B8CE1
        // (set) Token: 0x060015E0 RID: 5600 RVA: 0x000BAAE9 File Offset: 0x000B8CE9
        public Departement _departementNourriture { get; set; }

        // Token: 0x17000594 RID: 1428
        // (get) Token: 0x060015E1 RID: 5601 RVA: 0x000BAAF2 File Offset: 0x000B8CF2
        // (set) Token: 0x060015E2 RID: 5602 RVA: 0x000BAAFA File Offset: 0x000B8CFA
        public Departement _departementBoisson { get; set; }

        // Token: 0x17000595 RID: 1429
        // (get) Token: 0x060015E3 RID: 5603 RVA: 0x000BAB03 File Offset: 0x000B8D03
        // (set) Token: 0x060015E4 RID: 5604 RVA: 0x000BAB0B File Offset: 0x000B8D0B
        public Departement _departementDiver { get; set; }

        // Token: 0x17000596 RID: 1430
        // (get) Token: 0x060015E5 RID: 5605 RVA: 0x000BAB14 File Offset: 0x000B8D14
        // (set) Token: 0x060015E6 RID: 5606 RVA: 0x000BAB1C File Offset: 0x000B8D1C
        public PointDeVente _pointDeVente { get; set; }

        // Token: 0x17000597 RID: 1431
        // (get) Token: 0x060015E7 RID: 5607 RVA: 0x000BAB25 File Offset: 0x000B8D25
        // (set) Token: 0x060015E8 RID: 5608 RVA: 0x000BAB2D File Offset: 0x000B8D2D
        public bool _imprimerCommande { get; set; }

        // Token: 0x17000598 RID: 1432
        // (get) Token: 0x060015E9 RID: 5609 RVA: 0x000BAB36 File Offset: 0x000B8D36
        // (set) Token: 0x060015EA RID: 5610 RVA: 0x000BAB3E File Offset: 0x000B8D3E
        public Imprimante _imprimante { get; set; }

        // Token: 0x17000599 RID: 1433
        // (get) Token: 0x060015EB RID: 5611 RVA: 0x000BAB47 File Offset: 0x000B8D47
        // (set) Token: 0x060015EC RID: 5612 RVA: 0x000BAB4F File Offset: 0x000B8D4F
        public bool _imprimerCommandeNourriture { get; set; }

        // Token: 0x1700059A RID: 1434
        // (get) Token: 0x060015ED RID: 5613 RVA: 0x000BAB58 File Offset: 0x000B8D58
        // (set) Token: 0x060015EE RID: 5614 RVA: 0x000BAB60 File Offset: 0x000B8D60
        public Imprimante _imprimante2 { get; set; }

        // Token: 0x1700059B RID: 1435
        // (get) Token: 0x060015EF RID: 5615 RVA: 0x000BAB69 File Offset: 0x000B8D69
        // (set) Token: 0x060015F0 RID: 5616 RVA: 0x000BAB71 File Offset: 0x000B8D71
        public bool _etat { get; set; }

        // Token: 0x060015F1 RID: 5617 RVA: 0x000BAB7C File Offset: 0x000B8D7C
        public Service()
        {
            this._id = 0;
            this._libelle = "";
            this._ouvert = false;
            this._dateOuverture = DateTime.Today;
            this._departementNourriture = new Departement();
            this._departementBoisson = new Departement();
            this._departementDiver = new Departement();
            this._pointDeVente = new PointDeVente();
            this._imprimerCommande = false;
            this._imprimante = new Imprimante();
            this._etat = false;
            this._imprimerCommandeNourriture = false;
            this._imprimante2 = new Imprimante();
        }

        // Token: 0x060015F2 RID: 5618 RVA: 0x000BAC0C File Offset: 0x000B8E0C
        public Service(int id, string libelle, bool ouvert, DateTime dateOuverture, Departement departementNourriture, Departement departementBoisson, Departement departementDiver, PointDeVente pointDeVente, bool imprimerCommande, Imprimante imprimante, bool etat, bool imprimerCommandeNourriture, Imprimante imprimante2)
        {
            this._id = id;
            this._libelle = libelle;
            this._ouvert = ouvert;
            this._dateOuverture = dateOuverture;
            this._departementBoisson = departementBoisson;
            this._departementDiver = departementDiver;
            this._departementNourriture = departementNourriture;
            this._pointDeVente = pointDeVente;
            this._imprimerCommande = imprimerCommande;
            this._imprimante = imprimante;
            this._etat = etat;
            this._imprimerCommandeNourriture = imprimerCommandeNourriture;
            this._imprimante2 = imprimante2;
        }
    }
}
