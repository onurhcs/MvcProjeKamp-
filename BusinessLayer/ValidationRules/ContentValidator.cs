using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ContentValidator : AbstractValidator<Content>
    {
        public ContentValidator()
        {
            // ContentValue doğrulama
            RuleFor(x => x.ContentValue)
                .NotEmpty().WithMessage("İçerik Değerini Boş Geçemezsiniz.")
                .MinimumLength(3).WithMessage("Lütfen En Az 3 Karakter Girişi Yapınız.")
                .MaximumLength(1000).WithMessage("İçerik 1000 Karakterden Fazla Olamaz.");

            // ContentDate doğrulama
            RuleFor(x => x.ContentDate)
                .NotEmpty().WithMessage("İçerik Tarihini Boş Geçemezsiniz.")
                .LessThanOrEqualTo(DateTime.Now).WithMessage("İçerik Tarihi Gelecekte Olamaz.");

            // HeadingId doğrulama
            RuleFor(x => x.HeadingId)
                .NotEmpty().WithMessage("Başlık ID'sini Boş Geçemezsiniz.")
                .GreaterThan(0).WithMessage("Başlık ID 0'dan Büyük Olmalıdır.");

            // WriterId doğrulama
            RuleFor(x => x.WriterId)
                .NotEmpty().WithMessage("Yazar ID'sini Boş Geçemezsiniz.")
                .GreaterThan(0).WithMessage("Yazar ID 0'dan Büyük Olmalıdır.");
        }


    }
    
}
