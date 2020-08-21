using Lodging.DataAccess.Repositories;
using Lodging.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Lodging.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LodgingController : ControllerBase
    {
        private readonly UnitOfWork _unitOfWork;

        public LodgingController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Lodging
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await _unitOfWork.Lodging.SelectAsync());
        }

        // GET: api/Lodging/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        // POST: api/Lodging
        [HttpPost]
        public async Task<IActionResult> PostAsync(LodgingModel lodging)
        {
            throw new NotImplementedException();
        }

        // PUT: api/Lodging/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(LodgingModel lodging)
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