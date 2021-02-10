using MSharp;

namespace Modules
{
    public class TimeLogsList : ListModule<Domain.TimeLog>
    {
        public TimeLogsList()
        {
            HeaderText("Time logs")
                .ShowHeaderRow()
                .ShowFooterRow();

            Column(x => x.Project);

            Column(x => x.Developer);

            Column(x => x.Date);

            Column(x => x.StartTime);

            Column(x => x.EndTime);

            Column(x => x.Hours);

            column.Edit<TimeLog.EnterPage>();

            column.Delete();

            button.New<TimeLog.EnterPage>();

           
        }
    }
}