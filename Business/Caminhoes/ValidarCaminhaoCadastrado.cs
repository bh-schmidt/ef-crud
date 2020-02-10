using Data.Repositories.Caminhoes;
using FluentValidation;
using Models.Caminhoes;
using System.Threading.Tasks;
using Utils.Extensions;

namespace Business.Caminhoes
{
    public class ValidarCaminhaoCadastrado : AbstractValidator<Caminhao>, IValidarCaminhaoCadastrado
    {
        private readonly ICaminhaoRepository caminhaoRepository;

        public ValidarCaminhaoCadastrado(ICaminhaoRepository caminhaoRepository)
        {
            this.caminhaoRepository = caminhaoRepository;
        }

        public void AdicionarValidacao(AbstractValidator<Caminhao> validator)
        {
            validator.RuleFor(c => c.Id)
                .MustAsync((id, ct) => CaminhaoExistente(id))
                .WithMessage("O caminhão deve estar cadastrado.")
                .WithErrorCode("ValidarCaminhaoCadastrado01");
        }

        private async Task<bool> CaminhaoExistente(long? id)
        {
            if (id.IsNull())
                return false;

            return await caminhaoRepository.IdExistente(id.Value);
        }
    }
}
