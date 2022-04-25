using AutoMapper;
using Domain.Interface;
using Entities;
using Infrastructure.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Weelo2.Models;

namespace Weelo2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController : Controller
    {
        public readonly IOwnerInterface _ownerInterface;
        public readonly IOwnerInfraestructureInterfeace _ownerInfraestructureInterfeace;
        public readonly IMapper _mapper;

        public OwnerController(IOwnerInterface ownerInterface,IMapper mapper,IOwnerInfraestructureInterfeace ownerInfraestructureInterfeace)
        {
            _ownerInterface = ownerInterface;
            _mapper = mapper;
            _ownerInfraestructureInterfeace = ownerInfraestructureInterfeace;
        }

        /// <summary>
        /// Add Owner
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> AddOwner([FromBody] OwnerRequest ownerRequest)
        {
            Owner owner = _mapper.Map<Owner>(ownerRequest);
            await _ownerInterface.AddOwner(owner);
            return Ok();
        }

        /// <summary>
        /// GetOwnerAll
        /// </summary>
        /// <returns>List<OwnerResponse></returns>
        [HttpGet("all")]
        public async Task<IActionResult> GetOwnerAll()
        {
            List<OwnerResponse> ownerResponse = _mapper.Map<List<OwnerResponse>>(await _ownerInfraestructureInterfeace.GetOwnerToList());
            return Ok(ownerResponse);
        }
    }
}
