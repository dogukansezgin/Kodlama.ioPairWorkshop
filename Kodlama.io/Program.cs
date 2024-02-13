
using Kodlama.io.Business.Concretes;
using Kodlama.io.Business.Dtos.Requests;
using Kodlama.io.Business.Dtos.Responses;
using Kodlama.io.DataAccess.Concretes.InMemory;
using Kodlama.io.Entities;

Console.WriteLine("Hello");


CourseManager courseManager = new CourseManager(new ImCourseDal());
TeacherManager teacherManager = new TeacherManager(new ImTeacherDal());
CategoryManager categoryManager = new CategoryManager(new ImCategoryDal());

// Get by id
GetByIdCourseResponse courseGetById = courseManager.GetById(2);
if (courseGetById != null)
{
    Console.WriteLine($"ID:{courseGetById.Id} Name:{courseGetById.Name} Price:{courseGetById.Price}");
}
else
{
    Console.WriteLine("null");
}

// Create
CreateCourseRequest createCourseRequest = new CreateCourseRequest() { Name = "C++", Description = "asdasd", Price = 0 };
courseManager.Add(createCourseRequest);

Console.WriteLine("------------------"); Console.WriteLine($"{createCourseRequest.Name} adlı kurs Eklendi");

// Get all
List<GetAllCourseResponse> getAllCourse = courseManager.GetAll();
foreach (var item in getAllCourse)
{
    Console.WriteLine($"ID:{item.Id} Name:{item.Name} Price:{item.Price} ");
}

// Delete
RemoveCourseRequest courseRemoveRequest = new RemoveCourseRequest();
courseRemoveRequest.Id = 3;
courseManager.Delete(courseRemoveRequest);

Console.WriteLine("------------------"); Console.WriteLine($"{courseRemoveRequest.Id} ID'li kurs Silindi");

getAllCourse = courseManager.GetAll();
foreach (var item in getAllCourse)
{
    Console.WriteLine($"ID:{item.Id} Name:{item.Name} Price:{item.Price}");
}

// Update
UpdateCategoryRequest categoryUpdateRequest = new UpdateCategoryRequest() { Id = 2, Name = "Yazılım Geliştirme" };
categoryManager.Update(categoryUpdateRequest);

Console.WriteLine("------------------"); Console.WriteLine($"{categoryUpdateRequest.Id} ID'li kategori Güncellendi");

GetByIdCategoryResponse categoryGetById = categoryManager.GetById(2);
if (categoryGetById != null)
{
    Console.WriteLine($"ID:{categoryGetById.Id} Name:{categoryGetById.Name}");
}
else
{
    Console.WriteLine("null");
}


//Teacher: Create
Console.WriteLine("------------------"); Console.WriteLine("Teacher eklendi ve güncellendi.");
teacherManager.Add(new CreateTeacherRequest() { Name = "Sadık Turan", PictureUrl = "asdasd" });
List<GetAllTeacherResponse> getAllTeacherResponses = teacherManager.GetAll();

//Update
UpdateTeacherRequest updateTeacherRequest = new UpdateTeacherRequest() { Id = 2, Name = "Denizhan Dursun" };
teacherManager.Update(updateTeacherRequest);


getAllTeacherResponses = teacherManager.GetAll();

foreach (var item in getAllTeacherResponses)
{
    Console.WriteLine($"ID:{item.Id} Name:{item.Name}");
}








