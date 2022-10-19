using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColourController : ControllerBase
    {
        IColourService _colourService;

        public ColourController(IColourService colourService)
        {
            _colourService = colourService;
        }
        [HttpPost("add")]
        public IActionResult Add(Colour colour)
        {
            var result = _colourService.Add(colour);
            if (result.Seccess)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Colour colour)
        {
            var result = _colourService.Delete(colour);
            if (result.Seccess)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("update")]
        public IActionResult Update(Colour colour)
        {
            var result = _colourService.Update(colour);
            if (result.Seccess)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {

            var result = _colourService.GetAll();
            if (result.Seccess)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);

        }
        [HttpGet("GetbyId")]
        public IActionResult GetbyId(int id)
        {

            var result = _colourService.GetbyId(id);
            if (result.Seccess)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);

        }
    }
}
