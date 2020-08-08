using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using WebApi.Entities;
using WebApi.Helpers;

namespace WebApi.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    [EnableCors("ApiPolicy")]
    public class CategoryController : ControllerBase
    {
        private readonly DataContext _context;

        public CategoryController(DataContext context)
        {
            _context = context;
        }




        [HttpGet]
        [ActionName("AllCategories")]
        public async Task<ActionResult<string>> GetAllCategory()
        {
            var UpCategories = from c in _context.Category
                               where c.IsTopProductCategory == true
                               select new
                               {
                                   CatId = c.Id,
                                   CategoryName = c.Name,
                                   CatOrderNumber = c.OrderNumber,
                                   LowCat = c.InverseUpCategory.Select(k => new { Name = k.Name, CatId = k.Id, k.IsTopProductCategory, CatList = k.InverseUpCategory.Select(y => new { y.Name, y.Id, y.OrderNumber, y.IsTopProductCategory }) }).ToList()
                               };

            //var result = _context.Category.SelectMany(x=>x.InverseUpCategory.
            //Select(y=> new {SubCategories = y.Id, y.Name, y.UpCategoryId, y.InverseUpCategory.Select
            //(k=> new { lowCategories = k.Name, k.Id }) )
            //)
            var JsonCategories = JsonConvert.SerializeObject(UpCategories);
            return JsonCategories;
        }

        //        var result = teachers.SelectMany(x => x.Classes.
        //Select(y => new { description = y.Description, day = y.DayOFWeek, startAt = y.StartTime, endAt = y.EndTime, teacher = x.Name, teacherPhone = x.Phone }));

        [ActionName("TopCategories")]
        [HttpGet]
        public async Task<ActionResult<string>> GetTopCategory()
        {
            var UpCategories = from c in _context.Category
                               where c.IsTopProductCategory == true
                               select new { c.Id, c.Name, c.OrderNumber };
            var JsonUpCategories = JsonConvert.SerializeObject(UpCategories);
            string result = JsonUpCategories;
            return result;
        }

        // GET: api/Category/ProductSub
        [ActionName("SubCategories")]
        [HttpGet]
        public async Task<ActionResult<string>> GetSubCategory()
        {
            var UpCategories = from c in _context.Category
                               where c.IsTopProductCategory != true
                               select new { c.Id, c.Name, c.OrderNumber, c.UpCategoryId };
            var JsonUpCategories = JsonConvert.SerializeObject(UpCategories);
            string result = JsonUpCategories;
            return result;


            //var SubCategories = from c in _context.Category
            //                    join sc in _context.Category.Where(sc => sc.IsTopProductCategory == false)
            //                    on c.UpCategoryId equals sc.Id
            //                    select new { SubCat = c.UpCategoryId, c.Name, c.Id };
            //var JsonCategories = JsonConvert.SerializeObject(SubCategories);
            //string result = JsonCategories;
            //return result;
        }


        // GET: api/Category/ProductSub
        [ActionName("StoreTop")]
        [HttpGet]
        public async Task<ActionResult<string>> GetStoreCategory()
        {
            var StoreUpCategories = from c in _context.StoreCategory
                                    where c.Up == 1
                                    select new { UpCat = c.Id, c.Name };
            var JsonUpCategories = JsonConvert.SerializeObject(StoreUpCategories);
            string result = JsonUpCategories;
            return result;
        }

        // GET: api/Category/ProductSub
        [ActionName("StoreSub")]
        [HttpGet]
        public async Task<ActionResult<string>> GetStoreSubCategory()
        {
            var SubCategories = from c in _context.StoreCategory
                                join sc in _context.StoreCategory.Where(sc => sc.Up == 1)
                                on c.Up equals sc.Id
                                select new { SubCat = c.Name, c.Up };
            var JsonCategories = JsonConvert.SerializeObject(SubCategories);
            string result = JsonCategories;
            return result;
        }






















        // GET: api/Category
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> GetCategory()
        {
            return await _context.Category.ToListAsync();
        }

        // GET: api/Category/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Category>> GetCategory(int id)
        {
            var category = await _context.Category.FindAsync(id);

            if (category == null)
            {
                return NotFound();
            }

            return category;
        }

        // PUT: api/Category/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategory(int id, Category category)
        {
            if (id != category.Id)
            {
                return BadRequest();
            }

            _context.Entry(category).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategoryExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Category
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Category>> PostCategory(Category category)
        {
            _context.Category.Add(category);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCategory", new { id = category.Id }, category);
        }

        // DELETE: api/Category/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Category>> DeleteCategory(int id)
        {
            var category = await _context.Category.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }

            _context.Category.Remove(category);
            await _context.SaveChangesAsync();

            return category;
        }

        private bool CategoryExists(int id)
        {
            return _context.Category.Any(e => e.Id == id);
        }
    }
}
