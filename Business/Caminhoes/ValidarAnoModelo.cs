using FluentValidation;
using Models.Caminhoes;
using System;

namespace Business.Caminhoes
{
    public class ValidarAnoModelo : IValidarAnoModelo
    {
        public void AdicionarValidacao(AbstractValidator<Caminhao> validator) =>
            validator.RuleFor(c => c.AnoModelo)
                .Must(ano => AnoModeloValido(ano))
                .WithMessage(MensagemAnoModeloInvalido())
                .WithErrorCode("ValidarAnoModelo01");


        private static bool AnoModeloValido(int ano) =>
            ano == DateTime.Now.Year || ano == DateTime.Now.Year + 1;

        private static string MensagemAnoModeloInvalido() =>
            $"Só é possível cadastrar um caminhão com o ano de modelo igual a {DateTime.Now.Year} ou {DateTime.Now.Year + 1}.";
    }
}
