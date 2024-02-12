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
    public void Add(CreateCourseRequest course);
    public void Delete(RemoveCourseRequest course);
    public void Update(int courseId, UpdateCourseRequest newCourse);
    public List<GetAllCourseResponse> GetAll();
    public GetByIdCourseResponse GetById(int id);
}
