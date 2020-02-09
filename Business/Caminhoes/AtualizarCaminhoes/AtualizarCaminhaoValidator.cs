using Data.Repositories.Caminhoes;
using FluentValidation;
using Models.Caminhoes;
using System.Threading.Tasks;
using Utils.Extensions;

namespace Business.Caminhoes.AtualizarCaminhoes
{
    public class AtualizarCaminhaoValidator : AbstractValidator<Caminhao>, IAtualizarCaminhaoValidator
    {
        private readonly ICaminhaoRepository caminhaoRepository;

        public AtualizarCaminhaoValidator(ICaminhaoRepository caminhaoRepository)
        {
            this.caminhaoRepository = caminhaoRepository;

            RuleFor(c => c.Id)
                .NotNull()
                .WithMessage("O id deve ser diferente de null.")
                .MustAsync((id, ct) => CaminhaoExistente(id))
                .WithMessage("O caminhão deve estar cadastrado.");

            this.ValidarModelo();
            this.ValidarAnoFabricacao();
            this.ValidarAnoModelo();
        }

        private async Task<bool> CaminhaoExistente(long? id) {
            if (id.IsNull())
                return false;

            return await caminhaoRepository.ModelExistente(id.Value);
        }
    }
}
