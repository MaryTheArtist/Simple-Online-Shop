using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CraftShop1.Models
{
    public class MockItemRepository : IItemRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Item> AllItems =>
            new List<Item>
            {
                new Item {ItemId=1, Name="Mother's Day Card", Price= 5.90M, Description="Hand crafted greeting card", InStock=true, Category = _categoryRepository.AllCategories.ToList()[2], ImageThumbnailUrl="https://scontent.fsof1-2.fna.fbcdn.net/v/t1.0-9/11013484_1575181452757148_3321343474947019084_n.jpg?_nc_cat=108&_nc_sid=a61e81&_nc_ohc=WRjPJmNZHKwAX_I3-Cj&_nc_ht=scontent.fsof1-2.fna&oh=c125accdcde82299ac990e7b9328c892&oe=5EF1D30B"},
                new Item {ItemId=2, Name="Bottle", Price=28.90M, Description="Handmade bottle with the Decoupage technique", InStock=true, Category = _categoryRepository.AllCategories.ToList()[1], ImageThumbnailUrl="https://scontent.fsof1-2.fna.fbcdn.net/v/t1.0-9/56435205_2379692425639376_6435375526545719296_n.jpg?_nc_cat=110&_nc_sid=a61e81&_nc_ohc=2oTtD4PEenoAX_5nsy5&_nc_ht=scontent.fsof1-2.fna&oh=e8efdc2f895ce04d3716e5842cd18e44&oe=5EC6CC17"},
                new Item {ItemId=3, Name="Sunset", Price=109.90M, Description="Acrylic painting, size: 30x40 cm", InStock=false, Category = _categoryRepository.AllCategories.ToList()[0], ImageThumbnailUrl="https://scontent.fsof1-2.fna.fbcdn.net/v/t1.0-9/p720x720/71178198_2513146108960673_8218008218215907328_o.jpg?_nc_cat=108&_nc_sid=a61e81&_nc_ohc=GDKNc8HQFRoAX8H7f8Y&_nc_ht=scontent.fsof1-2.fna&_nc_tp=6&oh=a22ff183b5146021a9737a7cd357c6dd&oe=5EB577F3"},
                new Item {ItemId=4, Name="Morning Cat", Price= 99.90M, Description="Acrylic painting, size: 30x40 cm", InStock=true, Category = _categoryRepository.AllCategories.ToList()[0],ImageThumbnailUrl="https://scontent.fsof1-1.fna.fbcdn.net/v/t1.0-9/26055665_2059839840957971_3050193840913806679_n.jpg?_nc_cat=103&_nc_sid=a61e81&_nc_ohc=5x7E_uPlJB8AX-KldaP&_nc_ht=scontent.fsof1-1.fna&oh=75186134e41f8f6871ad99a658e5117c&oe=5EF3F85E"}
            };

        public Item GetItemById(int itemId)
        {
            return AllItems.FirstOrDefault(i => i.ItemId == itemId);
        }
    }
}
