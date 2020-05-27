using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Stadio.Entities;

namespace StadioDb.WSL.Models.Mappers
{
    public static class PostoMapper
    {
        public static PostoModel MapPostoToEntity(posto entity)
        {
            PostoModel model = new PostoModel();
            model.iDPosto = entity.idPosto;
            model.PostoNumero = entity.numeroPosto;
            model.SettoreNome = entity.nomeSettore;
            model.AnelloNome = entity.nomeAnello;
            model.disponibile = entity.isDisponibile;
            model.idEvento = entity.evento;
            model.idAbbonamento = entity.abbonamento;
            return model;
        }
        public static posto MapPostoToModel(PostoModel model)
        {
            posto entity = new posto();
            entity.idPosto = model.iDPosto;
            entity.numeroPosto = model.PostoNumero;
            entity.nomeSettore = model.SettoreNome;
            entity.nomeAnello = model.AnelloNome;
            entity.isDisponibile = model.disponibile;
            entity.evento = model.idEvento;
            entity.abbonamento = model.idAbbonamento;
            return entity;
        }
    }
}