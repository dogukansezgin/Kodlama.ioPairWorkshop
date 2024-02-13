using Kodlama.io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.DataAccess.Abstracts;

public interface ICategoryDal
{
    public void Add(Category category);
    public void Remove(int Id);
    public void Update(Category category);
    public List<Category> GetAll();
    public Category GetById(int Id);
}
