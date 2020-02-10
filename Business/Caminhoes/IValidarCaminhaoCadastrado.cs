using FluentValidation;
using Models.Caminhoes;

namespace Business.Caminhoes
{
    public interface IValidarCaminhaoCadastrado
    {
        public void AdicionarValidacao(AbstractValidator<Caminhao> validator);
    }
}
