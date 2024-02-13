using Kodlama.io.Business.Dtos.Requests;
using Kodlama.io.DataAccess.Abstracts;
using Kodlama.io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.DataAccess.Concretes.InMemory;

public class ImCourseDal : ICourseDal
{
    List<Course> courses = new List<Course>();
    int nextId;
    public ImCourseDal()
    {
        courses.Add(new Course {Id = 1, Name="C#", Price=0 });
        courses.Add(new Course {Id = 2, Name="Java", Price=0 });
        courses.Add(new Course {Id = 3, Name="Python", Price=0 });
    }

    public void Add(Course course)
    {
        nextId = courses.Count > 0 ? courses.Max(c => c.Id) + 1 : 1;
        course.Id = nextId;
        courses.Add(course);
    }

    public List<Course> GetAll()
    {
        return courses;
    }

    public Course GetById(int Id)
    {
        return courses.FirstOrDefault(course => course.Id == Id);
    }

    public void Remove(int Id)
    {
        Course course = courses.FirstOrDefault(course => course.Id == Id);
        courses.Remove(course);
    }

    public void Update(Course course)
    {
        Course courseToUpdate = courses.FirstOrDefault(item => item.Id == course.Id);

        if (courseToUpdate != null)
        {
            courseToUpdate.Id = course.Id;
            courseToUpdate.Name = course.Name;
            courseToUpdate.Description = course.Description;
            courseToUpdate.PictureUrl = course.PictureUrl;
            courseToUpdate.Price = course.Price;
            courseToUpdate.DiscountRate = course.DiscountRate;

            courses[courses.IndexOf(courseToUpdate)] = courseToUpdate;
        }
    }
}
