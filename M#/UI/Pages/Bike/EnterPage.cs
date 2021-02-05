using MSharp;

namespace Bike
{
    class EnterPage : SubPage<BikePage>
    {
        public EnterPage()
        {
            Add<Modules.BikeForm>();
        }
    }
}