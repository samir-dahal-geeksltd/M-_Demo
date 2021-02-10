using MSharp;

namespace Category
{
    class EnterPage : SubPage<ProductCategoryPage>
    {
        public EnterPage()
        {
            Add<Modules.CategoryForm>();
        }
    }
}