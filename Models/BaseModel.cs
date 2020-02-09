using FluentValidation;
using FluentValidation.Results;

namespace Models
{
    public abstract class BaseModel
    {
        public long? Id { get; set; }
        public ValidationResult? ValidationResult { get; set; }
        public bool Valid => ValidationResult?.IsValid ?? false;

        public void Validar<TModel>(IValidator<TModel> validator) where TModel : BaseModel
        {
            ValidationResult = validator.Validate((TModel)this);
        }
    }
}
