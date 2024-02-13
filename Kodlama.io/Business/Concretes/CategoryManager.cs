using Kodlama.io.Business.Abstracts;
using Kodlama.io.Business.Dtos.Requests;
using Kodlama.io.Business.Dtos.Responses;
using Kodlama.io.DataAccess.Abstracts;
using Kodlama.io.DataAccess.Concretes.InMemory;
using Kodlama.io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.Business.Concretes;

public class CategoryManager : ICategoryService
{
    ICategoryDal _categoryDal;
    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }

    public void Add(CreateCategoryRequest category)
    {
        Category categoryToCreate = new Category();
        categoryToCreate.Name = category.Name;

        _categoryDal.Add(categoryToCreate);
    }

    public List<GetAllCategoryResponse> GetAll()
    {
        List<GetAllCategoryResponse> categories = new List<GetAllCategoryResponse>();

        foreach (Category item in _categoryDal.GetAll()) 
        {
            GetAllCategoryResponse getAllCategoryResponse = new GetAllCategoryResponse();
            getAllCategoryResponse.Id = item.Id;
            getAllCategoryResponse.Name = item.Name;

            categories.Add(getAllCategoryResponse);
        }

        return categories;
    }

    public GetByIdCategoryResponse GetById(int id)
    {
        GetByIdCategoryResponse getByIdCategoryResponse = new GetByIdCategoryResponse();
        Category category = _categoryDal.GetById(id);
        getByIdCategoryResponse.Id = category.Id;
        getByIdCategoryResponse.Name = category.Name;

        if (category == null)
        {
            return null;
        }

        getByIdCategoryResponse.Id = category.Id;
        getByIdCategoryResponse.Name = category.Name;

        return getByIdCategoryResponse;
    }

    public void Remove(RemoveCategoryRequest removeCategoryRequest)
    {
        int Id = removeCategoryRequest.Id;
        _categoryDal.Remove(Id);
    }

    public void Update(UpdateCategoryRequest updateCategoryRequest)
    {
        Category category = new Category();
        category.Id = updateCategoryRequest.Id != category.Id ? updateCategoryRequest.Id : -1;
        Category existingCategory = _categoryDal.GetById(updateCategoryRequest.Id);

        if (category.Id <= 0 || existingCategory == null)
        {
            return;
        }

        category.Name = updateCategoryRequest.Name != null ? updateCategoryRequest.Name : category.Name;

        _categoryDal.Update(category);
    }
}
