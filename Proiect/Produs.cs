using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    public class Produs
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public decimal Pret { get; set; }
        public string Descriere { get; set; }
        public string Vanzator { get; set; }
        public bool EsteNegociabil { get; set; }
        public decimal PretMinim { get; set; }

        public Produs(int id, string nume, decimal pret, string vanzator, string descriere, bool esteNegociabil, decimal pretMinim)
        {
            Id = id;
            Nume = nume;
            Pret = pret;
            Descriere = descriere;
            Vanzator = vanzator;
            EsteNegociabil = esteNegociabil;
            PretMinim = pretMinim;
        }

        public override string ToString()
        {
            
            // Implementați logica de conversie a produsului la un șir de caractere
            return string.Format("{0}; {1}; {2}; {3}; {4}; {5}; {6}",Id, Nume, Pret, Vanzator, Descriere, EsteNegociabil, PretMinim);
        }
    }
}






