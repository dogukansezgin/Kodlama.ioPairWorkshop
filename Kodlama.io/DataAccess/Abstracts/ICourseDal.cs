using Kodlama.io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.DataAccess.Abstracts;

public interface ICourseDal
{
    public void Add(Course course);
    public void Remove(int Id);
    public void Update(Course oldCourse, Course newCourse);
    public List<Course> GetAll();
    public Course GetById(int Id);
}
