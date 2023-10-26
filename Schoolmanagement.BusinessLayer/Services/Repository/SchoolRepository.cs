using Microsoft.EntityFrameworkCore;
using Schoolmanagement.DataLayer;
using Schoolmanagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolmanagement.BusinessLayer.Services.Repository
{
    public class SchoolRepository : ISchoolRepository
    {
        /// <summary>
        /// Creating referance variable SchoolDbContext and injecting in SchoolRepository constructor
        /// </summary>
        private readonly SchoolDbContext _schoolDbContext;
        public SchoolRepository(SchoolDbContext schoolDbContext)
        {
            _schoolDbContext = schoolDbContext;
        }


        /// <summary>
        /// Get all book from database
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Library>> AllBook()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get all notice from databse and show on main page
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Notice>> AllNotice()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }


        /// <summary>
        /// get all student from database
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Student>> AllStudent()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get all teacher from databse
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Teacher>> AllTeacher()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get all book list from databse
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Library>> BookList()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }


        /// <summary>
        /// Borrow a book
        /// </summary>
        /// <param name="BookId"></param>
        /// <param name="bookBorrow"></param>
        /// <returns></returns>
        public async Task<BookBorrow> BorrowBook(int BookId, BookBorrow bookBorrow)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get borrow book info and use while returining book
        /// </summary>
        /// <param name="BorrowId"></param>
        /// <returns></returns>
        public async Task<BookBorrow> BorrowInfo(int BorrowId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }


        /// <summary>
        /// Find an existing notice by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Notice>> FindNotice(string name)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }


        /// <summary>
        /// Find an existing student by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Student>> FindStudent(string name)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
    }
}
