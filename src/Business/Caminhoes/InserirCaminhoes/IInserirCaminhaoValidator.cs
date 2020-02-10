using FluentValidation;
using Models.Caminhoes;

namespace Business.Caminhoes
{
    public interface IInserirCaminhaoValidator : IValidator<Caminhao>
    {
    }
}
