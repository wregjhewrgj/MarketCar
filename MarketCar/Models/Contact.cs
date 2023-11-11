using System.ComponentModel.DataAnnotations; // исправленное пространство имён
namespace MarketCar.Models
{
    public class Contact
    {
        [Display(Name = "Введите Имя")]
        public string Name { get; set; }

        [Display(Name = "Введите почту")]
        public string Email { get; set; }

        public string Message { get; set; }
    }
}
