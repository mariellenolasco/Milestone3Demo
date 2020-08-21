using Lodging.DataAccess.Repositories;
using Lodging.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Lodging.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private readonly UnitOfWork _unitOfWork;

        public ReviewController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Review
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            throw new NotImplementedException();
        }

        // GET: api/Review/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        // POST: api/Review
        [HttpPost]
        public async Task<IActionResult> PostAsync(ReviewModel review)
        {
            throw new NotImplementedException();
        }

        // PUT: api/Review/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(ReviewModel review)
        {
            throw new NotImplementedException();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}