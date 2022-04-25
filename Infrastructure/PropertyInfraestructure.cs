using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Entities.Context;
using Infrastructure.Interface;

namespace Infrastructure
{
    public class PropertyInfraestructure : IPropertyInfraestructureInterface
    {
        public readonly weeloContext _weeloContext;

        public PropertyInfraestructure(weeloContext weeloContext)
        {
            _weeloContext = weeloContext;
        }

        /// <summary>
        /// CreateProperty
        /// </summary>
        /// <param name="property"></param>
        /// <returns></returns>
        public async Task CreateProperty(Property property)
        {
            _weeloContext.Add(property);
            await _weeloContext.SaveChangesAsync();
        }

        /// <summary>
        /// GetPropertyByIdProperty
        /// </summary>
        /// <param name="idProperty"></param>
        /// <returns>Property</returns>
        public async Task<Property> GetPropertyByIdProperty(int idProperty)
        {
            return _weeloContext.Property.Where(a => a.IdProperty == idProperty).FirstOrDefault();
        }

        /// <summary>
        /// SearchFilters
        /// </summary>
        /// <param name="searchFilters"></param>
        /// <returns></returns>
        public async Task<List<Property>> SearchFilters(SearchFilters searchFilters)
        {
            return _weeloContext.Property
                .Where(a => searchFilters.Name == null || a.Name == searchFilters.Name)
                .Where(a => searchFilters.CodeInternal == null || a.CodeInternal == searchFilters.CodeInternal)
                .Where(a => (searchFilters.PriceMin == null && searchFilters.PriceMax == null) || (a.Price >= searchFilters.PriceMin && a.Price <= searchFilters.PriceMax)).ToList();
        }

        /// <summary>
        /// UpdatePriceProperty
        /// </summary>
        /// <param name="price"></param>
        /// <returns></returns>
        public async Task UpdateProperty(Property property)
        {
            _weeloContext.Update(property);
            await _weeloContext.SaveChangesAsync();
        }
    }
}
