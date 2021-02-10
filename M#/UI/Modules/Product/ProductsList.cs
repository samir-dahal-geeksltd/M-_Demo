using MSharp;

namespace Modules
{
    public class ProductsList : ListModule<Domain.Product>
    {
        public ProductsList()
        {
            HeaderText("Products");

            ShowHeaderRow();

            Column(x => x.Name);
            Column(x => x.Category);
            Column(x => x.Shops);

            column.Edit<Product.EnterPage>();
            column.Delete();
            //ButtonColumn("Edit").Icon(FA.Edit)
            //    .HeaderText("Edit").GridColumnCssClass("actions")
            //    .OnClick(x => x.Go<Product.EnterPage>()
            //    .SendItemId()
            //    .SendReturnUrl());

            //ButtonColumn("Delete").Icon(FA.Remove)
            //    .HeaderText("Delete").GridColumnCssClass("actions")
            //    .ConfirmQuestion("Are you sure you want to delete this Product?")
            //    .CssClass("btn-danger")
            //   .OnClick(x =>
            //   {
            //       x.DeleteItem();
            //       x.RefreshPage();
            //   });

            //Button("Add").Icon(FA.Plus)
            //    .OnClick(x => x.Go<Product.EnterPage>()
            //    .SendReturnUrl());

            button.New<Product.EnterPage>();
        }
    }
}