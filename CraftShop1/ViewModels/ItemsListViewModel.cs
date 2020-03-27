using CraftShop1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CraftShop1.ViewModels
{
    public class ItemsListViewModel
    {
        public IEnumerable<Item> Items { get; set; }
        public string CurrentCategory { get; set; }
    }
}
