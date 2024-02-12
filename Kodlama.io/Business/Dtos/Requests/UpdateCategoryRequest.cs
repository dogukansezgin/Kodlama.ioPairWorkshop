using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.Business.Dtos.Requests;

public class UpdateCategoryRequest
{
    public int Id { get; set; }
    public string Name { get; set; }
}
