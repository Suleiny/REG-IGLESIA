using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;

namespace IGLESIA.Data
{

    public class MiemServices
    {

        private readonly ApplicationDbContext _db;
        public MiemServices(ApplicationDbContext db)
        {
            _db = db;
        }
        public List<Miembros> GetMiembros()
        {
            var infomiembro = _db.IMiembros.ToList();
            return infomiembro;
        }
        public string Create(Miembros objinfo)
        {
            _db.IMiembros.Add(objinfo);
            _db.SaveChanges();
            return "Guardado";
        }

        public Miembros GetById(int id)
        {
            Miembros infomiembro = _db.IMiembros.FirstOrDefault(s => s.Nombre == s.Nombre);
            return infomiembro;
        }
        public string UpdateMiembros(Miembros objmiembros)
        {
            _db.IMiembros.Update(objmiembros);
            _db.SaveChanges();
            return "Update";
        }
        public string Deleteinfo(Miembros objmiembro)
        {
            _db.Remove(objmiembro);
            _db.SaveChanges();
            return "Delete";
        }







    }
}



