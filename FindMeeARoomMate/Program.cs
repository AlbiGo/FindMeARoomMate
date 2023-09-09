// See https://aka.ms/new-console-template for more information
using FindMeeARoomMate.BusinessLayer.Interfaces;
using FindMeeARoomMate.BusinessLayer.Services;
using FindMeeARoomMate.DataLayer.DBContext;
using FindMeeARoomMate.DataLayer.Models;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");
//Presenation Layer


//IStudentService studentService = new StudentService();

//await studentService.AddStudent(new Student()
//{
//    FullName = "test test"
//});

//DormitoryService dormitoryService = new DormitoryService();
//dormitoryService.AddNewDormitory(new Dormitory()
//{
//    Address = "Fier",
//    Capacity = 100
//});

//DormitoryStudentService DormitoryStudentService = new DormitoryStudentService();
//var students = await DormitoryStudentService.GetStudentsFromDormitories(1);

//students.ForEach(s =>
//{
//    Console.WriteLine(s);
//});

AnnouncementService announcementService = new AnnouncementService();

announcementService.AddAnnoucement(new Announcement() 
{
    IsActive= true,
    CreatedByID = 2,
    Description = "Test",
    Title = "Test"
});
//Shto Announcement
//Shiko te gjithe Announcement