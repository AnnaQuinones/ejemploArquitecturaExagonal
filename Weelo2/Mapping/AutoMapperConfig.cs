using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Weelo2.Mapping
{
    public class AutoMapperConfig
    {
        public static IMapper Initialize()
        {
            var mapperConfig = new MapperConfiguration(mc => 
            {
                mc.AddProfile(new MappingProfile());
            });

            return mapperConfig.CreateMapper();
        }
    }
}
