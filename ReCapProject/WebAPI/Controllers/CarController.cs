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
    public class CarController : ControllerBase
    {
        ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }
        [HttpGet("GetAllByBrandId")]
        public IActionResult GetAllByBrandId(int id)
        {

            var result = _carService.GetAllByBrandId(id);
            if (result.Seccess)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);

        }
        [HttpGet("GetAllByBrandId")]
        public IActionResult GetCarDetails()
        {

            var result = _carService.GetCarDetails();
            if (result.Seccess)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);

        }
        [HttpGet("GetAllByColourId")]
        public IActionResult GetAllByColourId(int id)
        {

            var result = _carService.GetAllByColourId(id);
            if (result.Seccess)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);

        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {

            var result = _carService.GetAll();
            if (result.Seccess)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);

        }
        [HttpPost("add")]
        public IActionResult Add(Car car)
        {
            var result = _carService.Add(car);
            if (result.Seccess)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Car car)
        {
            var result = _carService.Delete(car);
            if (result.Seccess)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        } 
        [HttpPost("update")]
        public IActionResult Update(Car car)
        {
            var result = _carService.Update(car);
            if (result.Seccess)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
    }
}
