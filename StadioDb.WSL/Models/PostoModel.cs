using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StadioDb.WSL.Models
{
    public class PostoModel
    {
        public int iDPosto { get; set; }
        public int PostoNumero { get; set; }
        public string SettoreNome { get; set; }
        public string AnelloNome { get; set; }
        public string disponibile { get; set; }
        public int? idEvento { get; set; }
        public int? idAbbonamento { get; set; }
    }
}