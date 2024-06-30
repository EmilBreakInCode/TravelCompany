using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelCompany.Forms.ExportForms
{
    public partial class HtmlExportForm : Form
    {
        private MainForm _mainForm;
        public HtmlExportForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void ClientsButton_Click(object sender, EventArgs e)
        {
            string fileName = System.Windows.Forms.Application.StartupPath + @"Export\Html\Clients\" + $"Отчёт-Html-клиентов{DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss")}.html";

            StreamWriter streamWriter = new StreamWriter(fileName, false, System.Text.Encoding.Default);

            //Запись в файл заголовок html страницы
            streamWriter.WriteLine("<html>");
            streamWriter.WriteLine("<head><title>Туристическая фирма</title></head>");
            streamWriter.WriteLine("<body>");

            //Записываем в файл название отчёта и заголовки таблицы
            streamWriter.WriteLine("<h1>Клиенты</h1>");
            streamWriter.WriteLine("<table border=1>");
            streamWriter.WriteLine("<tr>");
            streamWriter.WriteLine("<th>№ п/п</th>");
            streamWriter.WriteLine("<th>Фамилия</th>");
            streamWriter.WriteLine("<th>Имя</th>");
            streamWriter.WriteLine("<th>Отчество</th>");
            streamWriter.WriteLine("<th>Адрес</th>");
            streamWriter.WriteLine("<th>Телефон</th>");
            streamWriter.WriteLine("</tr>");

            //В цикле выводим строки таблицы в html документ
            foreach(DataGridViewRow c in _mainForm.GetClientsDataGridView().Rows)
            {
                streamWriter.WriteLine("<tr>");
                streamWriter.WriteLine("<td>" + c.Cells["ClientId"].Value + "</td>");
                streamWriter.WriteLine("<td>" + c.Cells["Surname"].Value + "</td>");
                streamWriter.WriteLine("<td>" + c.Cells["Firstname"].Value + "</td>");
                streamWriter.WriteLine("<td>" + c.Cells["Patronymic"].Value + "</td>");
                streamWriter.WriteLine("<td>" + c.Cells["Address"].Value + "</td>");
                streamWriter.WriteLine("<td>" + c.Cells["Telephone"].Value + "</td>");
                streamWriter.WriteLine("</tr>");
            }

            // Записываем закрывающие теги HTML документа
            streamWriter.WriteLine("</table>");
            streamWriter.WriteLine("</body>");
            streamWriter.WriteLine("</html>");
            MessageBox.Show($"Отчет сохранен в: '{fileName}'");

            streamWriter.Close();
        }

        private void RoutesButton_Click(object sender, EventArgs e)
        {
            string fileName = System.Windows.Forms.Application.StartupPath + @"Export\Html\Routes\" + $"Отчёт-Html-маршрутов{DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss")}.html";

            StreamWriter streamWriter = new StreamWriter(fileName, false, System.Text.Encoding.Default);

            //Запись в файл заголовок html страницы
            streamWriter.WriteLine("<html>");
            streamWriter.WriteLine("<head><title>Туристическая фирма</title></head>");
            streamWriter.WriteLine("<body>");

            //Записываем в файл название отчёта и заголовки таблицы
            streamWriter.WriteLine("<h1>Маршруты</h1>");
            streamWriter.WriteLine("<table border=1>");
            streamWriter.WriteLine("<tr>");
            streamWriter.WriteLine("<th>№ п/п</th>");
            streamWriter.WriteLine("<th>Страна</th>");
            streamWriter.WriteLine("<th>Климат</th>");
            streamWriter.WriteLine("<th>Длительность</th>");
            streamWriter.WriteLine("<th>Отель</th>");
            streamWriter.WriteLine("<th>Стоимость</th>");
            streamWriter.WriteLine("</tr>");

            //В цикле выводим строки таблицы в html документ
            foreach (DataGridViewRow c in _mainForm.GetRoutesDataGridView().Rows)
            {
                streamWriter.WriteLine("<tr>");
                streamWriter.WriteLine("<td>" + c.Cells["RouteId"].Value + "</td>");
                streamWriter.WriteLine("<td>" + c.Cells["Country"].Value + "</td>");
                streamWriter.WriteLine("<td>" + c.Cells["Climate"].Value + "</td>");
                streamWriter.WriteLine("<td>" + c.Cells["Duration"].Value + "</td>");
                streamWriter.WriteLine("<td>" + c.Cells["Hotel"].Value + "</td>");
                streamWriter.WriteLine("<td>" + c.Cells["Coast"].Value + "</td>");
                streamWriter.WriteLine("</tr>");
            }

            // Записываем закрывающие теги HTML документа
            streamWriter.WriteLine("</table>");
            streamWriter.WriteLine("</body>");
            streamWriter.WriteLine("</html>");
            MessageBox.Show($"Отчет сохранен в: '{fileName}'");

            streamWriter.Close();
        }

        private void TravelPackagesButtton_Click(object sender, EventArgs e)
        {
            string fileName = System.Windows.Forms.Application.StartupPath + @"Export\Html\Travels\" + $"Отчёт-Html-путёвок{DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss")}.html";

            StreamWriter streamWriter = new StreamWriter(fileName, false, System.Text.Encoding.Default);

            //Запись в файл заголовок html страницы
            streamWriter.WriteLine("<html>");
            streamWriter.WriteLine("<head><title>Туристическая фирма</title></head>");
            streamWriter.WriteLine("<body>");

            //Записываем в файл название отчёта и заголовки таблицы
            streamWriter.WriteLine("<h1>Путёвки</h1>");
            streamWriter.WriteLine("<table border=1>");
            streamWriter.WriteLine("<tr>");
            streamWriter.WriteLine("<th>№ п/п</th>");
            streamWriter.WriteLine("<th>Маршрут детально</th>");
            streamWriter.WriteLine("<th>ФИО клиента</th>");
            streamWriter.WriteLine("<th>Дата отправления</th>");
            streamWriter.WriteLine("<th>Количество</th>");
            streamWriter.WriteLine("<th>Скидка</th>");
            streamWriter.WriteLine("</tr>");

            //В цикле выводим строки таблицы в html документ
            foreach (DataGridViewRow c in _mainForm.GetTravelPackagesDataGridView().Rows)
            {
                streamWriter.WriteLine("<tr>");
                streamWriter.WriteLine("<td>" + c.Cells["TravelId"].Value + "</td>");
                streamWriter.WriteLine("<td>" + c.Cells["FullRoute"].Value + "</td>");
                streamWriter.WriteLine("<td>" + c.Cells["FullName"].Value + "</td>");
                streamWriter.WriteLine("<td>" + c.Cells["DateOf"].Value + "</td>");
                streamWriter.WriteLine("<td>" + c.Cells["Count"].Value + "</td>");
                streamWriter.WriteLine("<td>" + c.Cells["Discount"].Value + "</td>");
                streamWriter.WriteLine("</tr>");
            }

            // Записываем закрывающие теги HTML документа
            streamWriter.WriteLine("</table>");
            streamWriter.WriteLine("</body>");
            streamWriter.WriteLine("</html>");
            MessageBox.Show($"Отчет сохранен в: '{fileName}'");

            streamWriter.Close();
        }
    }
}
