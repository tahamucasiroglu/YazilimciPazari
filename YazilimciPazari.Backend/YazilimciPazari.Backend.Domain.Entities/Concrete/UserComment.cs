using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Domain.Entities.Base;

namespace YazilimciPazari.Backend.Domain.Entities.Concrete
{
    public class UserComment : Entity
    {
        public Guid UserId  { get; set; }
        public Guid CommentId { get; set; }

        virtual public User User { get; set; } = new();
        virtual public Comment Comment { get; set; } = new();
    }
}
