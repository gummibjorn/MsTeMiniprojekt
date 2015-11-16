using AutoReservation.Dal;
using System.Collections.Generic;
using System.Linq;

namespace AutoReservation.BusinessLayer
{
    public class AutoReservationBusinessComponent
    {

        private AutoReservationEntities context;

        public AutoReservationBusinessComponent(){
                    context = new AutoReservationEntities();
        }

        public List<Auto> allAutos()
        {
            return context.Autos.AsNoTracking().ToList();                
        }

        public Auto getAuto(int id)
        {
            return context.Autos.AsNoTracking().SingleOrDefault(i => i.Id == id);
        }

        private static void HandleDbConcurrencyException<T>(AutoReservationEntities context, T original) where T : class
        {
            var databaseValue = context.Entry(original).GetDatabaseValues();
            context.Entry(original).CurrentValues.SetValues(databaseValue);

            throw new LocalOptimisticConcurrencyException<T>(string.Format("Update {0}: Concurrency-Fehler", typeof(T).Name), original);
        }
    }
}