using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Lütfen adınızı giriniz.");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Lütfen mail adresinizi giriniz.");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Lütfen şifrenizi giriniz.");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen en az 2 karakter giriniz.");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("En fazla 50 karakter girebilirsiniz.");
        }
    }
}
