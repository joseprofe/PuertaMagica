using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PuertaMagica.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PuertaMagica.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        public bool Login(LoginDTO loginDTO) 
        {
            if (loginDTO.Username == "Pepe" && loginDTO.Password == "mola")
                return true;
            else 
                return false;
        }
    }
}
