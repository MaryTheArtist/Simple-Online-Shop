using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CraftShop1.Models;
using CraftShop1.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CraftShop1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IItemRepository _itemRepository;

        public HomeController(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                ItemOfTheWeek = _itemRepository.AllItems
                //да добавя продукти на промоция*** 
            };
            return View(homeViewModel);
        }
    }
}
