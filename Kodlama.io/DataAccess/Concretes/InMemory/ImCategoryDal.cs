using Kodlama.io.DataAccess.Abstracts;
using Kodlama.io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.DataAccess.Concretes.InMemory;

public class ImCategoryDal : ICategoryDal
{
    List<Category> categories = new List<Category>();
    int nextId;
    public ImCategoryDal()
    {
        categories.Add(new Category {Id= 1,Name= "Programlama"} );
        categories.Add(new Category {Id= 2,Name= "Yazılım"} );
        categories.Add(new Category {Id= 3,Name= "Full Stack"} );
    }

    public void Add(Category category)
    {
        nextId = categories.Count > 0 ? categories.Max(t => t.Id) + 1 : 1;
        category.Id = nextId;
        categories.Add(category);
    }

    public List<Category> GetAll()
    {
        return categories;
    }

    public Category GetById(int Id)
    {
        return categories.FirstOrDefault(category => category.Id == Id);
    }

    public void Remove(int Id)
    {
        Category category = categories.FirstOrDefault(category => category.Id == Id);
        categories.Remove(category);
    }

    public void Update(Category category)
    {
        Category categoryToUpdate = categories.FirstOrDefault(item => item.Id == category.Id);

        if (categoryToUpdate != null)
        {
            categoryToUpdate.Id = category.Id;
            categoryToUpdate.Name = category.Name;

            categories[categories.IndexOf(categoryToUpdate)] = categoryToUpdate;
        }
    }   
}
