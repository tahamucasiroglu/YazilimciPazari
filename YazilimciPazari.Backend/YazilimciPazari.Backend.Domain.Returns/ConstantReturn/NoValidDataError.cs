using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Domain.Returns.Concrete;

namespace YazilimciPazari.Backend.Domain.Returns.ConstantReturn
{
    public sealed record NoValidDataError : ErrorReturn
    {
        public NoValidDataError() : base("Data not valid") { }
    }
}
