using System.ComponentModel.DataAnnotations;
using Book_api_core.Validations;

namespace Book_api_core.Models
{
    public class UpdateBookDto
    {
        [Required(ErrorMessage = "لطفا عنوان کتاب را وارد کنید")]
        [BanKeyword]
        public string Title { get; set; }

        [MaxLength(40, ErrorMessage = "طول توضیحات نمیتواند بیشتر از 40 کاراکتر باشد")]
        public string Description { get; set; }

        [Range(1000.0, 1000000.0, ErrorMessage = "مبلغ باید بین 1000 تا 1 میلیون تومان باشد")]
        public int Amount { get; set; }
    }
}