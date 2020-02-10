using FluentValidation;
using Models.Caminhoes;

namespace Business.Caminhoes
{
    public interface IValidarAnoFabricacao
    {
        public void AdicionarValidacao(AbstractValidator<Caminhao> validator);
    }
}
