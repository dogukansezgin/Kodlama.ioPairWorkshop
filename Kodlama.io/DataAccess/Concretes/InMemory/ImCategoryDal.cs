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
    public ImCategoryDal()
    {
        categories.Add(new Category {Id= 1,Name= "Programlama"} );
        categories.Add(new Category {Id= 2,Name= "Yazılım"} );
        categories.Add(new Category {Id= 3,Name= "Full Stack"} );
    }

    public void Add(Category category)
    {
        categories.Add(category);
    }

    public List<Category> GetAll()
    {
        return categories;
    }

    public Category GetById(int id)
    {
        return categories.First(category => category.Id == id);
    }

    public void Remove(int Id)
    {
        Category category = categories.FirstOrDefault(c => c.Id == Id);
        categories.Remove(category);
    }

    public void Update(Category oldCategory, Category newCategory)
    {
        Category categoryToUpdate = categories.FirstOrDefault(c => c.Id == oldCategory.Id);

        if (categoryToUpdate != null)
        {
            categories[categoryToUpdate.Id] = newCategory;
            categories[categoryToUpdate.Id].Id = categoryToUpdate.Id;
        }
    }   
}
