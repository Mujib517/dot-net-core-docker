﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace dot_net_core_docker.Controllers
{
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=WINMR185242-2AK;Initial Catalog=Person;Integrated Security=True");
                con.Open();
                return Ok(new[] { "value 1", "value 2" });
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
        }
    }
}
