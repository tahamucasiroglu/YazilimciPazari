using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Domain.Entities.Base;

namespace YazilimciPazari.Backend.Domain.Entities.Concrete
{
    public class CompanyComment : Entity
    {
        public Guid CommentId { get; set; }
        public Guid CompanyId { get; set; }

        virtual public Comment Comment { get; set; } = new();
        virtual public Company Company { get; set; } = new();
    }
}
