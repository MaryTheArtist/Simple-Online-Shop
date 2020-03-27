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
    public class ItemController : Controller
    {
        private readonly IItemRepository _itemRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ItemController(IItemRepository itemRepository, ICategoryRepository categoryRepository)
        {
            _itemRepository = itemRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List(string category)
        {
            IEnumerable<Item> items;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                items = _itemRepository.AllItems.OrderBy(i => i.ItemId);
                currentCategory = "All items";
            }
            else
            {
                items = _itemRepository.AllItems.Where(i => i.Category.CategoryName == category).OrderBy(i => i.ItemId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new ItemsListViewModel
            {
                Items = items,
                CurrentCategory = currentCategory
            });



            //ItemsListViewModel itemsListViewModel = new ItemsListViewModel();
            //itemsListViewModel.Items = _itemRepository.AllItems;

            //itemsListViewModel.CurrentCategory = "Paintings";
            //return View(itemsListViewModel);
        }

        public IActionResult Details (int id)
        {
            var item = _itemRepository.GetItemById(id);
            if (item == null)
            {
                return NotFound();
            }
            return View(item);




        }
    }
}
