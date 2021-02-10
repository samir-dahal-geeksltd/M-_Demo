using MSharp;

namespace Modules
{
    public class AgencyView : ViewModule<Domain.Agency>
    {
        public AgencyView()
        {
            HeaderText("Agency: @item.Name");

            Field(x => x.Notes);
        }
    }
}