using FluentValidation;
using Models.Caminhoes;

namespace Business.Caminhoes
{
    public interface IValidarAnoModelo
    {
        public void AdicionarValidacao(AbstractValidator<Caminhao> validator);
    }
}
