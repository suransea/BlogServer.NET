using System;
using System.Collections.Generic;
using System.Linq;
using BlogServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlogServer.Controllers
{
    [ApiController]
    [Route("articles")]
    public class ArticlesController : ControllerBase
    {
        private readonly BlogContext _context;

        public ArticlesController(BlogContext context) => _context = context;

        [HttpGet]
        public IEnumerable<Article> Get()
        {
            return _context.Articles.Include(x => x.Content);
        }
    }
}
