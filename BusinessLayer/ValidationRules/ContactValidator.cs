using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            // UserName doğrulama
            RuleFor(x => x.UserName)
                .NotEmpty().WithMessage("Kullanıcı adını boş geçemezsiniz.")
                .MinimumLength(3).WithMessage("Kullanıcı adı en az 3 karakterden oluşmalıdır.")
                .MaximumLength(50).WithMessage("Kullanıcı adı en fazla 50 karakter olabilir.");

            // UsserMail doğrulama
            RuleFor(x => x.UsserMail)
                .NotEmpty().WithMessage("E-posta adresini boş geçemezsiniz.")
                .EmailAddress().WithMessage("Geçerli bir e-posta adresi giriniz.")
                .MaximumLength(50).WithMessage("E-posta adresi en fazla 50 karakter olabilir.");

            // Subject doğrulama
            RuleFor(x => x.Subject)
                .NotEmpty().WithMessage("Konu alanını boş geçemezsiniz.")
                .MinimumLength(5).WithMessage("Konu en az 5 karakterden oluşmalıdır.")
                .MaximumLength(50).WithMessage("Konu en fazla 50 karakter olabilir.");

            // Message doğrulama
            RuleFor(x => x.Message)
                .NotEmpty().WithMessage("Mesaj alanını boş geçemezsiniz.")
                .MinimumLength(10).WithMessage("Mesaj en az 10 karakterden oluşmalıdır.")
                .MaximumLength(2000).WithMessage("Mesaj en fazla 2000 karakter olabilir.");
        }


    }
}
