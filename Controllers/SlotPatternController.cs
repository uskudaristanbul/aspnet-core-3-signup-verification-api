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
    public class SlotPatternController : ControllerBase
    {
        private readonly DataContext _context;

        public SlotPatternController(DataContext context)
        {
            _context = context;
        }


        [HttpGet("{store_id}")]
        [ActionName("GetStoreSlotPattern")]
        public async Task<ActionResult<string>> GetStoreSlotPattern(int store_id, string postcode)
        {
            var GeneralDefaultPattern = await _context.SlotPattern.Where(x => x.GeneralDefaultSlot == true).ToListAsync();
            if (postcode!=null)
            {
                //postcode = "ABC";
                string SessionPostcode = postcode;
                int servicelevel = _context.Postcode.Where(x => x.PostcodeText == postcode).FirstOrDefault().ServiceLevel.GetValueOrDefault();
                //HttpContext.Session.GetString(SessionPostcode);
                DateTime today = DateTime.Today;
                string dayname = today.DayOfWeek.ToString();
                
                #region Store day date calculation commented
                //var StoreDefaultPatter = await _context.SlotPattern.Where(x => x.StoreId == store_id).ToListAsync();
                //var GetCurrentStoreSlotPattern = await _context.SlotPattern.Where(x => x.StoreId == store_id && x.IsDefault == true).ToListAsync();
                string TodayName = today.DayOfWeek.ToString();
                string TomorrowName = today.AddDays(1).DayOfWeek.ToString();
                string NextDayName = today.AddDays(2).DayOfWeek.ToString();
                string ThirdDayName = today.AddDays(3).DayOfWeek.ToString();
                string FourthDayName = today.AddDays(4).DayOfWeek.ToString();
                string FifthDayName = today.AddDays(5).DayOfWeek.ToString();
                string SixthDayName = today.AddDays(6).DayOfWeek.ToString();

                //var TodayStoreSlotPattern = GetCurrentStoreSlotPattern.Where(x => x.Date == today);
                //var TomorrowStoreSlotPattern =  GetCurrentStoreSlotPattern.Where(x => x.Date == today.AddDays(1));
                //var NextDayStoreSlotPattern = GetCurrentStoreSlotPattern.Where(x => x.Date == today.AddDays(2));
                //var ThirdDayStoreSlotPattern = GetCurrentStoreSlotPattern.Where(x => x.Date == today.AddDays(3));
                //var FourthStoreSlotPattern = GetCurrentStoreSlotPattern.Where(x => x.Date == today.AddDays(4));
                //var FifthDayStoreSlotPattern =  GetCurrentStoreSlotPattern.Where(x => x.Date == today.AddDays(5));
                //var SixthDayStoreSlotPattern =  GetCurrentStoreSlotPattern.Where(x => x.Date == today.AddDays(6));
                #endregion
                var slots = GeneralDefaultPattern;
                if (servicelevel == 1)
                {
                    GeneralDefaultPattern = GeneralDefaultPattern.Where(x => x.ServiceLevel == 1).ToList();
                }
                if (servicelevel == 2)
                {
                    GeneralDefaultPattern = GeneralDefaultPattern.Where(x => x.ServiceLevel == 2).ToList();
                }
                if (servicelevel == 3)
                {
                    GeneralDefaultPattern = GeneralDefaultPattern.Where(x => x.ServiceLevel == 3).ToList();
                }

                //Gunlere tarih atiyoruz
                GeneralDefaultPattern.Where(x => x.Day == TodayName).FirstOrDefault().Date = DateTime.Today;
                GeneralDefaultPattern.Where(x => x.Day == TomorrowName).FirstOrDefault().Date = DateTime.Today.AddDays(1);
                GeneralDefaultPattern.Where(x => x.Day == NextDayName).FirstOrDefault().Date = DateTime.Today.AddDays(2);
                GeneralDefaultPattern.Where(x => x.Day == ThirdDayName).FirstOrDefault().Date = DateTime.Today.AddDays(3);
                GeneralDefaultPattern.Where(x => x.Day == FourthDayName).FirstOrDefault().Date = DateTime.Today.AddDays(4);
                GeneralDefaultPattern.Where(x => x.Day == FifthDayName).FirstOrDefault().Date = DateTime.Today.AddDays(5);
                GeneralDefaultPattern.Where(x => x.Day == SixthDayName).FirstOrDefault().Date = DateTime.Today.AddDays(6);

            }
            

            //var result = from s in GeneralDefaultPattern
            //             select c
            //select new { day = s.Day, 
            //    s.Date, s.GeneralDescription, s.IsActive, 
            //    s.Id, s.IsAvailable, s.ExpressDeliveryIsAvailable, 
            //    s.Btw811available,s.Btw2023available, s.Btw1720available,
            //    s.Btw1417available,s.Btw1114available, 
            //    s.ServiceLevelDeliveryFee, s.ExpressDeliveryFee, s.ServiceFeeForUnder, s.ServiceLevel};
            var JsonResult = JsonConvert.SerializeObject(GeneralDefaultPattern);
            return JsonResult;
        }

        // GET: api/SlotPattern
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SlotPattern>>> GetSlotPattern()
        {
            return await _context.SlotPattern.ToListAsync();
        }

        // GET: api/SlotPattern/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SlotPattern>> GetSlotPattern(int id)
        {
            var slotPattern = await _context.SlotPattern.FindAsync(id);

            if (slotPattern == null)
            {
                return NotFound();
            }

            return slotPattern;
        }

        // PUT: api/SlotPattern/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSlotPattern(int id, SlotPattern slotPattern)
        {
            if (id != slotPattern.Id)
            {
                return BadRequest();
            }

            _context.Entry(slotPattern).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SlotPatternExists(id))
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

        // POST: api/SlotPattern
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<SlotPattern>> PostSlotPattern(SlotPattern slotPattern)
        {
            _context.SlotPattern.Add(slotPattern);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSlotPattern", new { id = slotPattern.Id }, slotPattern);
        }

        // DELETE: api/SlotPattern/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SlotPattern>> DeleteSlotPattern(int id)
        {
            var slotPattern = await _context.SlotPattern.FindAsync(id);
            if (slotPattern == null)
            {
                return NotFound();
            }

            _context.SlotPattern.Remove(slotPattern);
            await _context.SaveChangesAsync();

            return slotPattern;
        }

        private bool SlotPatternExists(int id)
        {
            return _context.SlotPattern.Any(e => e.Id == id);
        }
    }
}
