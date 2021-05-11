using AutoMapper;
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

        public IMapper mapper { get; set; }
        public LoginBL(ILoginRepository LoginRepository, IMapper mapper)
        {
            this.LoginRepository = LoginRepository;
            this.mapper = mapper;
        }

        public bool Login(LoginDTO loginDTO)
        {
            var usuario = mapper.Map<LoginDTO, Usuario>(loginDTO);
            return LoginRepository.Login(usuario);
        }
    }
}
