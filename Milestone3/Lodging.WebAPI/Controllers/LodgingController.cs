﻿using Lodging.DataAccess.Repositories;
using Lodging.Models;
using Microsoft.AspNetCore.Mvc;
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
        [HttpGet("{id}", Name = "GetAsync")]
        public async Task<IActionResult> GetAsync(int id)
        {
            try
            {
                return Ok(await _unitOfWork.Lodging.SelectAsync(id));
            }
            catch 
            {

                return NotFound(id);
            }
        }

        // POST: api/Lodging
        [HttpPost]
        public async Task<IActionResult> PostAsync(LodgingModel lodging)
        {
            await _unitOfWork.Lodging.InsertAsync(lodging);
            await _unitOfWork.CommitAsync();

            return Accepted(lodging);
        }

        // PUT: api/Lodging/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(LodgingModel lodging)
        {
            _unitOfWork.Lodging.Update(lodging);
            await _unitOfWork.CommitAsync();

            return Accepted(lodging);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            try
            {
                await _unitOfWork.Lodging.DeleteAsync(id);
                await _unitOfWork.CommitAsync();

                return NoContent();
            }
            catch
            {
                return NotFound(id);
            }
        }
    }
}