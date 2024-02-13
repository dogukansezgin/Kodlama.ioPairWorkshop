using Kodlama.io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.DataAccess.Abstracts;

public interface ITeacherDal
{
    public void Add(Teacher teacher);
    public void Remove(int Id);
    public void Update(Teacher teacher);
    public List<Teacher> GetAll();
    public Teacher GetById(int Id);
}
