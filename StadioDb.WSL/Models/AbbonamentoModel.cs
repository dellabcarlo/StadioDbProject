using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StadioDb.WSL.Models
{
    public class AbbonamentoModel
    {
        public int AbbonamentoId { get; set; }
        public decimal Costo { get; set; }
        public string CodiceFiscale { get; set; }
        public string Anno { get; set; }
        public int TipologiaId { get; set; }

    }
}