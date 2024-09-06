using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace YazilimciPazari.Backend.Domain.Extensions
{
    static public class StringExtension
    {
        static public bool IsPhoneNumber(this string? str)
            => !string.IsNullOrEmpty(str) && Regex.IsMatch(str, @"^(\+90|0)?5\d{9}$");

        static public bool IsIdentityNumber(this string? str)
        {
            if (string.IsNullOrWhiteSpace(str) || str.Length != 11)
            {
                return false;
            }
                
            int[] digits = str.Select(c => (int)char.GetNumericValue(c)).ToArray();

            int sumOddDigits = digits[0] + digits[2] + digits[4] + digits[6] + digits[8];
            int sumEvenDigits = digits[1] + digits[3] + digits[5] + digits[7];

            int tenthDigit = (sumOddDigits * 7 - sumEvenDigits) % 10;
            if (tenthDigit < 0) tenthDigit += 10;

            int eleventhDigit = (sumOddDigits + sumEvenDigits + digits[9]) % 10;

            return digits[9] == tenthDigit && digits[10] == eleventhDigit;
        }

        static public bool IsValidTaxNumber(this string? taxNumber)
        {
            if (string.IsNullOrWhiteSpace(taxNumber) || taxNumber.Length != 10)
            {
                return false; 
            }
            int[] digits = taxNumber.Select(c => (int)char.GetNumericValue(c)).ToArray();
            int sum = 0;
            for (int i = 0; i < 9; i++)
            {
                int digit = digits[i];
                int subtracted = digit + 10 - ((i + 1) % 10);
                sum += subtracted % 10;
            }
            int checkDigit = (sum % 10 == 0) ? 0 : (10 - (sum % 10));
            return checkDigit == digits[9];
        }



        static public string ToSha256(this string str)
        {
            using (var hash = SHA256.Create())
            {
                var result = hash.ComputeHash(Encoding.UTF8.GetBytes(str));
                return BitConverter.ToString(result).Replace("-", "").ToLower();
            }
        }


        static public bool IsOnlyLetter(this string str) => str.All(char.IsLetter);


        static public bool IsLetterOrDigit(this string str) => str.All(char.IsLetterOrDigit);


        static public bool IsValidUtf8(this string str) => Regex.IsMatch(str, @"^[\p{L}\p{N}]+$");

        static public bool IsOnlyDigits(this string str) => Regex.IsMatch(str, @"^\d+$");

        static public bool IsSha512Hash(this string str) => !string.IsNullOrEmpty(str) && str.Length == 128 && Regex.IsMatch(str, @"^[a-fA-F0-9]+$");
    }
}
