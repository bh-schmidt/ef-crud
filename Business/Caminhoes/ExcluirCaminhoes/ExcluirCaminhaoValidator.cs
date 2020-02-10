using FluentValidation;
using Models.Caminhoes;

namespace Business.Caminhoes.ExcluirCaminhoes
{
    public class ExcluirCaminhaoValidator : AbstractValidator<Caminhao>, IExcluirCaminhaoValidator
    {
        public ExcluirCaminhaoValidator(IValidarCaminhaoCadastrado validarCaminhaoCadastrado)
        {
            validarCaminhaoCadastrado.AdicionarValidacao(this);
        }
    }
}
