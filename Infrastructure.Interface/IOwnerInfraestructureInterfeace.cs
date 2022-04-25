using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Infrastructure.Interface
{
    public interface IOwnerInfraestructureInterfeace
    {
        /// <summary>
        /// Get Owner ToList
        /// </summary>
        /// <returns>List<Owner></returns>
        Task<List<Owner>> GetOwnerToList();

        /// <summary>
        /// Add Owner
        /// </summary>
        Task AddOwner(Owner owner);
    }
}
