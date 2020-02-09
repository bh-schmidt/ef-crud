using FluentValidation;
using Models.Caminhoes;

namespace Business.Caminhoes.AtualizarCaminhoes
{
    public interface IAtualizarCaminhaoValidator : IValidator<Caminhao>
    {
    }
}
