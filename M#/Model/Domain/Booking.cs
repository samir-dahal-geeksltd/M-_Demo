using MSharp;

namespace Domain
{
    public class Booking : EntityType
    {
        public Booking()
        {
            String("Customer");

            String("Destination");

            Date("Date");

            Associate<Agency>("Agency").Mandatory();
        }
    }
}