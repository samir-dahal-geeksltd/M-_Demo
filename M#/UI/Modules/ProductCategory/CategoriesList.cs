using MSharp;

namespace Modules
{
    public class CategoriesList : ListModule<Domain.ProductCategory>
    {
        public CategoriesList()
        {
            HeaderText("Categories");

            ShowHeaderRow();

            Column(x => x.Name);
            Column(x => x.Products);

            column.Edit<Category.EnterPage>();
            column.Delete();

            //ButtonColumn("Edit").Icon(FA.Edit)
            //    .HeaderText("Edit").GridColumnCssClass("actions")
            //    .OnClick(x => x.Go<Category.EnterPage>()
            //    .SendItemId()
            //    .SendReturnUrl());

            //ButtonColumn("Delete").Icon(FA.Remove)
            //    .HeaderText("Delete").GridColumnCssClass("actions")
            //    .ConfirmQuestion("Are you sure you want to delete this Category?")
            //    .CssClass("btn-danger")
            //    .OnClick(x =>
            //    {
            //        x.DeleteItem();
            //        x.RefreshPage();
            //    });
            button.New<Category.EnterPage>();
            //Button("Add").Icon(FA.Plus)
            //    .OnClick(x => x.Go<Category.EnterPage>()
            //    .SendReturnUrl());
        }
    }
}