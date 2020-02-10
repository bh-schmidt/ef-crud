using FluentValidation;
using FluentValidation.Results;
using System.Threading.Tasks;

namespace Models
{
    public abstract class BaseModel
    {
        public long? Id { get; set; }
        public ValidationResult? ValidationResult { get; set; }
        public bool Valid => ValidationResult?.IsValid ?? false;

        public void Validar<TModel>(IValidator<TModel> validator) where TModel : BaseModel =>
            ValidationResult = validator.Validate((TModel)this);

        public async Task ValidarAsync<TModel>(IValidator<TModel> validator) where TModel : BaseModel =>
            ValidationResult = await validator.ValidateAsync((TModel)this);
    }
}
