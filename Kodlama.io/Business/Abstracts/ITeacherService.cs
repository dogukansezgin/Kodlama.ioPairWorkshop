using Kodlama.io.Business.Dtos.Requests;
using Kodlama.io.Business.Dtos.Responses;
using Kodlama.io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.Business.Abstracts;

public interface ITeacherService
{
    public void Add(CreateTeacherRequest teacher);
    public void Remove(RemoveTeacherRequest removeTeacherRequest);
    public void Update(int teacherId, UpdateTeacherRequest newTeacher);
    public List<GetAllTeacherResponse> GetAll();
    public GetByIdTeacherResponse GetById(int id);
}
