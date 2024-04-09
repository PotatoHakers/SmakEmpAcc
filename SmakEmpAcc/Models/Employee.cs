using System.ComponentModel.DataAnnotations;

namespace SmakEmpAcc.Models
{
    public class Employee
    {
        public int Id { get; set; } // Универсальное ID
        [Required]
        public string Name { get; set; } // Имя
        [Required]
        public int Age { get; set; } // Возраст
        [Required]
        public string Position { get; set; } // Должность
        [Required]
        public string Address { get; set; } // Адрес
        [Required]
        public string PassportData { get; set; } // Паспортные данные
        [Required]
        public string Phone { get; set; } // Телефон
    }
}
