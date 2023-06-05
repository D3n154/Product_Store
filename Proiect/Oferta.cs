using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    public class Oferta
    {
        public int IdProdus { get; set; }
        public string NumeCumparator { get; set; }
        public decimal PretPropus { get; set; }

        public Oferta(int idProdus, string dateCumparator, decimal pretPropus)
        {
            IdProdus = idProdus;
            NumeCumparator = dateCumparator;
            PretPropus = pretPropus;
        }
    }
}
