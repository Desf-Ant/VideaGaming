using Microsoft.AspNetCore.Mvc;
using VidyaGaming.BL.Contracts;
using VidyaGaming.DAL;

namespace VidyaGaming.Controllers
{
    public class GameController : Controller
    {

        IGameService _gameService;

        public GameController(IGameService gameService)
        {
            _gameService = gameService;
        }

        public IActionResult Index()
        {
            return View(_gameService.GetAll());
        }

		[HttpGet]
		public IActionResult Search()
		{
			return View();
		}

		[HttpPost]
		
		public IActionResult Search(String name)
		{
			
			return View(_gameService.GetByName(name));
		}
	}
}
