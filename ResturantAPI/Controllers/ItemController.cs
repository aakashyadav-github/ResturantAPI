using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ResturantAPI.ItemData;
using ResturantAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResturantAPI.Controllers
{
    [ApiController]
    public class ItemController : ControllerBase
    {
        private IItemData _itemData;

        public ItemController(IItemData itemData)
        {
            _itemData = itemData;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetItems()
        {
           return Ok(_itemData.GetItems());
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetItem(Guid id)
        {
            var item = _itemData.GetItem(id);
            if (item != null)
            {
                return Ok(_itemData.GetItem(id));
            }
            return NotFound($"Item with id: {id} not found");
            
        }
        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult AddItem(Item item)
        {
            _itemData.AddItem(item);
            return Ok(item);

        }
        [HttpGet]
        [Route("api/[controller]/Cat")]
        public IActionResult GetItems(string Cat, string SubCat)
        {
            return Ok(_itemData.GetItemByCatAndSubCat(Cat,SubCat));
        }

    }
}
