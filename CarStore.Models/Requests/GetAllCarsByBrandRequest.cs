using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore.Models.Requests
{
    public class GetAllCarsByBrandRequest
    {
        public int CarId { get; set; }

        public DateTime AfterDate { get; set; }
    }
}
