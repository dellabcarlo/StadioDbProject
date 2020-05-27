using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Stadio.Entities;

namespace StadioDb.WSL.Models.Mappers
{
    public class AbbonamentoMapper
    {
        public static AbbonamentoModel MapAbbonamentoToModel(abbonamento entity)
        {
            AbbonamentoModel model = new AbbonamentoModel();
            model.AbbonamentoId = entity.idAbbonamento;
            model.Costo = entity.costo;
            model.CodiceFiscale = entity.CF;
            model.Anno = entity.anno;
            model.TipologiaId = entity.idTipologia;
            return model;
        }


        public static abbonamento MapBigliettoToEntity(AbbonamentoModel model)
        {
            abbonamento entity = new abbonamento();
            entity.idAbbonamento = model.AbbonamentoId;
            entity.costo = model.Costo;
            entity.CF = model.CodiceFiscale;
            entity.anno = model.Anno;
            entity.idTipologia = model.TipologiaId;

            return entity;

        }
    }
}