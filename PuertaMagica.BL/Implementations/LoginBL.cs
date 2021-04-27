using PuertaMagica.BL.Contracts;
using PuertaMagica.Core.DTO;
using PuertaMagica.DAL.Contracts;
using PuertaMagica.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuertaMagica.BL.Implementations
{
    public class LoginBL : ILoginBL
    {
        public ILoginRepository LoginRepository { get; set; }
        public LoginBL(ILoginRepository LoginRepository)
        {
            this.LoginRepository = LoginRepository;
        }

        public bool Login(LoginDTO loginDTO)
        {
            var usuario = new Usuario
            {
                Username = loginDTO.Username,
                Password = loginDTO.Password
            };
            return LoginRepository.Login(usuario);
        }
    }
}
