
namespace cadastro_veiculos_minimal_api.Dominio.DTOs;

public record VeiculoDTO
{
    public String Nome { get; set; } = default!;

    public String Marca { get; set; } = default!;

    public int Ano { get; set; } = default!;
};