using PuertaMagica.BL.Contracts;
using PuertaMagica.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuertaMagica.BL.Implementations
{
    public class LoginBL : ILoginBL
    {
        public bool Login(LoginDTO loginDTO)
        {
            if (loginDTO.Username == "Pepe" && loginDTO.Password == "mola")
                return true;
            else
                return false;
        }
    }
}
