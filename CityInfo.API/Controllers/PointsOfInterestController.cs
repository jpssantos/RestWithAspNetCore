using CityInfo.API.models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Controllers
{
    [ApiController]
    [Route("api/cities/{cityId}/pointsofinterest")]
    public class PointsOfInterestController : ControllerBase
    {
        [HttpGet("")]
        public IActionResult GetPointOfInterest(int cityId)
        {

            var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityId);

            if (city == null)
            {
                return NotFound();
            }
            return Ok(city.PointsOfInterest);
        }
        [HttpGet("{id}",Name="GetPointOfInterest")]
        public IActionResult GetPointOfInterest(int cityId,int Id)
        {

            var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityId);

            if (city == null)
            {
                return NotFound();
            }
            var pointOfInterest = city.PointsOfInterest.FirstOrDefault(p => p.Id == Id);
            if (pointOfInterest == null) {
                return NotFound();
            }
            return Ok(pointOfInterest);
        }
        [HttpPost]
        public IActionResult CreationPointOfInterest(int cityId, [FromBody]PointOfInterestForCreationDto pointOfInterest)
        {
            var cityReturn = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityId);
            if (cityReturn == null)
            {
                return NotFound();
            }
            var maxPointOfInterest = CitiesDataStore.Current.Cities.SelectMany(c => c.PointsOfInterest).Max(p=>p.Id);
            var finalPointOfInterest = new PointOfInterestDto()
            {
                Id = ++maxPointOfInterest,
                Name = pointOfInterest.Name,
                Description = pointOfInterest.Description
            };

            cityReturn.PointsOfInterest.Add(finalPointOfInterest);
            return CreatedAtRoute("GetPointOfInterest",new { cityId,id=finalPointOfInterest.Id},finalPointOfInterest);

        }
    }
}
