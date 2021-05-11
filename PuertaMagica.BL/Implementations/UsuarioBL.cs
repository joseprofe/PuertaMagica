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
    public class UsuarioBL : IUsuarioBL
    {
        public IUsuarioRepository usuarioRepository { get; set; }
        public IMapper mapper { get; set; }
        public UsuarioBL(IUsuarioRepository usuarioRepository, IMapper mapper)
        {
            this.usuarioRepository = usuarioRepository;
            this.mapper = mapper;
        }

        public void Insertar(UsuarioDTO usuarioDTO)
        {
            var usuario = mapper.Map<UsuarioDTO, Usuario>(usuarioDTO);
            usuarioRepository.Insertar(usuario);
        }

        public void Actualizar(UsuarioDTO usuarioDTO)
        {
            var usuario = mapper.Map<UsuarioDTO, Usuario>(usuarioDTO);
            usuarioRepository.Actualizar(usuario);
        }

        public void Delete(string username)
        {
            usuarioRepository.Delete(username);
        }
    }
}
