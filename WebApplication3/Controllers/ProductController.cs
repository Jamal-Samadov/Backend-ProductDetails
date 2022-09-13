using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebApplication3.Controllers
{
    public class ProductController : Controller
    {
        public List<ShopItems> _items;
        private string[] imgs =
            {
            "https://mir.az/uploads/posts/2022-01/unnamed.webp",
            "https://assets1.bmstatic.com/assets/books-covers/1b/b9/ipad-e83c8eba0764149c627ea9f83510d8cc.jpeg",
            "https://static.insales-cdn.com/images/products/1/4693/171070037/large_ce407d11bf7268af357adbd37a271c8e.jpg"
            };
        public ProductController()
        {

            _items = new List<ShopItems>();
            _items.Add(new ShopItems { Id = 1, Name = "Da Vinçi şifrəsi", Title = "İntellektual baxışlı kitab", Url = imgs[0], Price = 30 });
            _items.Add(new ShopItems { Id = 2, Name = "Çərpələng Uçuran", Title = "dostluq, sədaqət, xəyanət, günahlardan təmizlənmə haqqındadır", Url = imgs[1], Price = 70 });
            _items.Add(new ShopItems { Id = 3, Name = "Əli və Nino", Title = "Ölməz şedevr... Bədii ədəbiyyatda buna oxşar heç bir məhəbbət tarixiniz xatırlaya bilməzsiniz", Url = imgs[2], Price = 888 });

        }


        public IActionResult Index()
        {
            return View(_items);
        }

        public IActionResult Detail(int? id)
        {
            if (id is null) return BadRequest();
           ShopItems shopItem = _items.Find(n => n.Id == id);
            if (shopItem is null) return NotFound();
            return View(shopItem);
            
        }
    }
}
