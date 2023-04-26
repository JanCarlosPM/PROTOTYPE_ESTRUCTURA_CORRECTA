using Entidades;
using System.Data.Entity;

namespace Datos
{
    public class StockAccess
    {
        public static void AgregarComputadoraStock(computadora computadora)
        {
            using (var db = new ClonacionComputadorasEntities())
            {
                db.computadora.Add(computadora);
                db.SaveChanges();
            }
        }

        public static void ActualizarComputadoraStock(computadora computadora)
        {
            using (var db = new ClonacionComputadorasEntities())
            {
                db.Entry(computadora).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

    }
}
