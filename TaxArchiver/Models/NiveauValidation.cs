using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaxArchiver.Models
{
    // Token: 0x02000135 RID: 309
    public class NiveauValidation
    {
        // Token: 0x1700054B RID: 1355
        // (get) Token: 0x06001535 RID: 5429 RVA: 0x000B9BD6 File Offset: 0x000B7DD6
        // (set) Token: 0x06001536 RID: 5430 RVA: 0x000B9BDE File Offset: 0x000B7DDE
        public int _id { get; set; }

        // Token: 0x1700054C RID: 1356
        // (get) Token: 0x06001537 RID: 5431 RVA: 0x000B9BE7 File Offset: 0x000B7DE7
        // (set) Token: 0x06001538 RID: 5432 RVA: 0x000B9BEF File Offset: 0x000B7DEF
        public string _libelle { get; set; }

        // Token: 0x1700054D RID: 1357
        // (get) Token: 0x06001539 RID: 5433 RVA: 0x000B9BF8 File Offset: 0x000B7DF8
        // (set) Token: 0x0600153A RID: 5434 RVA: 0x000B9C00 File Offset: 0x000B7E00
        public Utilisateur _utilisateur { get; set; }

        // Token: 0x1700054E RID: 1358
        // (get) Token: 0x0600153B RID: 5435 RVA: 0x000B9C09 File Offset: 0x000B7E09
        // (set) Token: 0x0600153C RID: 5436 RVA: 0x000B9C11 File Offset: 0x000B7E11
        public int _niveau { get; set; }

        // Token: 0x1700054F RID: 1359
        // (get) Token: 0x0600153D RID: 5437 RVA: 0x000B9C1A File Offset: 0x000B7E1A
        // (set) Token: 0x0600153E RID: 5438 RVA: 0x000B9C22 File Offset: 0x000B7E22
        public List<DemandeAchat> _demandeAchat { get; set; }

        // Token: 0x0600153F RID: 5439 RVA: 0x000B9C2B File Offset: 0x000B7E2B
        public NiveauValidation()
        {
            this._id = -1;
            this._libelle = "";
            this._utilisateur = new Utilisateur();
            this._niveau = 0;
            this._demandeAchat = new List<DemandeAchat>();
        }

        // Token: 0x06001540 RID: 5440 RVA: 0x000B9C64 File Offset: 0x000B7E64
        public NiveauValidation(int id, string libelle, Utilisateur utilisateur, int niveau, List<DemandeAchat> demandeAchat)
        {
            this._id = id;
            this._libelle = libelle;
            this._utilisateur = utilisateur;
            int niveauValidationDemande = StockParam._niveauValidationDemande;
            if (niveauValidationDemande != 0)
            {
                if (niveau > niveauValidationDemande)
                {
                    this._niveau = niveauValidationDemande;
                }
                else
                {
                    this._niveau = niveau;
                }
                this._demandeAchat = demandeAchat;
            }
        }

        // Token: 0x06001541 RID: 5441 RVA: 0x000B9CB4 File Offset: 0x000B7EB4
        public NiveauValidation(int id, string libelle, Utilisateur utilisateur, int niveau)
        {
            this._id = id;
            this._libelle = libelle;
            this._utilisateur = utilisateur;
            int niveauValidationDemande = StockParam._niveauValidationDemande;
            if (niveauValidationDemande != 0)
            {
                if (niveau > niveauValidationDemande)
                {
                    this._niveau = niveauValidationDemande;
                }
                else
                {
                    this._niveau = niveau;
                }
                this._demandeAchat = new List<DemandeAchat>();
            }
        }

        // Token: 0x17000550 RID: 1360
        // (get) Token: 0x06001542 RID: 5442 RVA: 0x000B9D06 File Offset: 0x000B7F06
        // (set) Token: 0x06001543 RID: 5443 RVA: 0x000B9D0E File Offset: 0x000B7F0E
        public int niveau
        {
            get
            {
                return this._niveau;
            }
            set
            {
                if (this.niveau > StockParam._niveauValidationDemande)
                {
                    this._niveau = StockParam._niveauValidationDemande;
                    return;
                }
                this._niveau = value;
            }
        }

        // Token: 0x06001544 RID: 5444 RVA: 0x000B9D30 File Offset: 0x000B7F30
        public int validerDemande(DemandeAchat demandeAchat)
        {
            return demandeAchat.validerDemande(this, demandeAchat);
        }

        // Token: 0x06001545 RID: 5445 RVA: 0x000B9D3A File Offset: 0x000B7F3A
        public int annulerDemande(DemandeAchat demandeAchat)
        {
            return demandeAchat.annulerDemande(this);
        }

        // Token: 0x06001546 RID: 5446 RVA: 0x000B9D44 File Offset: 0x000B7F44
        public new string ToString()
        {
            return string.Concat(new object[]
            {
                this._id,
                " ",
                this._libelle,
                " ",
                this._niveau,
                "\n"
            });
        }
    }
}
