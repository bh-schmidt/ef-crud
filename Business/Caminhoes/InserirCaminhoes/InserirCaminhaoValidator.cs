using FluentValidation;
using Models.Caminhoes;
using System;

namespace Business.Caminhoes
{
    public class InserirCaminhaoValidator : AbstractValidator<Caminhao>, IInserirCaminhaoValidator
    {
        public InserirCaminhaoValidator(
            IValidarModelo validarModelo,
            IValidarAnoFabricacao validarAnoFabricacao,
            IValidarAnoModelo validarAnoModelo)
        {
            RuleFor(c => c.Id)
                .Null()
                .WithMessage("O id deve ser null.")
                .WithErrorCode("InserirCaminhaoValidator01");

            validarModelo.AdicionarValidacao(this);
            validarAnoFabricacao.AdicionarValidacao(this);
            validarAnoModelo.AdicionarValidacao(this);
        }
    }
}
