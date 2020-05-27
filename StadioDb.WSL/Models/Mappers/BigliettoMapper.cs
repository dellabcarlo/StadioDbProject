using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Stadio.Entities;

namespace StadioDb.WSL.Models.Mappers
{
    public static class BigliettoMapper
    {
        public static BigliettoModel MapBigliettoToModel(biglietto entity)
        {
            BigliettoModel model = new BigliettoModel();
            model.BigliettoId = entity.idBiglietto;
            model.Prezzo = entity.prezzo;
            model.DataBiglietto = entity.dataBiglietto;
            model.IdEvento = entity.idEvento;
            model.IdTipologia = entity.idTipologia;
            return model;
        }

        public static biglietto MapBigliettoToEntity(BigliettoModel model)
        {
            biglietto entity = new biglietto();
            entity.idBiglietto = model.BigliettoId;
            entity.prezzo = model.Prezzo;
            entity.dataBiglietto = model.DataBiglietto;
            entity.idEvento = model.IdEvento;
            entity.idTipologia = model.IdTipologia;

            return entity;

        }
    }
}