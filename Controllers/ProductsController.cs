﻿using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly StoreContext context;

        public ProductsController(StoreContext context)
        {
            this.context = context;
        }



        [HttpGet]   // GET: api/<ValuesController>
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            
            return await context.Products.ToListAsync();
        }

       
        [HttpGet("{id}")]   // GET api/<ValuesController>/5
        public async Task <ActionResult<Product>> GetProduct(int id)
        {
            return await context.Products.FindAsync(id);
        }

       
        [HttpPost]   // POST api/<ValuesController>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
