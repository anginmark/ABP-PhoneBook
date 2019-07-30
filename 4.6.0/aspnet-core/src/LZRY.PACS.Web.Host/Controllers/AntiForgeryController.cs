using Microsoft.AspNetCore.Antiforgery;
using LZRY.PACS.Controllers;

namespace LZRY.PACS.Web.Host.Controllers
{
    public class AntiForgeryController : PACSControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
