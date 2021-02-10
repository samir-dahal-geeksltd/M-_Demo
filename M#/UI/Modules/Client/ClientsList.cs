using MSharp;

namespace Modules
{
    public class ClientsList : ListModule<Domain.Client>
    {
        public ClientsList()
        {
            HeaderText("Clients")
                .UseDatabasePaging(false)
                .Sortable()
                .PageSize(5)
                .ShowFooterRow()
                .ShowHeaderRow()
                .PagerPosition(PagerAt.Bottom);

            Column(x => x.Company);

            Column(x => x.Invoices).IsSortable(false);

            ButtonColumn("Add Invoice").Style(ButtonStyle.Link)
                .OnClick(x => x.Go<Client.AddInvoicePage>()
                .SendReturnUrl()
                .Send("client", "item.ID"));

            column.Edit<Client.EnterPage>();
            column.Delete();
            button.New<Client.EnterPage>();
          
        }
    }
}