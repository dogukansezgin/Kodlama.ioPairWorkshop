using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.Business.Dtos.Requests;

public class UpdateTeacherRequest
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string PictureUrl { get; set; }
}
