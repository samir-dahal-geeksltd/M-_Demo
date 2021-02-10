using MSharp;

namespace Modules
{
    public class ProjectsList : ListModule<Domain.Project>
    {
        public ProjectsList()
        {
            HeaderText("Projects")
                .ShowHeaderRow()
                .ShowFooterRow();

            Column(x => x.Name);

            Column(x => x.TotalWorkingHours).FooterFormula(AggregateFormula.Sum);

            column.Edit<Project.EnterPage>();

            column.Delete();

            button.New<Project.EnterPage>();
        }
    }
}