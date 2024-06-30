using TravelCompany.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelCompany.Data
{   // Представляет контекст данных для приложения "Туристическая фирма"
    public class TravelContext : DbContext
    {   // Коллекция сущностей "Клиент", представленных в базе данных
        public DbSet<Client> Clients { get; set; }
        // Коллекция сущностей "Маршрут", представленных в базе данных
        public DbSet<Route> Routes { get; set; }
        // Коллекция сущностей "Путёвка", представленных в базе данных
        public DbSet<TravelPackage> Travels { get; set; }

        // Конфигурирует параметры подключения к базе данных SQL Server
        // optionsBuilder - Строитель параметров контекста базы данных
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Проверяет, была ли уже выполнена конфигурация подключения
            if (!optionsBuilder.IsConfigured)
            {
                // Устанавливает параметры подключения к базе данных SQL Server
                optionsBuilder.UseSqlServer("Server = localhost; Database = TravelCompanyBD1; Trusted_Connection = True;");
            }
        }

    }
}
