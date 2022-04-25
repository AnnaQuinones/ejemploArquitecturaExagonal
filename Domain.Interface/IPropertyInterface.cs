using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface IPropertyInterface
    {
        /// <summary>
        /// CreateProperty
        /// </summary>
        /// <param name="property"></param>
        /// <returns></returns>
        Task CreateProperty(Property property);

        /// <summary>
        /// GetPropertyByIdProperty
        /// </summary>
        /// <param name="idProperty"></param>
        /// <returns>Property</returns>
        Task<Property> GetPropertyByIdProperty(int idProperty);

        /// <summary>
        /// UpdateProperty
        /// </summary>
        /// <param name="property"></param>
        /// <param name="idProperty"></param>
        /// <returns></returns>
        Task UpdateProperty(Property property, int idProperty);

        /// <summary>
        /// SearchFilters
        /// </summary>
        /// <param name="searchFilters"></param>
        /// <returns></returns>
        Task<List<Property>> SearchFilters(SearchFilters searchFilters);
    }
}
