using PuertaMagica.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuertaMagica.DAL.Contracts
{
    public interface IUsuarioRepository
    {
        void Insertar(Usuario usuario);
        void Actualizar(Usuario usuario);
        void Delete(string username);
    }
}
