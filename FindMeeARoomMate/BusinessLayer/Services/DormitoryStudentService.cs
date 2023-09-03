using FindMeeARoomMate.DataLayer.DBContext;
using FindMeeARoomMate.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMeeARoomMate.BusinessLayer.Services
{
    public class DormitoryStudentService
    {
        private readonly FindMeRoomMateDBContext _dbContext;

        public DormitoryStudentService()
        {
            _dbContext = new FindMeRoomMateDBContext();
        }

        public async Task AddStudentToDormitory(int studentID, int dormitoryID)
        {
            try
            {
                var student = _dbContext.Students.Where(p => p.Id == studentID)
                    .FirstOrDefault();

                if (student == null) 
                {
                    throw new Exception("Student not found");
                }

                var dormitory = _dbContext.Dormitories.Where(p => p.ID == dormitoryID)
    .               FirstOrDefault();

                if (dormitory == null)
                {
                    throw new Exception("Dormitory not found");
                }

                await _dbContext.DormitoryStudents.AddAsync(new DormitoryStudent()
                {
                    DormitoryID = dormitoryID, 
                    StudentID = studentID

                });
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<List<string>> GetStudentsFromDormitories(int dormitoryId)
        {
            try
            {
                var students = from s in _dbContext.Students.ToList()
                               join d in _dbContext.DormitoryStudents.ToList() on s.Id equals d.StudentID
                               where d.DormitoryID == dormitoryId &&
                                     s.FullName.Contains("a")
                               select s.FullName;
                
                return students.ToList();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

    }
}
