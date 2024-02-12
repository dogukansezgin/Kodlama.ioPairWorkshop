using Kodlama.io.Business.Abstracts;
using Kodlama.io.Business.Dtos.Requests;
using Kodlama.io.Business.Dtos.Responses;
using Kodlama.io.DataAccess.Abstracts;
using Kodlama.io.DataAccess.Concretes.InMemory;
using Kodlama.io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.Business.Concretes;

public class TeacherManager : ITeacherService
{
    ITeacherDal _teacherDal;
    public TeacherManager(ITeacherDal teacherDal)
    {
        _teacherDal = teacherDal;
    }

    public void Add(CreateTeacherRequest teacher)
    {
        Teacher teacherToCreate = new Teacher();
        teacherToCreate.Id = teacher.Id;
        teacherToCreate.Name = teacher.Name;
        teacherToCreate.PictureUrl = teacher.PictureUrl;

        _teacherDal.Add(teacherToCreate);
    }

    public List<GetAllTeacherResponse> GetAll()
    {
        List<GetAllTeacherResponse> categories = new List<GetAllTeacherResponse>();

        foreach (Teacher item in _teacherDal.GetAll())
        {
            GetAllTeacherResponse getAllTeacherResponse = new GetAllTeacherResponse();
            getAllTeacherResponse.Id = item.Id;
            getAllTeacherResponse.Name = item.Name;
            getAllTeacherResponse.PictureUrl = item.PictureUrl;

            categories.Add(getAllTeacherResponse);
        }

        return categories;
    }

    public GetByIdTeacherResponse GetById(int id)
    {
        GetByIdTeacherResponse getByIdTeacherResponse = new GetByIdTeacherResponse();
        Teacher teacher = _teacherDal.GetById(id);
        getByIdTeacherResponse.Id = teacher.Id;
        getByIdTeacherResponse.Name = teacher.Name;
        getByIdTeacherResponse.PictureUrl = teacher.PictureUrl;

        return getByIdTeacherResponse;
    }

    public void Remove(RemoveTeacherRequest removeTeacherRequest)
    {
        int Id = removeTeacherRequest.Id;
        _teacherDal.Remove(Id);
    }

    public void Update(int teacherId, UpdateTeacherRequest updateTeacherRequest)
    {
        throw new NotImplementedException();
    }
}
