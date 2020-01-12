﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ZipPayUserService.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        [HttpGet(Name = "List")]
        public List<string> List()
        {
            return new List<string> { "list" };
        }

        [HttpPost(Name = "Create")]
        public int Create([FromBody] string value)
        {
            return 1;
        }
    }
}