using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Domain.Interface;
using Entities;
using Infrastructure.Interface;

namespace Domain
{
    public class PropertyImageDomain : IPropertyImageInterface
    {
        public readonly IPropertyImageInfraestructureInterface _propertyImageInfraestructureInterface;

        public PropertyImageDomain(IPropertyImageInfraestructureInterface propertyImageInfraestructureInterface)
        {
            _propertyImageInfraestructureInterface = propertyImageInfraestructureInterface;
        }

        /// <summary>
        /// CreatePropertyImage
        /// </summary>
        /// <param name="propertyImage"></param>
        /// <returns></returns>
        public async Task CreatePropertyImage(PropertyImage propertyImage)
        {
            await _propertyImageInfraestructureInterface.CreatePropertyImage(propertyImage);
        }
    }
}
