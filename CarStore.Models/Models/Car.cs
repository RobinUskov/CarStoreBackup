using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore.Models.Models
{ 
    public class Car
{
    public int Id { get; set; }

    public string Model { get; set; } = string.Empty;

    public int BrandId { get; set; }

    public DateTime ReleaseDate { get; set; }
}
}