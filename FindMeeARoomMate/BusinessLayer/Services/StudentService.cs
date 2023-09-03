using FindMeeARoomMate.DataLayer.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMeeARoomMate.BusinessLayer.Services
{
    public class StudentService
    {
        private readonly FindMeRoomMateDBContext _dbContext;

        public StudentService()
        {
            _dbContext = new FindMeRoomMateDBContext();
        }


    }
}
