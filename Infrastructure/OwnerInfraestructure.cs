using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Interface;
using Entities;
using Microsoft.EntityFrameworkCore;
using Entities.Context;

namespace Infrastructure
{
    public class OwnerInfraestructure : IOwnerInfraestructureInterfeace
    {
        public readonly weeloContext _weeloContext;

        public OwnerInfraestructure(weeloContext weeloContext)
        {
            _weeloContext = weeloContext;
        }

        public async Task AddOwner(Owner owner)
        {
            _weeloContext.Add(owner);
            await _weeloContext.SaveChangesAsync();
        }

        public async Task<List<Owner>> GetOwnerToList()
        {
            return await _weeloContext.Owner.ToListAsync();
        }
    }
}
