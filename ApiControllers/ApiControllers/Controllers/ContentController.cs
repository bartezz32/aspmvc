﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiControllers.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiControllers.Controllers
{
    [Route("api/[controller]")]
    public class ContentController : Controller
    {
        [HttpGet("string")]
        public string GetString() => "This is a string response";

        [HttpGet("object")]
        public Reservation GetObject() => new Reservation
        {
            ReservationId = 100,
            ClientName = "John",
            Location = "Hall"
        };
    }

}