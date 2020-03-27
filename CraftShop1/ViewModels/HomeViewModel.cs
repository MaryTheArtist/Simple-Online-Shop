using CraftShop1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CraftShop1.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Item> ItemOfTheWeek { get; set; }
    }
}
