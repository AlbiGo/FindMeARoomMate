// See https://aka.ms/new-console-template for more information
using FindMeeARoomMate.DataLayer.DBContext;
using FindMeeARoomMate.DataLayer.Models;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");
//Presenation Layer


FindMeRoomMateDBContext findMeRoomMateDBContext = new FindMeRoomMateDBContext();
// findMeRoomMateDBContext.Add(new Student()
//{ 
//    FullName = "Albi Goxhaj"
//});
//findMeRoomMateDBContext.Add(new Student()
//{
//    FullName = "Ori Goxhaj"
//});
//await findMeRoomMateDBContext.SaveChangesAsync();

var students = await findMeRoomMateDBContext.Students.ToListAsync();
students.ForEach(student =>
{
    Console.WriteLine(student.FullName + student.Id);
});

//Delete
var student = await findMeRoomMateDBContext.Students.Where(p => p.Id == 1)
    .FirstOrDefaultAsync();

if(student == null)
{
    throw new Exception("Student not found");
}

findMeRoomMateDBContext.Students.Remove(student);
await findMeRoomMateDBContext.SaveChangesAsync();

