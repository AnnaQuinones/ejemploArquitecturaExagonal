using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Domain.Interface
{
    public interface IOwnerInterface
    {
        /// <summary>
        /// Get Owner ToList
        /// </summary>
        /// <returns>List<Owner></returns>
        Task<List<Owner>> GetOwnerToList();

        /// <summary>
        /// AddOwner
        /// </summary>
        Task AddOwner(Owner owner);
    }
}
