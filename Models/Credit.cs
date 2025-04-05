using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MvcCreditApp.Models
{
    public class Credit
    {
        public virtual int CreditId { get; set; }

        [DisplayName("Название кредита")]
        [Required]
        public virtual string Head { get; set; }

        [DisplayName("Срок кредита (мес.)")]
        [Required]
        public virtual int Period { get; set; }

        [DisplayName("Максимальная сумма")]
        [Required]
        public virtual int Sum { get; set; }

        [DisplayName("Процентная ставка")]
        [Required]
        public virtual int Procent { get; set; }
    }
}
