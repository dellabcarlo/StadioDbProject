using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Stadio.Entities;

namespace StadioDb.WSL.Models.Mappers
{
    public static class TipologiaEventoMapper
    {
        public static TipologiaEventoModel MapTipologiaEventoToEntity(TipologiaEvento entity)
        {
            TipologiaEventoModel model = new TipologiaEventoModel();
            model.idtipoevento = entity.idTipologia;
            model.eventotipo = entity.TipoEvento;
            return model;
        }
        public static TipologiaEvento MapTipologiaEventoToModel(TipologiaEventoModel model)
        {
            TipologiaEvento entity = new TipologiaEvento();
            entity.idTipologia = model.idtipoevento;
            entity.TipoEvento = model.eventotipo;
            return entity;
        }
    }
}