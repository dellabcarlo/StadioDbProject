using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StadioDb.WSL.Models
{
    public class StaffModel
    {
        public string UtenteNome { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CodiceFiscale { get; set; }
        public int age { get; set; }
        public string sex { get; set; }
    }
}