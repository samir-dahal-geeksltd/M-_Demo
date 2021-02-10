using MSharp;

namespace Domain
{
    public class Agency : EntityType
    {
        public Agency()
        {
            String("Name");

            String("Notes").Lines(5);

            InverseAssociate<Booking>("Bookings", "Agency");
        }
    }
}