//------------------------------------------------------------------------------
// <auto-generated>
//     Codice generato da un modello.
//
//     Le modifiche manuali a questo file potrebbero causare un comportamento imprevisto dell'applicazione.
//     Se il codice viene rigenerato, le modifiche manuali al file verranno sovrascritte.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Stadio.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class biglietto
    {
        public int idBiglietto { get; set; }
        public decimal prezzo { get; set; }
        public System.DateTime dataBiglietto { get; set; }
        public int idEvento { get; set; }
        public int idTipologia { get; set; }
    
        public virtual evento evento { get; set; }
        public virtual TipologiaEvento TipologiaEvento { get; set; }
    }
}
