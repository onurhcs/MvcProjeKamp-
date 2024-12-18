using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Admin
    {

        [Key]
        public int AdminID { get; set; } // Benzersiz ID

        [Required(ErrorMessage = "Kullanıcı adı gereklidir.")]
        [StringLength(50, ErrorMessage = "Kullanıcı adı en fazla 50 karakter olabilir.")]
        public string AdminUserName { get; set; } // Kullanıcı adı

        [Required(ErrorMessage = "Şifre gereklidir.")]
        [StringLength(255, ErrorMessage = "Şifre en fazla 255 karakter olabilir.")]
        public string AdminPassword { get; set; } // Şifre (hash'lenmiş olarak tutulmalı)

        [Required(ErrorMessage = "E-posta adresi gereklidir.")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi girin.")]
        [StringLength(100, ErrorMessage = "E-posta en fazla 100 karakter olabilir.")]
        public string AdminEmail { get; set; } // E-posta adresi

        [Required(ErrorMessage = "Rol alanı gereklidir.")]
        [StringLength(30, ErrorMessage = "Rol en fazla 30 karakter olabilir.")]
        public string AdminRole { get; set; } // Rol (örneğin: SuperAdmin, Editor)

        [StringLength(255, ErrorMessage = "Profil resmi yolu en fazla 255 karakter olabilir.")]
        public string ProfileImage { get; set; } // Profil resmi yolu

        [StringLength(1100, ErrorMessage = "Tam ad en fazla 1100 karakter olabilir.")]
        public string FullName { get; set; } // Admin'in tam adı



    }
}
