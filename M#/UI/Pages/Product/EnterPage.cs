using MSharp;

namespace Product
{
    class EnterPage : SubPage<ProductPage>
    {
        public EnterPage()
        {
            Add<Modules.ProductForm>();
        }
    }
}