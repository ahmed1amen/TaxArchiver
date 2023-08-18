using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaxArchiver.Models { 

    public class Service
{
    public int id { get; set; }

    public string _libelle { get; set; }

    public bool _ouvert { get; set; }

    public DateTime _dateOuverture { get; set; }

    public Departement _departementNourriture { get; set; }

    public Departement _departementBoisson { get; set; }

    public Departement _departementDiver { get; set; }

   // public PointDeVente _pointDeVente { get; set; }

    public bool _imprimerCommande { get; set; }

  //  public Imprimante _imprimante { get; set; }

    public bool _imprimerCommandeNourriture { get; set; }

  //  public Imprimante _imprimante2 { get; set; }

    public bool _etat { get; set; }

    public Service()
    {
        this.id = 0;
        this._libelle = "";
        this._ouvert = false;
        this._dateOuverture = DateTime.Today;
        this._departementNourriture = new Departement();
        this._departementBoisson = new Departement();
        this._departementDiver = new Departement();
        //this._pointDeVente = new PointDeVente();
        this._imprimerCommande = false;
      //  this._imprimante = new Imprimante();
        this._etat = false;
        this._imprimerCommandeNourriture = false;
       // this._imprimante2 = new Imprimante();
    }

    //public Service(int id, string libelle, bool ouvert, DateTime dateOuverture, Departement departementNourriture, Departement departementBoisson, Departement departementDiver, PointDeVente pointDeVente, bool imprimerCommande, Imprimante imprimante, bool etat, bool imprimerCommandeNourriture, Imprimante imprimante2)
        public Service(int id, string libelle, bool ouvert, DateTime dateOuverture, Departement departementNourriture, Departement departementBoisson, Departement departementDiver, bool imprimerCommande, bool etat, bool imprimerCommandeNourriture)
        {
        this.id = id;
        this._libelle = libelle;
        this._ouvert = ouvert;
        this._dateOuverture = dateOuverture;
        this._departementBoisson = departementBoisson;
        this._departementDiver = departementDiver;
        this._departementNourriture = departementNourriture;
       // this._pointDeVente = pointDeVente;
        this._imprimerCommande = imprimerCommande;
     //   this._imprimante = imprimante;
        this._etat = etat;
        this._imprimerCommandeNourriture = imprimerCommandeNourriture;
      //  this._imprimante2 = imprimante2;
    }
}
}
