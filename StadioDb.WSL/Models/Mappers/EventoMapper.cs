using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Stadio.Entities;


namespace StadioDb.WSL.Models.Mappers
{
    public class EventoMapper
    {

        public static EventoModel MapEventoToModel(evento entity)
        {
            EventoModel model = new EventoModel();
            model.EventoId = entity.idEvento;
            model.PostiFree = entity.postiDisponibili;
            model.EventDate = entity.dataEvento;
            model.AbbonamentiFree = entity.abbonamentiDisponibili;
            model.TipologiaId = entity.abbonamentiDisponibili;
            return model;
        }

        public static evento MapEventToEntity(EventoModel model)
        {
            evento entity = new evento();
            entity.idEvento = model.EventoId;
            entity.postiDisponibili = model.PostiFree;
            entity.dataEvento = model.EventDate;
            entity.abbonamentiDisponibili = model.AbbonamentiFree;
            entity.abbonamentiDisponibili = model.TipologiaId;

            return entity;

        }

    }
}