using AutoReservation.Common.DataTransferObjects;
using System.Collections.Generic;

namespace AutoReservation.Common.Interfaces
{
    public interface IAutoReservationService
    {
        List<AutoDto> allAutos();
        AutoDto getAuto(int id);
        AutoDto insertAuto(AutoDto newAuto);
        AutoDto updateAuto(AutoDto modified, AutoDto original);
        AutoDto deleteAuto(AutoDto toDeleteAuto);

        List<ReservationDto> allReservations();
        ReservationDto getReservation(int id);
        ReservationDto insertReservation(ReservationDto newReservation);
        ReservationDto updateReservation(ReservationDto modified, ReservationDto original);

        List<ReservationDto> allKunden();
        KundeDto getKunde(int id);
        KundeDto insertKunde(KundeDto newReservation);
        KundeDto updateKunde(KundeDto modified, KundeDto original);


    }
}
