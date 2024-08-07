using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Configuration
{
    public static class MappingExtensions 
    {
        public static LoginServiceModel ToServiceModel(this LoginBindingModel source)
        {
            return new LoginServiceModel()
            {
                Email = source.Login,
                Password = source.Password
            };
        }
    }
}
