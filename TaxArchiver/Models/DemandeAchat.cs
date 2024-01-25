using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaxArchiver.Models
{
    // Token: 0x0200033D RID: 829
    public class DemandeAchat
    {
        // Token: 0x17000F2C RID: 3884
        // (get) Token: 0x0600395F RID: 14687 RVA: 0x001AF5C0 File Offset: 0x001AD7C0
        // (set) Token: 0x06003960 RID: 14688 RVA: 0x001AF5C8 File Offset: 0x001AD7C8
        public int _id { get; set; }

        // Token: 0x17000F2D RID: 3885
        // (get) Token: 0x06003961 RID: 14689 RVA: 0x001AF5D1 File Offset: 0x001AD7D1
        // (set) Token: 0x06003962 RID: 14690 RVA: 0x001AF5D9 File Offset: 0x001AD7D9
        public string _code { get; set; }

        // Token: 0x17000F2E RID: 3886
        // (get) Token: 0x06003963 RID: 14691 RVA: 0x001AF5E2 File Offset: 0x001AD7E2
        // (set) Token: 0x06003964 RID: 14692 RVA: 0x001AF5EA File Offset: 0x001AD7EA
        public DateTime _date { get; set; }

        // Token: 0x17000F2F RID: 3887
        // (get) Token: 0x06003965 RID: 14693 RVA: 0x001AF5F3 File Offset: 0x001AD7F3
        // (set) Token: 0x06003966 RID: 14694 RVA: 0x001AF5FB File Offset: 0x001AD7FB
        public DateTime _dateValidation { get; set; }

        // Token: 0x17000F30 RID: 3888
        // (get) Token: 0x06003967 RID: 14695 RVA: 0x001AF604 File Offset: 0x001AD804
        // (set) Token: 0x06003968 RID: 14696 RVA: 0x001AF60C File Offset: 0x001AD80C
        public Utilisateur _utilisateur { get; set; }

        // Token: 0x17000F31 RID: 3889
        // (get) Token: 0x06003969 RID: 14697 RVA: 0x001AF615 File Offset: 0x001AD815
        // (set) Token: 0x0600396A RID: 14698 RVA: 0x001AF61D File Offset: 0x001AD81D
        public Local _local { get; set; }

        // Token: 0x17000F32 RID: 3890
        // (get) Token: 0x0600396B RID: 14699 RVA: 0x001AF626 File Offset: 0x001AD826
        // (set) Token: 0x0600396C RID: 14700 RVA: 0x001AF62E File Offset: 0x001AD82E
        public string _commentaire { get; set; }

        // Token: 0x17000F33 RID: 3891
        // (get) Token: 0x0600396D RID: 14701 RVA: 0x001AF637 File Offset: 0x001AD837
        // (set) Token: 0x0600396E RID: 14702 RVA: 0x001AF63F File Offset: 0x001AD83F
        public bool _valider { get; set; }

        // Token: 0x17000F34 RID: 3892
        // (get) Token: 0x0600396F RID: 14703 RVA: 0x001AF648 File Offset: 0x001AD848
        // (set) Token: 0x06003970 RID: 14704 RVA: 0x001AF650 File Offset: 0x001AD850
        public bool _annuler { get; set; }

        // Token: 0x17000F35 RID: 3893
        // (get) Token: 0x06003971 RID: 14705 RVA: 0x001AF659 File Offset: 0x001AD859
        // (set) Token: 0x06003972 RID: 14706 RVA: 0x001AF661 File Offset: 0x001AD861
        public List<LigneDemandeAchat> _listLigneDemandeAchat { get; set; }

        // Token: 0x17000F36 RID: 3894
        // (get) Token: 0x06003973 RID: 14707 RVA: 0x001AF66A File Offset: 0x001AD86A
        // (set) Token: 0x06003974 RID: 14708 RVA: 0x001AF672 File Offset: 0x001AD872
        public int _niveauValidation { get; set; }

        // Token: 0x06003975 RID: 14709 RVA: 0x001AF67C File Offset: 0x001AD87C
        public DemandeAchat()
        {
            this._id = 0;
            this._date = default(DateTime);
            this._utilisateur = new Utilisateur();
            this._local = new Local();
            this._commentaire = "";
            this._annuler = false;
            this._listLigneDemandeAchat = new List<LigneDemandeAchat>();
            this._niveauValidation = StockParam._niveauValidationDemande - 1;
            this._valider = false;
        }

        // Token: 0x06003976 RID: 14710 RVA: 0x001AF6EC File Offset: 0x001AD8EC
        public DemandeAchat(int id, string code, Utilisateur utilisateur, Local local, string commentaire, List<LigneDemandeAchat> listLigneDemandeAchat)
        {
            this._id = id;
            if (StockParam._numeroDemandeAchatAuto)
            {
                this._code = string.Concat(this._id);
            }
            else
            {
                this._code = code;
            }
            this._utilisateur = utilisateur;
            this._local = local;
            this._commentaire = commentaire;
            this._date = default(DateTime);
            this._annuler = false;
            this._listLigneDemandeAchat = listLigneDemandeAchat;
            if (StockParam._niveauValidationDemande == 0)
            {
                this._niveauValidation = StockParam._niveauValidationDemande;
            }
            else
            {
                this._niveauValidation = StockParam._niveauValidationDemande - 1;
            }
            if (this._niveauValidation != 0 || !this.allLigneDemandeAreValide(this._listLigneDemandeAchat))
            {
                this._valider = false;
                return;
            }
            this._dateValidation = default(DateTime);
            this._valider = true;
        }

        // Token: 0x06003977 RID: 14711 RVA: 0x001AF7B8 File Offset: 0x001AD9B8
        public DemandeAchat(int id, string code, DateTime date, DateTime dateValidation, Utilisateur utilisateur, Local local, string commentaire, bool valider, bool annuler, NiveauValidation niveauValidation, List<LigneDemandeAchat> listLigneDemandeAchat)
        {
            this._id = id;
            this._code = code;
            this._utilisateur = utilisateur;
            this._local = local;
            this._commentaire = commentaire;
            this._date = date;
            this._annuler = annuler;
            this._listLigneDemandeAchat = listLigneDemandeAchat;
            this._niveauValidation = niveauValidation._niveau;
            this._valider = valider;
            this._dateValidation = dateValidation;
        }

        // Token: 0x06003978 RID: 14712 RVA: 0x001AF828 File Offset: 0x001ADA28
        public int ajouerLigneDemandeAchat(LigneDemandeAchat ligneDemandeAchat)
        {
            if (!(ligneDemandeAchat._article._qteMax != 0m))
            {
                return this._ajouerLigneDemandeAchat(ligneDemandeAchat);
            }
            if (ligneDemandeAchat._qteDemande + ligneDemandeAchat._article._qteTotal > ligneDemandeAchat._article._qteMax)
            {
                return 1;
            }
            return this._ajouerLigneDemandeAchat(ligneDemandeAchat);
        }

        // Token: 0x06003979 RID: 14713 RVA: 0x001AF8B0 File Offset: 0x001ADAB0
        private int _ajouerLigneDemandeAchat(LigneDemandeAchat ligneDemandeAchat)
        {
            LigneDemandeAchat ligneDemandeAchat2 = this._listLigneDemandeAchat.Find((LigneDemandeAchat _cus) => _cus._article._id == ligneDemandeAchat._article._id);
            if (ligneDemandeAchat2 != null)
            {
                return 2;
            }
            this._listLigneDemandeAchat.Add(ligneDemandeAchat);
            return 0;
        }

        // Token: 0x0600397A RID: 14714 RVA: 0x001AF8FC File Offset: 0x001ADAFC
        public bool allLigneDemandeAreValide(List<LigneDemandeAchat> listLigneDemandeAchat)
        {
            bool result = true;
            foreach (LigneDemandeAchat ligneDemandeAchat in listLigneDemandeAchat)
            {
            }
            return result;
        }

        // Token: 0x0600397B RID: 14715 RVA: 0x001AF948 File Offset: 0x001ADB48
        public void setDemande(DemandeAchat demandeAchat)
        {
            this._local = demandeAchat._local;
            this._commentaire = demandeAchat._commentaire;
            this._niveauValidation = demandeAchat._niveauValidation;
            this._valider = true;
            this._dateValidation = default(DateTime);
            this._annuler = demandeAchat._annuler;
            this._listLigneDemandeAchat = demandeAchat._listLigneDemandeAchat;
        }

        // Token: 0x0600397C RID: 14716 RVA: 0x001AF9A8 File Offset: 0x001ADBA8
        public int validerDemande(NiveauValidation niveauValidation, DemandeAchat demandeAchat)
        {
            if (this._niveauValidation == niveauValidation.niveau)
            {
                this._local = demandeAchat._local;
                this._commentaire = demandeAchat._commentaire;
                this._niveauValidation--;
                if (this._niveauValidation == 0)
                {
                    this._valider = true;
                }
                this._dateValidation = default(DateTime);
                this._annuler = demandeAchat._annuler;
                this._listLigneDemandeAchat = demandeAchat._listLigneDemandeAchat;
                return 0;
            }
            return 1;
        }

        // Token: 0x0600397D RID: 14717 RVA: 0x001AFA22 File Offset: 0x001ADC22
        public int annulerDemande(NiveauValidation niveauValidation)
        {
            if (this._niveauValidation == niveauValidation.niveau)
            {
                this._annuler = true;
                return 0;
            }
            return 1;
        }
    }
}
