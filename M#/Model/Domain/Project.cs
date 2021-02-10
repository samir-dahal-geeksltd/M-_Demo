using MSharp;

namespace Domain
{
    public class Project : EntityType
    {
        public Project()
        {
            String("Name");

            InverseAssociate<TimeLog>("TimeLogs", "Project");

            Decimal("Total working hours")
                .Mandatory()
                .Calculated()
                .Getter("TimeLogs.GetList().Sum(x => x.Hours).GetAwaiter().GetResult()");
        }
    }
}