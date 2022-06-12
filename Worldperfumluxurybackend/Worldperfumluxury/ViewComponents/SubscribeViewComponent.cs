using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Worldperfumluxury.ViewComponents
{
    public class SubscribeViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {


            return (await Task.FromResult(View()));
        }
    }
}
