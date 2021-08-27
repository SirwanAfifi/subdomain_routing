using Microsoft.AspNetCore.Mvc;

namespace subdomain_routing.controllers {
    public class SubDomainTwoController : Controller {
        public IActionResult Index() {
            return Json(new {name = "SubDomainTwo"});
        }
    }
}