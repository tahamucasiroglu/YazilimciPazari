﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimciPazari.Backend.Domain.Extensions
{
    static public class IntegerExtension
    {
        static public string ToSha256(this int num) => num.ToString().ToSha256();
    }
}
