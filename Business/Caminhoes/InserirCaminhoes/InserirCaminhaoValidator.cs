using FluentValidation;
using Models.Caminhoes;
using System;

namespace Business.Caminhoes
{
    public class InserirCaminhaoValidator : AbstractValidator<Caminhao>, IInserirCaminhaoValidator
    {
        public InserirCaminhaoValidator()
        {
            RuleFor(c => c.Id)
                .Null()
                .WithMessage("O id deve ser null.");

            this.ValidarModelo();
            this.ValidarAnoFabricacao();
            this.ValidarAnoModelo();
        }
    }
}
