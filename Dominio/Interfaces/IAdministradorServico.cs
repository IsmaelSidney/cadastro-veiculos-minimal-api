using cadastro_veiculos_minimal_api.Dominio.DTOs;
using cadastro_veiculos_minimal_api.Dominio.Entidades;

namespace cadastro_veiculos_minimal_api.Dominio.Interfaces
{
    public interface IAdministradorServico
    {
        Administrador? Login(LoginDTO loginDTO);
    }
}