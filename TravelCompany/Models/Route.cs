using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelCompany.Models
{   // Представляет класс "Маршрут", содержащий информацию о маршруте
    [Table("Routes")]
    public class Route
    {   // Уникальный идентификатор маршрута
        [Key]
        public int RouteId { get; set; }
        // Страна назначения
        public string Country { get; set; }
        // Климат в стране назначения
        public string Climate { get; set; }
        // Продолжительность тура
        public int Duration { get; set; }
        // Название отеля
        public string Hotel { get; set; }
        // Стоимость путёвки
        public int Coast { get; set; }

        // Переопределение метода ToString()
        // Возвращает строковое представление объекта Teacher в виде фамилии, имени и отчества
        public override string ToString()
        {
            return $"{Country} {Climate} {Hotel}";
        }

        // Свойство, которое вычисляет полное имя преподавателя
        // Это свойство не сохраняется в базе данных
        [NotMapped]
        public string FullRoute => this.ToString();
    }

}
