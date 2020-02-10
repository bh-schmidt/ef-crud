using FluentValidation;
using Models.Caminhoes;

namespace Business.Caminhoes.ExcluirCaminhoes
{
    public interface IExcluirCaminhaoValidator : IValidator<Caminhao>
    {
    }
}
