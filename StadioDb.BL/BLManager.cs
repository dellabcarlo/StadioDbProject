using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stadio.Entities;
using StadioDb.DAL;


namespace StadioDb.BL
{
    public static class BLManager
    {
        public static List<abbonamento> GetAllAbbonamenti()
        {
            try
            {
                DbManager manager = new DbManager();
                return manager.GetAllAbbonamenti();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
