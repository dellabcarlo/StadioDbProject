using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StadioDb.WSL.Models
{
    public class BigliettoModel
    {
        
            public int BigliettoId { get; set; }
            public decimal Prezzo { get; set; }
            public DateTime DataBiglietto { get; set; }
            public int IdEvento { get; set; }
            public int IdTipologia { get; set; }

        
    }
}