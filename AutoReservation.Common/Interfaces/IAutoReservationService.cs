using AutoReservation.Common.DataTransferObjects;
using System.Collections.Generic;

namespace AutoReservation.Common.Interfaces
{
    public interface IAutoReservationService
    {
        List<AutoDto> AllAutos();
        AutoDto GetAuto(int id);
        void InsertAuto(AutoDto newAuto);
        void UpdateAuto(AutoDto modified, AutoDto original);
        void DeleteAuto(AutoDto toDeleteAuto);

        List<ReservationDto> AllReservations();
        ReservationDto GetReservation(int id);
        void InsertReservation(ReservationDto newReservation);
        void UpdateReservation(ReservationDto modified, ReservationDto original);
        void DeleteReservation(ReservationDto toDeleteReservation);

        List<ReservationDto> AllKunden();
        KundeDto GetKunde(int id);
        void InsertKunde(KundeDto newReservation);
        void UpdateKunde(KundeDto modified, KundeDto original);
        void DeleteKunde(KundeDto toDeleteKunde);
    }
}
