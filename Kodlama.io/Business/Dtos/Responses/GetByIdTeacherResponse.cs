using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.Business.Dtos.Responses;

public class GetByIdTeacherResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string PictureUrl { get; set; }
}
