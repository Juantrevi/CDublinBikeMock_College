
using DublinBikeMock.models;
using Microsoft.AspNetCore.Mvc;

namespace DublinBikeMock.Controllers;

[ApiController]
[Route("api/")]
public class BikeStationController : ControllerBase
{
    [HttpGet("bike-stations")]
    public ActionResult<BikeStation> ShowBikes()
    {
        List<BikeStation> bikeStations = new()
        {
            new BikeStation { Id = 1, Name = "name1", Bikes = 4 },
            new BikeStation { Id = 2, Name = "name2", Bikes = 5 },
            new BikeStation { Id = 3, Name = "name3", Bikes = 6 }
        };
        
    return Ok(bikeStations);
}



}