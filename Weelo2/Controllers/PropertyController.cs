using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Interface;
using Weelo2.Models;
using Entities;
using AutoMapper;

namespace Weelo2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyController : Controller
    {
        public readonly IPropertyInterface _propertyInterface;
        public readonly IMapper _mapper;

        public PropertyController(IPropertyInterface propertyInterface,IMapper mapper)
        {
            _propertyInterface = propertyInterface;
            _mapper = mapper;
        }

        /// <summary>
        /// AddProperty
        /// </summary>
        /// <param name="propertyRequest"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> AddProperty([FromBody] PropertyRequest propertyRequest)
        {
            Property property = _mapper.Map<Property>(propertyRequest);
            await _propertyInterface.CreateProperty(property);
            return Ok();
        }

        /// <summary>
        /// UpdatePriceProperty
        /// </summary>
        /// <param name="price"></param>
        /// <returns></returns>
        [HttpPut("{idProperty}")]
        public async Task<IActionResult> UpdatePriceProperty([FromBody] PropertyRequest propertyRequest, int idProperty)
        {
            Property property = _mapper.Map<Property>(propertyRequest);
            await _propertyInterface.UpdateProperty(property, idProperty);
            return Ok();
        }


        /// <summary>
        /// GetPropertyByIdProperty
        /// </summary>
        /// <param name="idProperty"></param>
        /// <returns></returns>
        [HttpGet("{idProperty}")]
        public async Task<IActionResult> GetPropertyByIdProperty(int idProperty)
        {
            return Ok(await _propertyInterface.GetPropertyByIdProperty(idProperty));
        }

        /// <summary>
        /// GetSearchFilters
        /// </summary>
        /// <param name="idProperty"></param>
        /// <returns></returns>
        [HttpGet("Filters")]
        public async Task<IActionResult> GetSearchFilters([FromQuery] SearchFilters searchFilters)
        {
            List<Property> properties = await _propertyInterface.SearchFilters(searchFilters);
            List<PropertyResponse> propertyResponse = _mapper.Map<List<PropertyResponse>>(properties);
            return Ok(propertyResponse);
        }
    }
}
