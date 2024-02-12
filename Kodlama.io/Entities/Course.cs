using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.Entities;

public class Course
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string PictureUrl { get; set; }
    public int Price { get; set; }
    public double DiscountRate { get; set; }
    public double DiscountedPrice => Price - (Price * DiscountRate / 100);
}
