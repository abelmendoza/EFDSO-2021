using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiVentas.Context;


namespace ApiVentas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly AppDbcontext context;
        public UsuarioController(AppDbcontext _context)
        {
            this.context = _context;
        }
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(context.usuario.ToList());
        }

    }
}