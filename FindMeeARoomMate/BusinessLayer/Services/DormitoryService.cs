using FindMeeARoomMate.DataLayer.DBContext;
using FindMeeARoomMate.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMeeARoomMate.BusinessLayer.Services
{
    public class DormitoryService
    {
        private readonly FindMeRoomMateDBContext _dbContext;

        public DormitoryService()
        {
            _dbContext = new FindMeRoomMateDBContext();
        }

        public async Task AddNewDormitory(Dormitory dormitory)
        {
            try
            {
                await _dbContext.Dormitories.AddAsync(dormitory);
                await _dbContext.SaveChangesAsync();
            }
            catch(Exception ex)
            {

            }
        }
    }
}
