using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using InsecureDirectObjectReference.Models;
using InsecureDirectObjectReference.Utility;
using InsecureDirectObjectReference.Repository;
using Microsoft.AspNetCore.Mvc.Filters;

namespace InsecureDirectObjectReference.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly AccountRepository accountRepository;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            accountRepository = new AccountRepository();
        }

        public override void OnActionExecuting(ActionExecutingContext ctx)
        {
            base.OnActionExecuting(ctx);
            if (HttpContext.Session.Get<User>("User") == null)
            {
                HttpContext.Session.Set<User>("User", new User()
                                                        {
                                                            ID = 2,
                                                            Username = "jdoe",
                                                            FullName = "John Doe"
                                                        });
            }
        }

        public IActionResult Index()
        {
            ViewBag.CurrentUser = HttpContext.Session.Get<User>("User");
            return View(accountRepository.GetAccounts(ViewBag.CurrentUser.ID));
        }

        public ActionResult Detail(int id)
        {
            ViewBag.CurrentUser = HttpContext.Session.Get<User>("User");
            
            var account = accountRepository.GetAccount(id);
            
            if(account == null)
            {
                account = new Account();
            }

            return View(account);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
