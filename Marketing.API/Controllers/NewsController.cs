﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Marketing.Domain;
using Marketing.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace Marketing.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly INewsService _newsService;

        public NewsController(INewsService newsService)
        {
            _newsService = newsService;
        }

        // GET: api/<controller>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<News>), 200)]
        public async Task<IEnumerable<News>> GetNews()
        {
            var news = await _newsService.GetNewsAsync();
            return news;
        }
    }
}
