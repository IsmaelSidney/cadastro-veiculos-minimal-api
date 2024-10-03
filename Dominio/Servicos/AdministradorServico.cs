using cadastro_veiculos_minimal_api.Dominio.DTOs;
using cadastro_veiculos_minimal_api.Dominio.Entidades;
using cadastro_veiculos_minimal_api.Dominio.Interfaces;
using cadastro_veiculos_minimal_api.Infraestrutura.Db;


namespace cadastro_veiculos_minimal_api.Dominio.Servicos
{
    public class AdministradorServico : IAdministradorServico
    {
        private readonly DbContexto _contexto;

        public AdministradorServico(DbContexto contexto)
        {
            _contexto = contexto;
        }
        public Administrador? Login(LoginDTO loginDTO)
        {
            var adm = _contexto.Administradores.Where(a => a.Email == loginDTO.Email && a.Senha == loginDTO.Senha).FirstOrDefault();
            return adm;
        }
    }
}