using MSharp;

namespace Domain
{
    public class Employee : EntityType
    {
        public Employee()
        {
            String("First name");

            String("Last name");

            String("Email").Accepts(TextPattern.EmailAddress);

            OpenFile("ID Card");

            String("Warnings").Calculated().Getter("GetWarnings()");
        }
    }
}