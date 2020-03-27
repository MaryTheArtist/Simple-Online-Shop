using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CraftShop1.Models
{
    public class ItemRepository: IItemRepository
    {
        private readonly AppDbContext _appDbContext;

        public ItemRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Item> AllItems
        {
            get
            {
                return _appDbContext.Items.Include(c => c.Category);
            }
        }

        

        public Item GetItemById(int itemId)
        {
            return _appDbContext.Items.FirstOrDefault(i => i.ItemId == itemId);
        }
    }

    
}
