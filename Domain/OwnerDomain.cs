using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Domain.Interface;
using Entities;
using Infrastructure.Interface;

namespace Domain
{
    public class OwnerDomain : IOwnerInterface
    {
        public readonly IOwnerInfraestructureInterfeace _ownerInfraestructureInterfeace;

        public OwnerDomain(IOwnerInfraestructureInterfeace ownerInfraestructureInterfeace)
        {
            _ownerInfraestructureInterfeace = ownerInfraestructureInterfeace;
        }

        public async Task AddOwner(Owner owner)
        {
            await _ownerInfraestructureInterfeace.AddOwner(owner);
        }

        public async Task<List<Owner>> GetOwnerToList()
        {
            return await _ownerInfraestructureInterfeace.GetOwnerToList();
        }
    }
}
