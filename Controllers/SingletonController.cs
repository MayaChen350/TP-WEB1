using Microsoft.AspNetCore.Mvc;
using TP_WEB.Models;

namespace TP_WEB.Controllers
{
    public class SingletonController : Controller
    {
        private BaseDeDonnees BD { get; set; }

        public SingletonController(BaseDeDonnees bd)
        {
            BD = bd;
        }
    }
}
