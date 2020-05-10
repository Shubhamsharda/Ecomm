using Ekart.Models;
using Ekart.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ekart.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public class ProductsController: ControllerBase
    {
        private readonly ProductService _productService;
        
        public ProductsController(ProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public ActionResult<List<Products>> Get() =>
            _productService.Get();

        [HttpGet("{id:length(24)}",Name = "GetProduct")]
        public ActionResult<Products> Get(string id)
        {
            var product = _productService.Get(id);
            if (product == null)
            {
                return NotFound();
            }

            return product;
        }

        [HttpPost]
        public ActionResult<Products> Create(Products product)
        {
            _productService.Create(product);

            return CreatedAtRoute("GetProduct", new { id = product.Id.ToString() }, product);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, Products productIn)
        {
            var product = _productService.Get(id);

            if (product == null)
            {
                return NotFound();
            }

            _productService.Update(id, productIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var product = _productService.Get(id);

            if (product == null)
            {
                return NotFound();
            }

            _productService.Remove(product.Id);

            return NoContent();
        }
    }
}