
namespace Reservation.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string mensage) : base(mensage)
        {
        }
    }
}
