using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Domain.Extensions;

namespace YazilimciPazari.Backend.Application.Validation.Extension
{
    static public class ValidateExtension
    {
        static public IRuleBuilder<T, Guid> IdValidation<T>(this IRuleBuilder<T, Guid> validation, string nonIdMessage = "Id Bulunamadı", string idGuidMessage="Id tipi hatalı")
            => validation.Required(nonIdMessage).IsGuid(idGuidMessage);

        static public IRuleBuilder<T, TProperty> Required<T, TProperty>(this IRuleBuilder<T, TProperty> validation, string message = "Zorunlu alan boş bırakılmış")
            => validation.NotEmpty().NotNull().WithMessage(message);

        static public IRuleBuilder<T, TProperty> IsGuid<T, TProperty>(this IRuleBuilder<T, TProperty> validation, string message = "Id tipi hatalı")
            => validation.Must(e => e?.ToString()?.Length == 32).WithMessage(message);

        static public IRuleBuilder<T, string> IsInRange<T>(this IRuleBuilder<T, string> validation, int minLength, int maxLength, string message = "Yazı istenilen uzunluk sınırında değil")
            => validation.MaximumLength(maxLength).MinimumLength(minLength).WithMessage(message);

        static public IRuleBuilder<T, string> OnlyLetter<T>(this IRuleBuilder<T, string> validation, string message = "Yazıda tanımlanamayan karakterler mevcut sadece harf ile yazınız")
            => validation.Must(e => e.IsOnlyLetter()).WithMessage(message);

        static public IRuleBuilder<T, string> OnlyLetterOrDigit<T>(this IRuleBuilder<T, string> validation, string message = "Yazıda tanımlanamayan karakterler mevcut harf ve rakam dışında karakter kullanmayın")
            => validation.Must(e => e.IsLetterOrDigit()).WithMessage(message);

        static public IRuleBuilder<T, string> IsValidUtf8<T>(this IRuleBuilder<T, string> validation, string message = "Yazıda tanımlanamayan karakterler mevcut Utf8 standartları içinde yazınız.")
            => validation.Must(e => e.IsValidUtf8()).WithMessage(message);

        static public IRuleBuilder<T, string> IsValidSha512<T>(this IRuleBuilder<T, string> validation, string message = "Şifrelenmesi gereken değer istenilen şekilde değil. Kritik Hata")
            => validation.Must(e => e.IsSha512Hash()).WithMessage(message);


    }
}
