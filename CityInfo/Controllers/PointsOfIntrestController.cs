using CityInfo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.Controllers
{
    [Route("api/cities/{cityId}/PointsOfIntrest")]
    [ApiController]
    public class PointsOfIntrestController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<PointOfInterestDto>> GetPointsOfInterets(int cityId)
        {
            var city = CityDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityId);
            if (city == null)
            {
                return NotFound();
            }
            return Ok(city.PointOfInterests);
        }
        [HttpGet("{PointOfInterestid}")]
        public ActionResult<PointOfInterestDto> GetPointsOfInterets(int cityId, int pointOfInterestId)
        {
            var city = CityDataStore.Current.Cities.FirstOrDefault(c=> c.Id == cityId);
            if (city == null )
            {
                return NotFound();
            }

            // find point of interest
           /* var PointsOfInteret = city.PointOfInterests.FirstOrDefault(c=>c.Id==pointOfInterestId);
            if(!PointsOfInteret == null)
            {
                return NotFound();
            }*/
           /* return Ok(PointsOfInteret);*/
        }


    }
}
