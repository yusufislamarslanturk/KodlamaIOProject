using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entitties.Concrete;
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
    public class ProductsController : ControllerBase
    {
        IProductService _productService;

         public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("getall")]

        public IActionResult Get()
        {
           
            var result = _productService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data); 
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getbyid")]

        public IActionResult Get(int id)
        {

            var result = _productService.GetById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("add")]

        public IActionResult Post(Product product)
        {
            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("delete")]

        public IActionResult Delete(Product product)
        {
            var result = _productService.Delete(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        //GetAllByCategoryId
        [HttpGet("getbycategoryid")]

        public IActionResult Get2(int id)
        {

            var result = _productService.GetAllByCategoryId(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
    }
}
