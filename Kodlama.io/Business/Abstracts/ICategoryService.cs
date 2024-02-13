using Kodlama.io.Business.Dtos.Requests;
using Kodlama.io.Business.Dtos.Responses;
using Kodlama.io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.Business.Abstracts;

public interface ICategoryService
{
    public void Add(CreateCategoryRequest createCategoryRequest);
    public void Remove(RemoveCategoryRequest removeCategoryRequest);
    public void Update(UpdateCategoryRequest updateCategoryRequest);
    public List<GetAllCategoryResponse> GetAll();
    public GetByIdCategoryResponse GetById(int id);
}
