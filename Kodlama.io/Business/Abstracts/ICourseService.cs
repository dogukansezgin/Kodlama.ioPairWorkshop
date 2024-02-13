using Kodlama.io.Business.Dtos.Requests;
using Kodlama.io.Business.Dtos.Responses;
using Kodlama.io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.Business.Abstracts;

public interface ICourseService
{
    public void Add(CreateCourseRequest createCourseRequest);
    public void Delete(RemoveCourseRequest removeCourseRequest);
    public void Update(UpdateCourseRequest updateCourseRequest);
    public List<GetAllCourseResponse> GetAll();
    public GetByIdCourseResponse GetById(int id);
}
