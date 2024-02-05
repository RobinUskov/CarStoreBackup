using CarStore.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore.Models.Response
{
    public class GetAllCarsByBrandResponse
    {
        public Brand Brand  { get; set; }

        public List<Car> Cars { get; set; }
    }
}
