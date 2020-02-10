using FluentValidation;
using Models.Caminhoes;

namespace Business.Caminhoes
{
    public interface IValidarModelo
    {
        public void AdicionarValidacao(AbstractValidator<Caminhao> validator);
    }
}
