using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Stadio.Entities;

namespace StadioDb.WSL.Models.Mappers
{
    public static  class StaffMapper
    {
        public static StaffModel MapStaffToEntity(staff entity)
        {
            StaffModel model = new StaffModel();
            model.UtenteNome = entity.nomeUtente;
            model.Password = entity.autPassword;
            model.Role = entity.ruolo;
            model.Name = entity.nome;
            model.Surname = entity.nome;
            model.CodiceFiscale = entity.CF;
            model.age = entity.eta;
            model.sex = entity.sesso;
            return model;
        }
        public static staff MapStaffToModel(StaffModel model)
        {
            staff entity = new staff();
            entity.nomeUtente = model.UtenteNome;
            entity.autPassword = model.Password;
            entity.ruolo = model.Role;
            entity.nome = model.Name;
            entity.nome = model.Surname;
            entity.CF = model.CodiceFiscale;
            entity.eta = model.age;
            entity.sesso = model.sex;
            return entity;
        }

    }
}