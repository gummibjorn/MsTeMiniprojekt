using AutoReservation.Dal;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace AutoReservation.BusinessLayer
{
    public class AutoReservationBusinessComponent
    {

        #region Auto
        public List<Auto> allAutos()
        {
            using (var context = new AutoReservationEntities())
            {
                return context.Autos.AsNoTracking().ToList();
            }
        }

        public Auto getAuto(int id)
        {
            using (var context = new AutoReservationEntities())
            {
                return context.Autos.AsNoTracking().SingleOrDefault(i => i.Id == id);
            }
        }

        public void updateAuto(Auto modified, Auto original)
        {
            using (var context = new AutoReservationEntities())
            {
                try
                {
                    context.Autos.Attach(original);
                    context.Entry(original).CurrentValues.SetValues(modified);
                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    HandleDbConcurrencyException(context, original);
                }
            }
        }

        public void deleteAuto(Auto toDeleteAuto)
        {
            using (var context = new AutoReservationEntities())
            {
                try
                {
                    context.Autos.Attach(toDeleteAuto);
                    context.Autos.Remove(toDeleteAuto);
                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    HandleDbConcurrencyException(context, toDeleteAuto);
                }

            }
        }
        #endregion

        #region Reservationen
        public List<Reservation> allReservations()
        {
            using (var context = new AutoReservationEntities())
            {
                return context.Reservationen.AsNoTracking().ToList();
            }
        }

        public Reservation getReservation(int reservationNr)
        {
            using (var context = new AutoReservationEntities())
            {
                return context.Reservationen.AsNoTracking().SingleOrDefault(i => i.ReservationNr == reservationNr);
            }
        }

        public void insertReservation(Reservation newReservation)
        {
            using (var context = new AutoReservationEntities())
            {
                try
                {
                    context.Reservationen.Add(newReservation);
                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    HandleDbConcurrencyException(context, newReservation);
                }
            }
        }
        public void updateReservation(Reservation modified, Reservation original)
        {
            using (var context = new AutoReservationEntities())
            {
                try
                {
                    context.Reservationen.Attach(original);
                    context.Entry(original).CurrentValues.SetValues(modified);
                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    HandleDbConcurrencyException(context, original);
                }
            }
        }

        public void deleteReservation(Reservation toDeleteReservation)
        {
            using (var context = new AutoReservationEntities())
            {
                try
                {
                    context.Reservationen.Attach(toDeleteReservation);
                    context.Reservationen.Remove(toDeleteReservation);
                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    HandleDbConcurrencyException(context, toDeleteReservation);
                }

            }
        }
        #endregion

        #region Kunde
        public List<Reservation> allKunden()
        {
            using (var context = new AutoReservationEntities())
            {
                return context.Reservationen.AsNoTracking().ToList();
            }
        }

        public Kunde getKunde(int id)
        {
            using (var context = new AutoReservationEntities())
            {
                return context.Kunden.AsNoTracking().SingleOrDefault(i => i.Id == id);
            }
        }

        public void insertKunde(Kunde newKunde)
        {
            using (var context = new AutoReservationEntities())
            {
                try
                {
                    context.Kunden.Add(newKunde);
                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    HandleDbConcurrencyException(context, newKunde);
                }
            }
        }
        public void updateKunden(Kunde modified, Kunde original)
        {
            using (var context = new AutoReservationEntities())
            {
                try
                {
                    context.Kunden.Attach(original);
                    context.Entry(original).CurrentValues.SetValues(modified);
                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    HandleDbConcurrencyException(context, original);
                }
            }
        }

        public void deleteKunden(Kunde toDeleteKunde)
        {
            using (var context = new AutoReservationEntities())
            {
                try
                {
                    context.Kunden.Attach(toDeleteKunde);
                    context.Kunden.Remove(toDeleteKunde);
                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    HandleDbConcurrencyException(context, toDeleteKunde);
                }

            }
        }
        #endregion
        private static void HandleDbConcurrencyException<T>(AutoReservationEntities context, T original) where T : class
        {
            var databaseValue = context.Entry(original).GetDatabaseValues();
            context.Entry(original).CurrentValues.SetValues(databaseValue);

            throw new LocalOptimisticConcurrencyException<T>(string.Format("Update {0}: Concurrency-Fehler", typeof(T).Name), original);
        }
    }
}