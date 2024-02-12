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
    public ImCourseDal()
    {
        courses.Add(new Course {Id = 1, Name="C#", Price=0 });
        courses.Add(new Course {Id = 2, Name="Java", Price=0 });
        courses.Add(new Course {Id = 3, Name="Python", Price=0 });
    }

    public void Add(Course course)
    {
        courses.Add(course);
    }

    public List<Course> GetAll()
    {
        return courses;
    }

    public Course GetById(int id)
    {
        return courses.First(course => course.Id == id);
    }

    public void Remove(int Id)
    {
        Course course = courses.FirstOrDefault(c => c.Id == Id);
        courses.Remove(course);
    }

    public void Update(Course oldCourse, Course newCourse)
    {
        Course courseToUpdate = courses.FirstOrDefault(c => c.Id == oldCourse.Id);

        if (courseToUpdate != null)
        {
            courses[courseToUpdate.Id] = newCourse;
            courses[courseToUpdate.Id].Id = courseToUpdate.Id;
        }
    }
}
