﻿using FindMeeARoomMate.BusinessLayer.Interfaces;
using FindMeeARoomMate.DataLayer.DBContext;
using FindMeeARoomMate.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMeeARoomMate.BusinessLayer.Services
{
    public class StudentService : IStudentService
    {
        private readonly FindMeRoomMateDBContext _dbContext;

        public StudentService()
        {
            _dbContext = new FindMeRoomMateDBContext();
        }

        public async Task AddStudent(Student student)
        {
            try
            {
                await _dbContext.AddAsync(student);
                await _dbContext.SaveChangesAsync();
            }
            catch(Exception ex) 
            {
                throw;
            }
        }




    }
}
