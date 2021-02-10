using MSharp;

namespace Domain
{
    public class TimeLog : EntityType
    {
        public TimeLog()
        {
            Associate<Project>("Project").Mandatory();

            Associate<Developer>("Developer").Mandatory().OnDelete(CascadeAction.CascadeDelete);

            Date("Date").Mandatory();

            Time("Start time").Mandatory();

            Time("End time").Mandatory();

            Decimal("Hours")
                .Mandatory()
                .Calculated()
                .Getter("(decimal)EndTime.Subtract(StartTime).TotalHours.Round(2)");

            String("Details").Lines(5).HelpText("Information details");
        }
    }
}