using EntityLayer.Entites;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validations
{
    public class ReaderValidator : AbstractValidator<Reader>
    {
        public ReaderValidator() //Okuyucu için validasyonumu gerçekleştirdim
        {
            RuleFor(x => x.ReaderFullName).Matches(@"(?!^\d+$)^.+$").WithMessage("Lütfen geçerli bir okuyucu giriniz").NotEmpty().WithMessage("Lütfen okuyucu adı giriniz.");
        }
    }
}
