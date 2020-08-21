using Lodging.DataAccess.Repositories;
using Lodging.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Lodging.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalController : ControllerBase
    {
        private readonly UnitOfWork _unitOfWork;

        public RentalController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Rental
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            throw new NotImplementedException();
        }

        // GET: api/Rental/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        // POST: api/Rental
        [HttpPost]
        public async Task<IActionResult> PostAsync(RentalModel rental)
        {
            throw new NotImplementedException();
        }

        // PUT: api/Rental/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(RentalModel rental)
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