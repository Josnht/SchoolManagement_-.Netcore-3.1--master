using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Schoolmanagement.BusinessLayer.Interfaces;
using Schoolmanagement.BusinessLayer.ViewModels;
using Schoolmanagement.Entities;

namespace Schoolmanagement.Controllers
{
    public class SchoolController : Controller
    {
        /// <summary>
        /// Creating referance variable of ISchoolServices and injecting in SchoolController constructor
        /// </summary>
        private readonly ISchoolServices _schoolServices;
        public SchoolController(ISchoolServices schoolServices)
        {
            _schoolServices = schoolServices;
        }

        /// <summary>
        /// Get all School Notice and using this method find notice ny Notice name 
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("find-notice-byname")]
        public async Task<IActionResult> AllNoticeByName(string name)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get all School student and using this method find student by name
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("find-student-byname")]
        public async Task<IActionResult> AllStudentByName(string name)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get all teachers
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("get-all-teachers")]
        public async Task<IActionResult> AllTeacher()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get all book from library
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("get-all-books")]
        public async Task<IActionResult> Library()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
        
        /// <summary>
        /// Borrow/take book from library
        /// </summary>
        /// <param name="BookId"></param>
        /// <param name="borrow"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("borrow-book")]
        public async Task<IActionResult> Borrowbook(int BookId, BookBorrow borrow)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get the borrow book info to use while returning
        /// </summary>
        /// <param name="BorrowId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("get-borrowbook-info")]
        public async Task<IActionResult> GetBorrowBookInfo(int BorrowId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
    }
}
