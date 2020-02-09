using FluentValidation;
using Models.Caminhoes;
using System;

namespace Business.Caminhoes
{
    public static class CaminhaoRules
    {
        private const string MensagemModeloInvalido = "O modelo é inválido.";

        public static void ValidarModelo(this AbstractValidator<Caminhao> validator) =>
            validator.RuleFor(c => c.Modelo)
                .IsInEnum()
                .WithMessage(MensagemModeloInvalido);

        public static void ValidarAnoFabricacao(this AbstractValidator<Caminhao> validator) =>
            validator.RuleFor(c => c.AnoFabricacao)
                .Must(ano => AnoFabricacaoValido(ano))
                .WithMessage(MensagemAnoFabricacaoInvalido());

        public static void ValidarAnoModelo(this AbstractValidator<Caminhao> validator) =>
            validator.RuleFor(c => c.AnoModelo)
                .Must(ano => AnoModeloValido(ano))
                .WithMessage(MensagemAnoModeloInvalido());

        private static bool AnoFabricacaoValido(short ano) =>
            ano == DateTime.Now.Year;

        private static bool AnoModeloValido(short ano) =>
            ano == DateTime.Now.Year || ano == DateTime.Now.Year + 1;

        private static string MensagemAnoFabricacaoInvalido() =>
            $"Só é possível cadastrar um caminhão com o ano de fabricação igual a {DateTime.Now.Year}.";

        private static string MensagemAnoModeloInvalido() =>
            $"Só é possível cadastrar um caminhão com o ano de modelo igual a {DateTime.Now.Year} ou {DateTime.Now.Year + 1}.";
    }
}
