using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.Business.Dtos.Requests;

public class CreateCourseRequest
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string PictureUrl { get; set; }
    public int Price { get; set; }
    public double DiscountRate { get; set; }
}
