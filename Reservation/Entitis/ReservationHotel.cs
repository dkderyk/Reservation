using Reservation.Exceptions;

namespace Reservation.Entitis
{
    public class ReservationHotel
    {
        public int RoomNumber { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }

        public ReservationHotel(int roomNumber, DateTime checkin, DateTime checkout)
        {
            if (checkout < checkin)
            {
                throw new DomainException("Erro: CheckOut menor que CheckIn");
            }

            RoomNumber = roomNumber;
            Checkin = checkin;
            Checkout = checkout;
        }

        public override string ToString()
        {
            return $"Reserva: \n   Numero: {RoomNumber} \n   Checkin: {Checkin.ToString("dd/MM/yyyy")} \n   Checkout: {Checkout.ToString("dd/MM/yyyy")} ";
        }

        public int Duration()
        {
            TimeSpan result = Checkout - Checkin;
            int days = result.Days;
            return days;
        }

        public void UpdateDates(DateTime checkin, DateTime checkout)
        {
            if (checkin < DateTime.Now || checkout < DateTime.Now)
            {
                throw new DomainException("Error: Data inserida menor que data de agora");
            }
            if (checkout <= checkin)
            {
                throw new DomainException("Error: Checkout menor que Checkin");
            }

            Checkin = checkin;
            Checkout = checkout;
        }
    }
}
