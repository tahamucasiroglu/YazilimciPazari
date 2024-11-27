using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Domain.Extensions;

namespace YazilimciPazari.Backend.Service.DatabaseService.Extension
{
    public static class PasswordExtension
    {
        static public string PasswordEncrypt(this string password, string salt) => (password + salt).ToSha256();
        
    }
}
