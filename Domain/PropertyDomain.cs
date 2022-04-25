using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Domain.Interface;
using Entities;
using Infrastructure.Interface;

namespace Domain
{
    public class PropertyDomain : IPropertyInterface
    {
        public readonly IPropertyInfraestructureInterface _propertyInfraestructureInterface;

        public PropertyDomain(IPropertyInfraestructureInterface propertyInfraestructureInterface)
        {
            _propertyInfraestructureInterface = propertyInfraestructureInterface;
        }

        /// <summary>
        /// CreateProperty
        /// </summary>
        /// <param name="property"></param>
        /// <returns></returns>
        public async Task CreateProperty(Property property)
        {
            await _propertyInfraestructureInterface.CreateProperty(property);
        }

        /// <summary>
        /// GetPropertyByIdProperty
        /// </summary>
        /// <param name="idProperty"></param>
        /// <returns>Property</returns>
        public async Task<Property> GetPropertyByIdProperty(int idProperty)
        {
            return await _propertyInfraestructureInterface.GetPropertyByIdProperty(idProperty);
        }

        /// <summary>
        /// SearchFilters
        /// </summary>
        /// <param name="searchFilters"></param>
        /// <returns></returns>
        public async Task<List<Property>> SearchFilters(SearchFilters searchFilters)
        {
            return await _propertyInfraestructureInterface.SearchFilters(searchFilters);
        }

        /// <summary>
        /// UpdateProperty
        /// </summary>
        /// <param name="property"></param>
        /// <param name="idProperty"></param>
        /// <returns></returns>
        public async Task UpdateProperty(Property property, int idProperty)
        {
            Property propertyResult = await _propertyInfraestructureInterface.GetPropertyByIdProperty(idProperty);

            propertyResult.Name = property.Name != "string" ? propertyResult.Name == property.Name ? propertyResult.Name : property.Name : propertyResult.Name;
            propertyResult.Address = property.Address != "string" ?  propertyResult.Address == property.Address ? propertyResult.Address : property.Address : propertyResult.Address;
            propertyResult.Price = property.Price != 0 ? propertyResult.Price != property.Price ? property.Price : propertyResult.Price : propertyResult.Price;
            propertyResult.CodeInternal = property.CodeInternal != "string" ? propertyResult.CodeInternal == property.CodeInternal ? propertyResult.CodeInternal : property.CodeInternal : propertyResult.CodeInternal;
            propertyResult.Year = property.Year != 0 ? propertyResult.Year != property.Year ? property.Year : propertyResult.Year : propertyResult.Year;
            propertyResult.IdOwner = property.IdOwner != 0 ? propertyResult.IdOwner != property.IdOwner ? property.IdOwner : propertyResult.IdOwner : propertyResult.IdOwner;

            await _propertyInfraestructureInterface.UpdateProperty(propertyResult);
        }
    }
}
