using Reservation.Entitis;
using Reservation.Exceptions;
using System;

namespace Reservation
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.Write("Numero do Quarto: ");
                int number = int.Parse(Console.ReadLine());

                Console.WriteLine("Checkin Date (dd/MM/yyyy): ");
                DateTime checkin = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Checkout Date (dd/MM/yyyy): ");
                DateTime checkout = DateTime.Parse(Console.ReadLine());

                ReservationHotel reserva = new ReservationHotel(number, checkin, checkout);

                Console.WriteLine($"{reserva}, {reserva.Duration()} days");

                Console.WriteLine("insira novos dados da Reserva...");
                Console.WriteLine("Checkin Date (dd/MM/yyyy): ");
                checkin = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Checkout Date (dd/MM/yyyy): ");
                checkout = DateTime.Parse(Console.ReadLine());

                reserva.UpdateDates(checkin, checkout);

                Console.WriteLine($"{reserva}, {reserva.Duration()} days");
            }
            catch (DomainException e)
            {
                Console.WriteLine(e.Message);
            }





            Console.WriteLine("END...");



        }
    }
}