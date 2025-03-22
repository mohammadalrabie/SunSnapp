using Microsoft.AspNetCore.Mvc;
using SunSnap.Data;
using SunSnap.Data.Migrations;
using SunSnap.Models;
using System;
using System.Linq;
//hhh
namespace SunSnap.Controllers
{


    //tttt 
    public class PhotosController : Controller
    { 

        private readonly ApplicationDbContext _context;

        public PhotosController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
            


        
        public IActionResult SunLocationRequest(SunLocationRequest request, double latitude, string UploadDate, TimeSpan SunRiseTime, TimeSpan SunSetTime)
        {
            const double EarthAxialTilt = 23.44;
            const double SolarConstant = 0.986;


            if (DateTime.TryParse(UploadDate, out DateTime userDateTime))
            {
                TimeSpan currentTime = userDateTime.TimeOfDay;
                int dayOfYear = userDateTime.DayOfYear;
                double solarAngle = EarthAxialTilt * Math.Cos((dayOfYear + 10) % 365 * SolarConstant) + (90 - latitude);

                bool isDayTime = currentTime >= SunRiseTime && currentTime <= SunSetTime;
                bool BelowHorizon = solarAngle > 0 && isDayTime;
                if (BelowHorizon)
                {
                    var query = _context.Photos.Where(p => p.Id == 6).ToList();
                    return View(query);
                }
                var dayQuery = _context.Photos
                    .Where(p => (p.PeriodStart <= p.PeriodEnd && currentTime >= p.PeriodStart && currentTime <= p.PeriodEnd) ||
                                (p.PeriodStart > p.PeriodEnd && (currentTime >= p.PeriodStart || currentTime <= p.PeriodEnd)))
                    .ToList();

                return View(dayQuery);
            }

            return View(new List<Photo>());
        }






    }
}
