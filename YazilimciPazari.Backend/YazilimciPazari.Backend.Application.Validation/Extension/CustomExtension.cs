using FluentValidation;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimciPazari.Backend.Application.Validation.Extension
{
    static public class CustomExtension // bazı yerlerde aynı şeyi iki kere kullanma vardı onu önlemek için bunu yaptım. update için required yok kalanları aynı
    {
        #region Update
        static public IRuleBuilder<T, string> UpdateAdressValidation<T>(this IRuleBuilder<T, string> validation, int minLength = 0, int maxLength = 100)
            => validation.IsInRange(minLength, maxLength).IsValidUtf8();
        static public IRuleBuilder<T, string> UpdateDescriptionValidation<T>(this IRuleBuilder<T, string> validation, int minLength = 0, int maxLength = 100)
                    => validation.IsInRange(minLength, maxLength).IsValidUtf8();
        static public IRuleBuilder<T, string> UpdateNameValidation<T>(this IRuleBuilder<T, string> validation, int minLength = 0, int maxLength = 100)
                    => validation.IsInRange(minLength, maxLength).OnlyLetter();
        static public IRuleBuilder<T, string> UpdateWebsiteValidation<T>(this IRuleBuilder<T, string> validation, int minLength = 0, int maxLength = 100)
                    => validation.IsInRange(minLength, maxLength);
        static public IRuleBuilder<T, string> UpdateTextValidation<T>(this IRuleBuilder<T, string> validation, int minLength = 0, int maxLength = 100)
                    => validation.IsInRange(minLength, maxLength);

        #endregion

        #region Add

        static public IRuleBuilder<T, string> AddAdressValidation<T>(this IRuleBuilder<T, string> validation, int minLength = 0, int maxLength = 100)
            => validation.Required().UpdateAdressValidation(minLength, maxLength);
        static public IRuleBuilder<T, string> AddDescriptionValidation<T>(this IRuleBuilder<T, string> validation, int minLength = 0, int maxLength = 100)
                    => validation.Required().UpdateDescriptionValidation(minLength, maxLength);
        static public IRuleBuilder<T, string> AddNameValidation<T>(this IRuleBuilder<T, string> validation, int minLength = 0, int maxLength = 100)
                    => validation.Required().UpdateNameValidation(minLength, maxLength);
        static public IRuleBuilder<T, string> AddWebsiteValidation<T>(this IRuleBuilder<T, string> validation, int minLength = 0, int maxLength = 100)
                    => validation.Required().UpdateWebsiteValidation(minLength, maxLength);
        static public IRuleBuilder<T, string> AddPasswordValidation<T>(this IRuleBuilder<T, string> validation, int minLength = 0, int maxLength = 100)
                    => validation.Required().IsValidSha512();
        static public IRuleBuilder<T, string> AddTaxNumberValidation<T>(this IRuleBuilder<T, string> validation, int minLength = 0, int maxLength = 100)
                    => validation.Required().IsValidSha512();
        static public IRuleBuilder<T, string> AddTextValidation<T>(this IRuleBuilder<T, string> validation, int minLength = 0, int maxLength = 100)
                    => validation.Required().UpdateTextValidation(minLength, maxLength);

        #endregion
    }
}
