using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interface
{
    public interface IPropertyInfraestructureInterface
    {
        /// <summary>
        /// CreateProperty
        /// </summary>
        /// <param name="property"></param>
        /// <returns></returns>
        Task CreateProperty(Property property);

        /// <summary>
        /// UpdatePriceProperty
        /// </summary>
        /// <param name="property"></param>
        /// <returns></returns>
        Task UpdateProperty(Property property);

        /// <summary>
        /// GetPropertyByIdProperty
        /// </summary>
        /// <param name="idProperty"></param>
        /// <returns>Property</returns>
        Task<Property> GetPropertyByIdProperty(int idProperty);

        /// <summary>
        /// SearchFilters
        /// </summary>
        /// <param name="searchFilters"></param>
        /// <returns></returns>
        Task<List<Property>> SearchFilters(SearchFilters searchFilters);
    }
}
