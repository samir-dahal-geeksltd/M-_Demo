using MSharp;

namespace Modules
{
    public class DevelopersList : ListModule<Domain.Developer>
    {
        public DevelopersList()
        {
            HeaderText("Developers")
                .ShowHeaderRow()
                .ShowFooterRow();

            Column(x => x.FullName);

            Column(x => x.LatestWork);

            Column(x => x.TotalWork);

            column.Edit<Developer.EnterPage>();

            column.Delete();

            button.New<Developer.EnterPage>();
        }
    }
}