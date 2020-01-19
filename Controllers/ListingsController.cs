using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RvEzy.Api.Dto;
using RvEzy.Models.Entities;
using RvEzzy.Services;
using RvEzzy.Services.Interface;

namespace RvEzy.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListingsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IListingService _listingService;
        public ListingsController(ListingsService listingService, IMapper mapper)
        {
            _listingService = listingService;
            _mapper = mapper;
        }


        // GET api/values
        [HttpGet]
        public List<ListingDto> Get([FromQuery] ListingPagination listingPagination)
        {
            var listing = _listingService.Get(listingPagination);
            var mappedResult = _mapper.Map<List<Listings>, List<ListingDto>>(listing);
            return mappedResult.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ListingDto Get(int id)
        {
            var listing = _listingService.Get(id);
            var mappedResult = _mapper.Map<Listings, ListingDto>(listing);
            return mappedResult;
        }


        // POST: api/Listings
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Listings/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
