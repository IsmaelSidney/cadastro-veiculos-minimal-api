using cadastro_veiculos_minimal_api.Dominio.DTOs;
using cadastro_veiculos_minimal_api.Dominio.Entidades;

namespace cadastro_veiculos_minimal_api.Dominio.Interfaces
{
    public interface IVeiculoServico
    {
        List<Veiculo>? Todos(int? pagina = 1, string? nome = null, string? marca = null);
        Veiculo? BuscaPorId(int id);
        void Incluir(Veiculo veiculo);

        void Atualizar(Veiculo veiculo);
        void Apagar(Veiculo veiculo);
    }
}