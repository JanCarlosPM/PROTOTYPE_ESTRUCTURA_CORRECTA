using Entidades;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Entidades
{
    public class DataAccess
    {
        public static List<Computadoras> GetComputadoras()
        {
            using (var db = new ClonacionComputadorasEntities())
            {
                return db.Computadoras.ToList();
            }
        }

        public static void AgregarComputadora(Computadoras computadoras)
        {
            using (var db = new ClonacionComputadorasEntities())
            {
                db.Computadoras.Add(computadoras);
                db.SaveChanges();
            }
        }

        public static void EditarComputadora(Computadoras computadoras)
        {
            using (var db = new ClonacionComputadorasEntities())
            {
                db.Entry(computadoras).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public static void EliminarComputadora(int id)
        {
            using (var db = new ClonacionComputadorasEntities())
            {
                var computadora = db.Computadoras.Find(id);
                if (computadora != null)
                {
                    db.Computadoras.Remove(computadora);
                    db.SaveChanges();
                }
            }
        }
    }
}