using Microsoft.AspNetCore.Mvc;
using CityInfo.Models;

namespace CityInfo.Controllers
{
    [ApiController]
    //[Route("api/cities")]
    public class CitiesController:ControllerBase
    {
        [HttpGet]
        public JsonResult GetCities()
        {
            return new JsonResult(CityDataStore.Current.Cities);
        }

        [HttpGet("{id}")]
        public ActionResult<CityDto>  GetCity(int id) 
        {
            var cityToReturn = CityDataStore.Current.Cities
                .FirstOrDefault(x => x.Id == id);

            return Ok(cityToReturn);
            /*return new JsonResult(CityDataStore.Current.Cities.FirstOrDefault(c=>c.Id == id));
            */
        }
    }
}
