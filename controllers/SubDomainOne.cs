using Microsoft.AspNetCore.Mvc;

namespace subdomain_routing.controllers {
    public class SubDomainOneController : Controller {
        public IActionResult Index() {
            return Json(new {name = "SubDomainOne"});
        }
    }
}