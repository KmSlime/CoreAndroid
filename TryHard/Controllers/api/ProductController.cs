using TryHard.Models;
using Lib.Entity;
using Lib.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TryHard.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private ProductService productService;
        public ProductController(ProductService productService) {
            this.productService = productService;
        }

        [HttpGet("get-product")]
        //[Authorize(Roles = "Admin,Guest")]
        public async Task<ActionResult> GetProduct() {
            string UserLogin = HttpContext.User.Identity.Name;
            List<Product> productList = productService.GetProducts();
            return Ok(new { status = true, data = productList });
        }
        [HttpPost("insert-product")]
        public async Task<ActionResult> InsertProduct(ProductModel  productModel) {
            try
            {
                Product st = new Product();
                st.Id = Guid.NewGuid();
                st.Name = productModel.Name;
                st.Price = productModel.Price;
                st.Description = productModel.Description;
                st.Img = productModel.Img;
                productService.InsertProduct(st);
                return Ok(new { status = true, message = "" });
            }
            catch (Exception ex) {
                return Ok(new { status = false, message = ex.Message });
            }
        }
    }
}
