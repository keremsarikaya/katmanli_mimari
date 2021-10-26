using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator: AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("İsim boş geçilemez");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Soyadı boş geçilemez");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkında boş geçilemez");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Unvan boş geçilemez");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("İsim en az 2 karakter olmak zorundadır");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("İsim 50 karakterden fazla olamaz");
        }
    }
}
