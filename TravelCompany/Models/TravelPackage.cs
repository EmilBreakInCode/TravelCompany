using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelCompany.Models
{   // Представляет класс "Путёвка", содержащий информацию об путёвке
    [Table("TravelPackage")]
    public class TravelPackage
    {
        //Содержит код путёвки
        [Key]
        public int TravelId { get; set; }
        // Содержит код маршрута
        [Required]
        public int RouteId {  get; set; }
        // Содержит код клиента
        [Required]
        public int ClientId { get; set; }

        public Client Client { get; set; }
        public Route Route {  get; set; }

        // Содержит дату отправки
        public DateTime DateOf { get; set; }
        // Информация о количестве купленных путёвок
        public int Count { get; set; }
        // Размер скидки
        public int Discount {  get; set; }
    }
}
