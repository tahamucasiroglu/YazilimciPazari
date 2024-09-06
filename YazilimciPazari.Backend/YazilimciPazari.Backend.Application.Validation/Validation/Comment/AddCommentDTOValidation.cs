using YazilimciPazari.Backend.Application.Validation.Base;
using YazilimciPazari.Backend.Application.Validation.Extension;
using YazilimciPazari.Backend.Domain.DTOs.Concrete.Comment;

namespace YazilimciPazari.Backend.Application.Validation.Validation.Comment
{
    public class AddCommentDTOValidation : AddValidation<AddCommentDTO>
    {
        public AddCommentDTOValidation() : base()
        {
            RuleFor(e => e.Text).AddTextValidation(maxLength:500);
        }
    }
}
