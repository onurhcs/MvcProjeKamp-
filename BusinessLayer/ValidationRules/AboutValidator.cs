using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.AboutDetails1)
           .NotEmpty().WithMessage("Detay 1 alanını boş geçemezsiniz.")
           .MinimumLength(10).WithMessage("Lütfen en az 10 karakter giriniz.")
           .MaximumLength(1100).WithMessage("Detay 1 alanı 1100 karakterden fazla olamaz.");

            // AboutDetails2 doğrulama
            RuleFor(x => x.AboutDetails2)
                .NotEmpty().WithMessage("Detay 2 alanını boş geçemezsiniz.")
                .MinimumLength(10).WithMessage("Lütfen en az 10 karakter giriniz.")
                .MaximumLength(1100).WithMessage("Detay 2 alanı 1100 karakterden fazla olamaz.");

            // AboutImage2 doğrulama
            RuleFor(x => x.AboutImage2)
                .NotEmpty().WithMessage("İkinci görsel bağlantısını boş geçemezsiniz.")
                .MaximumLength(100).WithMessage("Görsel bağlantısı 100 karakterden fazla olamaz.");
        }


    }
    
}
