using MSharp;

namespace Modules
{
    public class AgenciesList : ListModule<Domain.Agency>
    {
        public AgenciesList()
        {
            HeaderText("Agencies")
                .ShowHeaderRow();

            ButtonColumn("c#:item.Name").HeaderText("Name")
                .Style(ButtonStyle.Link)
                .OnClick(x => x.Go<Agency.ViewPage>()
                .Send("item", "item.ID"));

            Column(x => x.Notes);

            column.Edit<Agency.EnterPage>();

            column.Delete();

            button.New<Agency.EnterPage>();

           
        }
    }
}