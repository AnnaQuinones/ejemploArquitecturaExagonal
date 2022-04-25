using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Entities.Context;
using Infrastructure.Interface;

namespace Infrastructure
{
    public class PropertyImageInfraestructure : IPropertyImageInfraestructureInterface
    {
        public readonly weeloContext _weeloContext;

        public PropertyImageInfraestructure(weeloContext weeloContext)
        {
            _weeloContext = weeloContext;
        }

        /// <summary>
        /// CreatePropertyImage
        /// </summary>
        /// <param name="propertyImage"></param>
        /// <returns></returns>
        public async Task CreatePropertyImage(PropertyImage propertyImage)
        {
            _weeloContext.PropertyImage.Add(propertyImage);
            await _weeloContext.SaveChangesAsync();
        }
    }
}
