﻿using CityInfo.API.Context;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Controllers
{
    [ApiController]
    [Route("api/testdatabase")]
    public class DummyController : ControllerBase
    {
        private CityInfoContex _ctx;

        public DummyController(CityInfoContex ctx)
        {
            _ctx = ctx ?? throw new ArgumentNullException(nameof(ctx));

        }
        [HttpGet]
        public IActionResult TestDataBase() {
            return Ok();
        }
    }
}
