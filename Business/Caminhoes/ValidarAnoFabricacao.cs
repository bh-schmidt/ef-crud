using FluentValidation;
using Models.Caminhoes;
using System;

namespace Business.Caminhoes
{
    public class ValidarAnoFabricacao : IValidarAnoFabricacao
    {
        public void AdicionarValidacao(AbstractValidator<Caminhao> validator) =>
            validator.RuleFor(c => c.AnoFabricacao)
                .Must(ano => AnoFabricacaoValido(ano))
                .WithMessage(MensagemAnoFabricacaoInvalido())
                .WithErrorCode("ValidarAnoFabricacao01");

        private static bool AnoFabricacaoValido(int ano) =>
            ano == DateTime.Now.Year;

        private static string MensagemAnoFabricacaoInvalido() =>
            $"Só é possível cadastrar um caminhão com o ano de fabricação igual a {DateTime.Now.Year}.";
    }
}
