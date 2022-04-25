using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interface
{
    public interface IPropertyImageInfraestructureInterface
    {
        /// <summary>
        /// CreatePropertyImage
        /// </summary>
        /// <param name="propertyImage"></param>
        /// <returns></returns>
        Task CreatePropertyImage(PropertyImage propertyImage);
    }
}
