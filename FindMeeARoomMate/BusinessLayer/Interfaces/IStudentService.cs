using FindMeeARoomMate.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMeeARoomMate.BusinessLayer.Interfaces
{
    public interface IStudentService
    {
        public Task AddStudent(Student student);
    }
}
