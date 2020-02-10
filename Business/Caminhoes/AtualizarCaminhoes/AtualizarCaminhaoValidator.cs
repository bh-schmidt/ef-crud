using FluentValidation;
using Models.Caminhoes;

namespace Business.Caminhoes.AtualizarCaminhoes
{
    public class AtualizarCaminhaoValidator : AbstractValidator<Caminhao>, IAtualizarCaminhaoValidator
    {
        public AtualizarCaminhaoValidator(
            IValidarModelo validarModelo,
            IValidarAnoFabricacao validarAnoFabricacao,
            IValidarAnoModelo validarAnoModelo,
            IValidarCaminhaoCadastrado caminhaoExistenteValidator)
        {

            RuleFor(c => c.Id)
                .NotNull()
                .WithMessage("O id deve ser diferente de null.")
                .WithErrorCode("AtualizarCaminhaoValidator01");

            validarModelo.AdicionarValidacao(this);
            validarAnoFabricacao.AdicionarValidacao(this);
            validarAnoModelo.AdicionarValidacao(this);
            caminhaoExistenteValidator.AdicionarValidacao(this);
        }
    }
}
