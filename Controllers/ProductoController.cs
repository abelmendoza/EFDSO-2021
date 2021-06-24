using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiVentas.Context;
using Microsoft.EntityFrameworkCore;
using ApiVentas.Models;


namespace ApiVentas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly AppDbcontext _context;
        public ProductoController(AppDbcontext context)
        {
            this._context = context;
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            try
            {
                return Ok(_context.producto.ToList());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("id", Name = "GetById")]
        public ActionResult GetById(int id)
        {
            try
            {
                var producto = _context.producto.FirstOrDefault(p => p.id == id);
                return Ok(producto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public ActionResult Post([FromBody] Producto producto)
        {
            try
            {
                _context.producto.Add(producto);
                _context.SaveChanges();
                return CreatedAtRoute("GetById", new { producto.id }, producto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}