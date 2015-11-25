using AutoReservation.Common.DataTransferObjects;
using System.Collections.Generic;
using System.ServiceModel;

namespace AutoReservation.Common.Interfaces
{
    [ServiceContract]
    public interface IAutoReservationService
    {
        [OperationContract]
        List<AutoDto> AllAutos();

        [OperationContract]
        AutoDto GetAuto(int id);

        [OperationContract]
        void InsertAuto(AutoDto newAuto);

        [OperationContract]
        void UpdateAuto(AutoDto modified, AutoDto original);

        [OperationContract]
        void DeleteAuto(AutoDto toDeleteAuto);

        [OperationContract]
        List<ReservationDto> AllReservations();

        [OperationContract]
        ReservationDto GetReservation(int id);

        [OperationContract]
        void InsertReservation(ReservationDto newReservation);

        [OperationContract]
        void UpdateReservation(ReservationDto modified, ReservationDto original);

        [OperationContract]
        void DeleteReservation(ReservationDto toDeleteReservation);

        [OperationContract]
        List<ReservationDto> AllKunden();

        [OperationContract]
        KundeDto GetKunde(int id);

        [OperationContract]
        void InsertKunde(KundeDto newReservation);

        [OperationContract]
        void UpdateKunde(KundeDto modified, KundeDto original);

        [OperationContract]
        void DeleteKunde(KundeDto toDeleteKunde);
    }
}
