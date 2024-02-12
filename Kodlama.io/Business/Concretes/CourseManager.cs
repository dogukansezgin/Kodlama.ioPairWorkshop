using Kodlama.io.Business.Abstracts;
using Kodlama.io.Business.Dtos.Requests;
using Kodlama.io.Business.Dtos.Responses;
using Kodlama.io.DataAccess.Abstracts;
using Kodlama.io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.Business.Concretes;

public class CourseManager : ICourseService
{
    ICourseDal _courseDal;
    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public void Add(CreateCourseRequest course)
    {
        Course courseToCreate = new Course();
        courseToCreate.Id = course.Id;
        courseToCreate.Name = course.Name;

        _courseDal.Add(courseToCreate);
    }

    public List<GetAllCourseResponse> GetAll()
    {
        List<GetAllCourseResponse> courses = new List<GetAllCourseResponse>();

        foreach (Course item in _courseDal.GetAll())
        {
            GetAllCourseResponse getAllCourseResponse = new GetAllCourseResponse();
            getAllCourseResponse.Id = item.Id;
            getAllCourseResponse.Name = item.Name;
            getAllCourseResponse.Description = item.Description;
            getAllCourseResponse.PictureUrl = item.PictureUrl;
            getAllCourseResponse.Price = item.Price;

            courses.Add(getAllCourseResponse);
        }

        return courses;
    }

    public GetByIdCourseResponse GetById(int id)
    {
        GetByIdCourseResponse getByIdCourseResponse = new GetByIdCourseResponse();
        Course course = _courseDal.GetById(id);
        getByIdCourseResponse.Id = course.Id;
        getByIdCourseResponse.Name = course.Name;
        getByIdCourseResponse.Description = course.Description;
        getByIdCourseResponse.PictureUrl = course.PictureUrl;
        getByIdCourseResponse.Price = course.Price;
        getByIdCourseResponse.DiscountRate = course.DiscountRate;

        return getByIdCourseResponse;
    }

    public void Delete(RemoveCourseRequest removeCourseRequest)
    {
        int Id = removeCourseRequest.Id;
        _courseDal.Remove(Id);
    }

    public void Update(int courseId, UpdateCourseRequest updateCourseRequest)
    {
        throw new NotImplementedException();
    }
}
