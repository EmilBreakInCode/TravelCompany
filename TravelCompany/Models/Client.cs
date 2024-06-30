using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace TravelCompany.Models
{   // Представляет класс "Клиент", содержащий информацию о преподавателе
    [Table("Clients")]
    public class Client
    {
        // Уникальный идентификатор клиента
        [Key]
        public int ClientId {  get; set; }
        // Фамилия клиенента
        public string Surname { get; set; }
        // Имя клиента
        public string Firstname { get; set; }
        // Отчество клиента
        public string Patronymic { get; set; }
        // Адрес телефон клиента
        public string Address { get; set; }
        // Контактный телефон клиента
        public string Telephone { get; set; }

        // Переопределение метода ToString()
        // Возвращает строковое представление объекта Teacher в виде фамилии, имени и отчества
        public override string ToString()
        {
            return $"{Surname} {Firstname} {Patronymic}";
        }

        // Свойство, которое вычисляет полное имя преподавателя
        // Это свойство не сохраняется в базе данных
        [NotMapped]
        public string FullName => this.ToString();
    }
}
