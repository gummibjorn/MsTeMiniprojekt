using AutoReservation.Common.Interfaces;
using System;
using System.Diagnostics;
using AutoReservation.Common.DataTransferObjects;
using System.Collections.Generic;
using AutoReservation.BusinessLayer;
using System.ServiceModel;

namespace AutoReservation.Service.Wcf
{
    public class AutoReservationService : IAutoReservationService
    {
        private AutoReservationBusinessComponent businessComponent;

        public AutoReservationService()
        {
            businessComponent = new AutoReservationBusinessComponent();
        }

        private static void WriteActualMethod()
        {
            Console.WriteLine("Calling: " + new StackTrace().GetFrame(1).GetMethod().Name);
        }

        public List<AutoDto> AllAutos()
        {
            WriteActualMethod();
            return businessComponent.AllAutos().ConvertToDtos();
        }

        public List<KundeDto> AllKunden()
        {
            WriteActualMethod();
            return businessComponent.AllKunden().ConvertToDtos();
        }

        public List<ReservationDto> AllReservations()
        {
            WriteActualMethod();
            return businessComponent.AllReservations().ConvertToDtos();
        }

        public void DeleteAuto(AutoDto toDeleteAuto)
        {
            WriteActualMethod();
            businessComponent.DeleteAuto(toDeleteAuto.ConvertToEntity());
        }

        public void DeleteKunde(KundeDto toDeleteKunde)
        {
            WriteActualMethod();
            businessComponent.DeleteKunden(toDeleteKunde.ConvertToEntity());
        }

        public void DeleteReservation(ReservationDto toDeleteReservation)
        {
            WriteActualMethod();
            businessComponent.DeleteReservation(toDeleteReservation.ConvertToEntity());
        }

        public AutoDto GetAuto(int id)
        {
            WriteActualMethod();
            return businessComponent.GetAuto(id).ConvertToDto();
        }

        public KundeDto GetKunde(int id)
        {
            WriteActualMethod();
            return businessComponent.GetKunde(id).ConvertToDto();
        }

        public ReservationDto GetReservation(int id)
        {
            WriteActualMethod();
            return businessComponent.GetReservation(id).ConvertToDto();
        }

        public void InsertAuto(AutoDto newAuto)
        {
            WriteActualMethod();
            businessComponent.InsertAuto(newAuto.ConvertToEntity());
        }

        public void InsertKunde(KundeDto newKunde)
        {
            WriteActualMethod();
            businessComponent.InsertKunde(newKunde.ConvertToEntity());
        }

        public void InsertReservation(ReservationDto newReservation)
        {
            WriteActualMethod();
            businessComponent.InsertReservation(newReservation.ConvertToEntity());
        }

        public void UpdateAuto(AutoDto modified, AutoDto original)
        {
            try
            {
                WriteActualMethod();
                businessComponent.UpdateAuto(modified.ConvertToEntity(), original.ConvertToEntity());
            }
            catch (Exception e)
            {
                throw new FaultException<AutoDto>(modified, e.Message);
            }
        }

        public void UpdateKunde(KundeDto modified, KundeDto original)
        {
            try
            {
                WriteActualMethod();
                businessComponent.UpdateKunden(modified.ConvertToEntity(), original.ConvertToEntity());
            }
            catch (Exception e)
            {
                throw new FaultException<KundeDto>(modified, e.Message);
            }

        }

        public void UpdateReservation(ReservationDto modified, ReservationDto original)
        {
            try
            {
                WriteActualMethod();
                businessComponent.UpdateReservation(modified.ConvertToEntity(), original.ConvertToEntity());
            }
            catch (Exception e)
            {
                throw new FaultException<ReservationDto>(modified, e.Message);
            }
        }
    }
}