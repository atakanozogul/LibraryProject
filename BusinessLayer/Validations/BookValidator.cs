using EntityLayer.Entites;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validations
{
    public class BookValidator : AbstractValidator<Book>
    {
        public BookValidator() //Kitap için validasyonlarımı gerçekleştirdim
        {
            RuleFor(x => x.BookName).Matches(@"(?!^\d+$)^.+$").WithMessage("Lütfen geçerli kitap adı giriniz").NotEmpty().WithMessage("Lütfen kitap Adı giriniz.");
            RuleFor(x => x.BookAuthor).NotEmpty().WithMessage("Lütfen yazar giriniz.");
            RuleFor(x => x.BookImageUrl).NotEmpty().WithMessage("Lütfen fotoğraf URL adresi giriniz");
        }
    }
}
