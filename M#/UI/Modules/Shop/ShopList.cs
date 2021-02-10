using MSharp;

namespace Modules
{
    public class ShopsList : ListModule<Domain.Shop>
    {
        public ShopsList()
        {
            HeaderText("Shops");

            ShowHeaderRow();

            Column(x => x.Name);
            Column(x => x.Address);
            Column(x => x.Products);

            //ButtonColumn("Edit").Icon(FA.Edit)
            //    .HeaderText("Edit").GridColumnCssClass("actions")
            //    .OnClick(x => x.Go<Shop.EnterPage>()
            //    .SendItemId()
            //    .SendReturnUrl());

            column.Edit<Shop.EnterPage>();
            column.Delete();
            //column.Delete().Icon(FA.Remove)
            //    .HeaderText("Delete").GridColumnCssClass("actions")
            //    .ConfirmQuestion("Are you sure you want to delete this Shop?")
            //    .CssClass("btn-danger")
            //   .OnClick(x =>
            //   {
            //       x.DeleteItem();
            //       x.RefreshPage();
            //   });
            button.New<Shop.EnterPage>();
            //Button("Add").Icon(FA.Plus)
            //    .OnClick(x => x.Go<Shop.EnterPage>()
            //    .SendReturnUrl());
        }
    }
}