using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestShop_ASP_Project.Data.Models
{
    public class Order
    {
        [BindNever]
        public int Id { get; set; }

        [Display(Name = "Введите имя")]
        [StringLength(4)]
        [Required(ErrorMessage = "Длина имени менее 4 символов")]
        public string Name { get; set; }

        [Display(Name = "Введите фамилию")]
        [StringLength(4)]
        [Required(ErrorMessage = "Длина фамилии менее 4 символов")]
        public string Surname { get; set; }

        [Display(Name = "Введите адрес")]
        [StringLength(15)]
        [Required(ErrorMessage = "Адрес введён неверно")]
        public string Address { get; set; }

        [Display(Name = "Введите номер телефона")]
        [StringLength(10)]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Длина номера менее 10 символов")]
        public string Phone { get; set; }

        [Display(Name = "Введите электронный адрес")]
        [StringLength(10)]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Электронный адрес введён неверно")]
        public string Email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderTime { get; set; }

        [BindNever]
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
