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
    int nextId;
    public ImTeacherDal()
    {
        teachers.Add(new Teacher { Id = 1, Name = "Engin Demiroğ" });
        teachers.Add(new Teacher { Id = 2, Name = "Halit Enes Kalaycı" });
    }

    public void Add(Teacher teacher)
    {
        nextId = teachers.Count > 0 ? teachers.Max(t => t.Id) + 1 : 1;
        teacher.Id = nextId;
        teachers.Add(teacher);
    }

    public List<Teacher> GetAll()
    {
        return teachers;
    }

    public Teacher GetById(int Id)
    {
        return teachers.FirstOrDefault(teacher => teacher.Id == Id);
    }

    public void Remove(int Id)
    {
        Teacher teacher = teachers.FirstOrDefault(teacher => teacher.Id == Id);
        teachers.Remove(teacher);
    }

    public void Update(Teacher teacher)
    {
        Teacher teacherToUpdate = teachers.FirstOrDefault(item => item.Id == teacher.Id);

        if (teacherToUpdate != null)
        {
            teacherToUpdate.Id = teacher.Id;
            teacherToUpdate.Name = teacher.Name;
            teacherToUpdate.PictureUrl = teacher.PictureUrl;

            teachers[teachers.IndexOf(teacherToUpdate)] = teacherToUpdate;
        }

    }
}
