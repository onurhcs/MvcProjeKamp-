using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class HeadigValidator : AbstractValidator<Heading>
    {
        public HeadigValidator()
        {
            RuleFor(x => x.HeadingName)
            .NotEmpty().WithMessage("Başlık Adını Boş Geçemezsiniz.")
            .MinimumLength(3).WithMessage("Lütfen En Az 3 Karakter Girişi Yapınız.")
            .MaximumLength(50).WithMessage("Lütfen 50 Karakterden Fazla Değer Girişi Yapmayın.");

            RuleFor(x => x.HeadingDate)
                .NotEmpty().WithMessage("Başlık Tarihini Boş Geçemezsiniz.");

            RuleFor(x => x.CategoryId)
                .NotEmpty().WithMessage("Kategori ID'sini Boş Geçemezsiniz.")
                .GreaterThan(0).WithMessage("Kategori ID 0'dan Büyük Olmalıdır.");

            RuleFor(x => x.WriterId)
                .NotEmpty().WithMessage("Yazar ID'sini Boş Geçemezsiniz.")
                .GreaterThan(0).WithMessage("Yazar ID 0'dan Büyük Olmalıdır.");
        }


    }
}
