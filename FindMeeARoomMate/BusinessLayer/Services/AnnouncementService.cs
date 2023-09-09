using FindMeeARoomMate.DataLayer.DBContext;
using FindMeeARoomMate.DataLayer.Models;
using Microsoft.EntityFrameworkCore;
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
        public async Task<Announcement> GetAnnouncement(int id)
        {
            try
            {
                var announcement = from a in _findMeRoomMateDBContext.Announcements
                                   where a.ID == id
                                   select a;

                if(announcement == null)
                {
                    throw new Exception("Announcement cannont be found");
                }

                return announcement.FirstOrDefault();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteAnnouncement(int announcementID)
        {
            try
            {
                //Retrieve record by id

                //Query Syntax
                var announcement1 = (from a in _findMeRoomMateDBContext.Announcements
                                    where a.ID == announcementID
                                    select a).FirstOrDefault();

                //Query Method Syntax 
                var annoncement2 = _findMeRoomMateDBContext.Announcements
                    .Where(p => p.ID == announcementID)
                    .FirstOrDefault();

                //check if null
                if(announcement1 == null)
                {
                    throw new Exception("Announcement is not found");
                }

                //delete
                _findMeRoomMateDBContext.Announcements.Remove(announcement1);
                _findMeRoomMateDBContext.SaveChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task <List<string>> GetAllAnnouncements()
        {
            try
            {
                var annoucements = from a in _findMeRoomMateDBContext.Announcements
                                   orderby a.Title ascending
                                   select a.Title;
                                       
                return annoucements.ToList();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }


        //retrieve record/first default

        //record.title = newTitle

        //context.update(record);
        //save changes
        public async Task DeleteByTitle(string title)
        {
            try
            {
                var announcements = (from a in _findMeRoomMateDBContext.Announcements
                                    where a.Title.Contains(title)
                                    select a).ToList();

                foreach (var a in announcements)
                {
                    _findMeRoomMateDBContext.Announcements.Remove(a);
                    await _findMeRoomMateDBContext.SaveChangesAsync();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
 