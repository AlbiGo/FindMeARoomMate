using FindMeeARoomMate.DataLayer.DBContext;
using FindMeeARoomMate.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMeeARoomMate.BusinessLayer.Services
{
    public class AnnouncementService
    {
        private readonly FindMeRoomMateDBContext _findMeRoomMateDBContext;

        public AnnouncementService()
        {
            _findMeRoomMateDBContext = new FindMeRoomMateDBContext();
        }

        public async Task AddAnnoucement(Announcement announcement)
        {
            try
            {
                //Check if user is valid
                //Created by => ID int

                if(announcement.CreatedByID == 0)
                {
                    throw new Exception();
                }

                var studentID = announcement.CreatedByID;

                var user = _findMeRoomMateDBContext.Students.Where(p => p.Id == studentID)
                    .FirstOrDefault();

                if (user == null) 
                {
                    throw new Exception("Studenti nuk egziston");
                }

                _findMeRoomMateDBContext.Add(announcement);
                _findMeRoomMateDBContext.SaveChanges();
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        //Get Announcement by id
    }
}
