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
    public class PropertyImageController : Controller
    {
        public readonly IPropertyImageInterface _propertyImageInterface;
        public readonly IMapper _mapper;

        public PropertyImageController(IPropertyImageInterface propertyImageInterface, IMapper mapper)
        {
            _propertyImageInterface = propertyImageInterface;
            _mapper = mapper;
        }

        /// <summary>
        /// AddPropertyImage
        /// </summary>
        /// <param name="propertyImageRequest"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> AddPropertyImage([FromBody] PropertyImageRequest propertyImageRequest)
        {
            PropertyImage propertyImage = _mapper.Map<PropertyImage>(propertyImageRequest);
            await _propertyImageInterface.CreatePropertyImage(propertyImage);
            return Ok();
        }
    }
}
