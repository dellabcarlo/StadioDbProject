using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StadioDb.WSL.Models
{
    public class EventoModel
    {
        public int EventoId { get; set; }
        public int PostiFree { get; set; }
        public int AbbonamentiFree { get; set; }
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public int TipologiaId { get; set; }
    }
}