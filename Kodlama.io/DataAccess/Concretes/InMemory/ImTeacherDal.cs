using Kodlama.io.DataAccess.Abstracts;
using Kodlama.io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.DataAccess.Concretes.InMemory;

public class ImTeacherDal : ITeacherDal
{
    List<Teacher> teachers = new List<Teacher>();
    public ImTeacherDal()
    {
        teachers.Add(new Teacher { Id = 1, Name = "Engin Demiroğ" });
        teachers.Add(new Teacher { Id = 2, Name = "Halit Enes Kalaycı" });
    }

    public void Add(Teacher teacher)
    {
        teachers.Add(teacher);
    }

    public List<Teacher> GetAll()
    {
        return teachers;
    }

    public Teacher GetById(int Id)
    {
        return teachers.First(teacher => teacher.Id == Id);
    }

    public void Remove(int Id)
    {
        Teacher teacher = teachers.FirstOrDefault(c => c.Id == Id);
        teachers.Remove(teacher);
    }

    public void Update(Teacher oldTeacher, Teacher newTeacher)
    {
        Teacher teacherToUpdate = teachers.FirstOrDefault(t => t.Id == oldTeacher.Id);

        if (teacherToUpdate != null)
        {
            teachers[teacherToUpdate.Id] = newTeacher;
            teachers[teacherToUpdate.Id].Id = teacherToUpdate.Id;
        }
    }
}
