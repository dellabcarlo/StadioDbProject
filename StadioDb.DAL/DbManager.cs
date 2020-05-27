using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stadio.Entities;

namespace StadioDb.DAL
{
    public class DbManager
    {

        public List<abbonamento> GetAllAbbonamenti()
        {
            try
            {
                using (StadioDBEntities context = new StadioDBEntities())
                {
                    return context.abbonamento.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
