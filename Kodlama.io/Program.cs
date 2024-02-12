
using Kodlama.io.Business.Concretes;
using Kodlama.io.Business.Dtos.Requests;
using Kodlama.io.Business.Dtos.Responses;
using Kodlama.io.DataAccess.Concretes.InMemory;

Console.WriteLine("Hello");


CourseManager courseManager = new CourseManager(new ImCourseDal());
TeacherManager teacherManager = new TeacherManager(new ImTeacherDal());
CategoryManager categoryManager = new CategoryManager(new ImCategoryDal());

// Get by id
GetByIdCourseResponse courseGetById = courseManager.GetById(2);
Console.WriteLine($"ID:{courseGetById.Id} Name:{courseGetById.Name} Price:{courseGetById.Price}");

// Create
CreateCourseRequest createCourseRequest = new CreateCourseRequest() { Id = 4, Name = "C++", Description = "asdasd", Price = 0 };
courseManager.Add(createCourseRequest);
Console.WriteLine($"{createCourseRequest.Id} ID'li kurs Eklendi");

// Get all
List<GetAllCourseResponse> getAllCourse = courseManager.GetAll();
foreach (var item in getAllCourse)
{
    Console.WriteLine($"ID:{item.Id} Name:{item.Name} Price:{item.Price}");
}

// Delete
RemoveCourseRequest courseRemoveRequest = new RemoveCourseRequest();
courseRemoveRequest.Id = 3;
courseManager.Delete(courseRemoveRequest);
Console.WriteLine($"{courseRemoveRequest.Id} ID'li kurs Silindi");

getAllCourse = courseManager.GetAll();
foreach (var item in getAllCourse)
{
    Console.WriteLine($"ID:{item.Id} Name:{item.Name} Price:{item.Price}");
}

