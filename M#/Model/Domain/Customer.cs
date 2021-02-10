using MSharp;

namespace Domain
{
    public class Customer : EntityType
    {
        public Customer()
        {
            Associate<Country>("Country");

            String("Company name");

            Date("Contract start date");

            OpenImage("Logo").Width(200).Height(80);

            OpenFile("Contract");
        }
    }
}