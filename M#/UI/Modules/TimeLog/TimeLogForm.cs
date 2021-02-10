using MSharp;

namespace Modules
{
    public class TimeLogForm : FormModule<Domain.TimeLog>
    {
        public TimeLogForm()
        {
            HeaderText("Time log details");

            Field(x => x.Project).AsDropDown();

            Field(x => x.Developer).AsDropDown();

            Field(x => x.Date).AsDatePicker();

            Field(x => x.StartTime);

            Field(x => x.EndTime);

            Field(x => x.Details);

            button.Cancel();

            button.Save();
         
        }
    }
}