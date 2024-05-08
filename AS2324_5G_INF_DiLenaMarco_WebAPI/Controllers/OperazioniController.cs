﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AS2324_5G_INF_DiLenaMarco_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperazioniController : ControllerBase
    {
        [HttpGet]
        public JsonResult Moltiplicatore(int num, int factor)
        {
            string res;
            if (num < factor && factor/num < factor )
            {
                res = "il primo numero non è moltiplicatore del secondo";
            }
            else
            {
                res = "il primo numero è moltiplicatore del secondo";
            }
            return new JsonResult(new JsonResult(res));
        }
    }
}
