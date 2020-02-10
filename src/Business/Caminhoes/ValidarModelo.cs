using FluentValidation;
using Models.Caminhoes;

namespace Business.Caminhoes
{
    public class ValidarModelo : IValidarModelo
    {
        private const string MensagemModeloInvalido = "O modelo é inválido.";

        public void AdicionarValidacao(AbstractValidator<Caminhao> validator) =>
            validator.RuleFor(c => c.Modelo)
                .IsInEnum()
                .WithMessage(MensagemModeloInvalido)
                .WithErrorCode("ValidarModelo01");
    }
}
