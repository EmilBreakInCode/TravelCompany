using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelCompany.Data;
using TravelCompany.Forms.Clients;
using TravelCompany.Forms.Routes;
using TravelCompany.Forms.TravelPackages;
using TravelCompany.Models;
using Microsoft.EntityFrameworkCore;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using Aspose.Words;
using Aspose.Words.Tables;
using Aspose.Words.Reporting;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;
using System.IO;
using TravelCompany.Forms.ExportForms;
using System.Runtime.InteropServices;

namespace TravelCompany.Forms.ExportForms
{
    public partial class ExcelExportForm : Form
    {
        //Объект приложения
        private Microsoft.Office.Interop.Excel.Application ExcelApp;
        //Объект окна Excel
        private Microsoft.Office.Interop.Excel.Window ExcelWindow;
        //Объект рабочей книги
        private Microsoft.Office.Interop.Excel.Workbook WorkBook;
        //Объект листов Excel
        private Microsoft.Office.Interop.Excel.Sheets ExcelSheets;
        //Объект рабочео листа
        private Microsoft.Office.Interop.Excel.Worksheet WorkSheet;
        //Диапозон ячеек
        private Microsoft.Office.Interop.Excel.Range range;

        private MainForm _mainForm;
        // Конструктор формы WordExportForm, принимающий MainForm в качестве параметра
        public ExcelExportForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void OpenExcelDocument(string FileName)
        {
            //создать новый объект приложения Excel 
            ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            object template = null;
            //задать файл шаблона
            if (FileName == "Отчёт_клиентов.xlsx")
            {
                template = System.Windows.Forms.Application.StartupPath + @"Export\Excel\Clients\" + FileName;
            }
            else if (FileName == "Отчёт_маршрутов.xlsx")
            {
                template = System.Windows.Forms.Application.StartupPath + @"Export\Excel\Routes\" + FileName;
            }
            else if (FileName == "Отчёт_путёвок.xlsx")
            {
                template = System.Windows.Forms.Application.StartupPath + @"Export\Excel\Travels\" + FileName;
            }
            //Применить шаблон
            ExcelApp.Workbooks.Add(template);
            //получить первую рабочую книгу файла
            WorkBook = ExcelApp.Workbooks[1];
            //получить список листов рабочей книги
            ExcelSheets = WorkBook.Worksheets;
            //выбрать первый лист
            WorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelSheets.get_Item(1);
        }

        private void PutCell(string cell, string val)
        {
            //получить диапазон, соответствующий выбранной ячейке
            Microsoft.Office.Interop.Excel.Range range = WorkSheet.get_Range(cell, Type.Missing);
            //занести в ячейку значение
            range.Value2 = val;
        }

        private void PutCellBorder(string cell, string val) 
        {
            //вызвать функцию занесения в ячейку значения
            PutCell(cell, val);
            //нарисовать границу вокруг ячейки
            Microsoft.Office.Interop.Excel.Range range = WorkSheet.get_Range(cell, Type.Missing);
            range.BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing);
        }

        private void ClientsButton_Click(object sender, EventArgs e)
        {
            // Создаем новый экземпляр Excel
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            try
            {
                // Создаем новую книгу
                Microsoft.Office.Interop.Excel.Workbook workbook = excelApp.Workbooks.Add();

                // Получаем активный лист
                Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.ActiveSheet;
                //создать документ на основе шаблона
                OpenExcelDocument("Отчёт_клиентов.xlsx");

                //Код для заполнения данных в Excel
                //В объединенных ячейках A3:E3 полужирным, красным, размер 16
                worksheet.Range["A1:F1"].Merge();
                worksheet.Range["A1"].Value = "Туристическая фирма";
                worksheet.Range["A1"].Font.Bold = true;
                worksheet.Range["A1"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter; //По середине
                worksheet.Range["A1"].Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);
                worksheet.Range["A1"].Font.Size = 16;

                //В объединенных ячейках A3:E3 полужирным, размер 14
                worksheet.Range["A3:E3"].Merge();
                worksheet.Range["A3"].Value = "Клиенты";
                worksheet.Range["A3"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter; //По середине
                worksheet.Range["A3"].Font.Bold = true;
                worksheet.Range["A3"].Font.Size = 14;

                //В ячейку J1 пишем "Дата:", а в K1 текущую дату
                worksheet.Range["J1"].Value = "Дата:"; // J1
                worksheet.Range["J1"].Font.Bold = true;
                worksheet.Range["J1"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter; //По середине
                worksheet.Range["K1"].Value = DateTime.Now.ToShortDateString(); // K1

                //В диапазон A5:G5 рисуем сетку и окрашиваем ячейки в "голубой, акцент1, более светлый оттенок 40%"
                worksheet.Range["A5:F10"].Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                worksheet.Range["A5:F5"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter; //По середине
                worksheet.Range["A5:F5"].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.FromArgb(191, 239, 255)); // Голубой, акцент1, более светлый оттенок 40%

                // Форматируем данные в Excel
                worksheet.Range["A5:E5"].Font.Bold = true;
                worksheet.Columns.AutoFit();

                // Устанавливаем заголовки столбцов
                worksheet.Cells[5, 1] = "№ п/п";
                worksheet.Cells[5, 2] = "Фамилия";
                worksheet.Cells[5, 3] = "Имя";
                worksheet.Cells[5, 4] = "Отчество";
                worksheet.Cells[5, 5] = "Адрес";
                worksheet.Cells[5, 6] = "Коннтактный телефон";

                int row = 6;
                foreach (DataGridViewRow dgvRow in _mainForm.GetClientsDataGridView().Rows)
                {
                    worksheet.Cells[row, 1] = dgvRow.Cells["ClientId"].Value;
                    worksheet.Cells[row, 2] = dgvRow.Cells["Surname"].Value;
                    worksheet.Cells[row, 3] = dgvRow.Cells["Firstname"].Value;
                    worksheet.Cells[row, 4] = dgvRow.Cells["Patronymic"].Value;
                    worksheet.Cells[row, 5] = dgvRow.Cells["Address"].Value;
                    worksheet.Cells[row, 6] = dgvRow.Cells["Telephone"].Value;

                    //По мере заполнения таблицы, рисуем сетку
                    worksheet.Range[$"A{row}:E{row}"].Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;

                    row++;
                }

                // Форматируем данные в Excel
                worksheet.Range["A5:E5"].Font.Bold = true;
                worksheet.Columns.AutoFit();

                // Сохраняем Excel-файл
                string fileName = System.Windows.Forms.Application.StartupPath + @"Export\Excel\Clients\" + $"Отчет_клиентов_{DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss")}.xlsx";
                workbook.SaveAs(fileName);

                // Открываем созданный Excel-файл
                excelApp.Visible = true;
                excelApp.Quit();

                MessageBox.Show($"Отчет сохранен как '{fileName}'");

            }
            catch (Exception ex)
            {
                excelApp.Quit();
                MessageBox.Show($"Ошибка при экспорте в Excel: {ex.Message}");
            }
        }

        private void RoutesButton_Click(object sender, EventArgs e)
        {
            // Создаем новый экземпляр Excel
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            try
            {
                // Создаем новую книгу
                Microsoft.Office.Interop.Excel.Workbook workbook = excelApp.Workbooks.Add();

                // Получаем активный лист
                Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.ActiveSheet;
                //создать документ на основе шаблона
                OpenExcelDocument("Отчёт_маршрутов.xlsx");

                //Код для заполнения данных в Excel
                //В объединенных ячейках A3:E3 полужирным, красным, размер 16
                worksheet.Range["A1:F1"].Merge();
                worksheet.Range["A1"].Value = "Туристическая фирма";
                worksheet.Range["A1"].Font.Bold = true;
                worksheet.Range["A1"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter; //По середине
                worksheet.Range["A1"].Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);
                worksheet.Range["A1"].Font.Size = 16;

                //В объединенных ячейках A3:E3 полужирным, размер 14
                worksheet.Range["A3:E3"].Merge();
                worksheet.Range["A3"].Value = "Маршруты";
                worksheet.Range["A3"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter; //По середине
                worksheet.Range["A3"].Font.Bold = true;
                worksheet.Range["A3"].Font.Size = 14;

                //В ячейку J1 пишем "Дата:", а в K1 текущую дату
                worksheet.Range["J1"].Value = "Дата:"; // J1
                worksheet.Range["J1"].Font.Bold = true;
                worksheet.Range["J1"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter; //По середине
                worksheet.Range["K1"].Value = DateTime.Now.ToShortDateString(); // K1

                //В диапазон A5:F5 рисуем сетку и окрашиваем ячейки в "голубой, акцент1, более светлый оттенок 40%"
                worksheet.Range["A5:F10"].Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                worksheet.Range["A5:F5"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter; //По середине
                worksheet.Range["A5:F5"].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.FromArgb(191, 239, 255)); // Голубой, акцент1, более светлый оттенок 40%

                // Форматируем данные в Excel
                worksheet.Range["A5:E5"].Font.Bold = true;
                worksheet.Columns.AutoFit();

                // Устанавливаем заголовки столбцов
                worksheet.Cells[5, 1] = "№ п/п";
                worksheet.Cells[5, 2] = "Страна";
                worksheet.Cells[5, 3] = "Климат";
                worksheet.Cells[5, 4] = "Отель";
                worksheet.Cells[5, 5] = "Продолжительность";
                worksheet.Cells[5, 6] = "Стоимость";

                int row = 6;
                foreach (DataGridViewRow dgvRow in _mainForm.GetRoutesDataGridView().Rows)
                {
                    worksheet.Cells[row, 1] = dgvRow.Cells["RouteId"].Value;
                    worksheet.Cells[row, 2] = dgvRow.Cells["Country"].Value;
                    worksheet.Cells[row, 3] = dgvRow.Cells["Climate"].Value;
                    worksheet.Cells[row, 4] = dgvRow.Cells["Hotel"].Value;
                    worksheet.Cells[row, 5] = dgvRow.Cells["Duration"].Value;
                    worksheet.Cells[row, 6] = dgvRow.Cells["Coast"].Value;

                    //По мере заполнения таблицы, рисуем сетку
                    worksheet.Range[$"A{row}:E{row}"].Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;

                    row++;
                }

                // Форматируем данные в Excel
                worksheet.Range["A5:E5"].Font.Bold = true;
                worksheet.Columns.AutoFit();

                // Сохраняем Excel-файл
                string fileName = System.Windows.Forms.Application.StartupPath + @"Export\Excel\Routes\" + $"Отчет_маршрутов_{DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss")}.xlsx";
                workbook.SaveAs(fileName);

                // Открываем созданный Excel-файл
                excelApp.Visible = true;
                excelApp.Quit();

                MessageBox.Show($"Отчет сохранен как '{fileName}'");

            }
            catch (Exception ex)
            {
                excelApp.Quit();
                MessageBox.Show($"Ошибка при экспорте в Excel: {ex.Message}");
            }
        }

        private void TravelPackagesButtton_Click(object sender, EventArgs e)
        {
            // Создаем новый экземпляр Excel
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            try
            {
                // Создаем новую книгу
                Microsoft.Office.Interop.Excel.Workbook workbook = excelApp.Workbooks.Add();

                // Получаем активный лист
                Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.ActiveSheet;
                //создать документ на основе шаблона
                OpenExcelDocument("Отчёт_путёвок.xlsx");

                //Код для заполнения данных в Excel
                //В объединенных ячейках A3:E3 полужирным, красным, размер 16
                worksheet.Range["A1:F1"].Merge();
                worksheet.Range["A1"].Value = "Туристическая фирма";
                worksheet.Range["A1"].Font.Bold = true;
                worksheet.Range["A1"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter; //По середине
                worksheet.Range["A1"].Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);
                worksheet.Range["A1"].Font.Size = 16;

                //В объединенных ячейках A3:E3 полужирным, размер 14
                worksheet.Range["A3:E3"].Merge();
                worksheet.Range["A3"].Value = "Путёвки";
                worksheet.Range["A3"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter; //По середине
                worksheet.Range["A3"].Font.Bold = true;
                worksheet.Range["A3"].Font.Size = 14;

                //В ячейку J1 пишем "Дата:", а в K1 текущую дату
                worksheet.Range["J1"].Value = "Дата:"; // J1
                worksheet.Range["J1"].Font.Bold = true;
                worksheet.Range["J1"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter; //По середине
                worksheet.Range["K1"].Value = DateTime.Now.ToShortDateString(); // K1

                //В диапазон A5:F5 рисуем сетку и окрашиваем ячейки в "голубой, акцент1, более светлый оттенок 40%"
                worksheet.Range["A5:F10"].Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                worksheet.Range["A5:F5"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter; //По середине
                worksheet.Range["A5:F5"].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.FromArgb(191, 239, 255)); // Голубой, акцент1, более светлый оттенок 40%

                // Форматируем данные в Excel
                worksheet.Range["A5:E5"].Font.Bold = true;
                worksheet.Columns.AutoFit();

                // Устанавливаем заголовки столбцов
                worksheet.Cells[5, 1] = "№ п/п";
                worksheet.Cells[5, 2] = "Дата отбытия";
                worksheet.Cells[5, 3] = "Количество";
                worksheet.Cells[5, 4] = "Скидка";
                worksheet.Cells[5, 5] = "ФИО Клиента";
                worksheet.Cells[5, 6] = "Полный маршрут";

                int row = 6;
                foreach (DataGridViewRow dgvRow in _mainForm.GetTravelPackagesDataGridView().Rows)
                {
                    worksheet.Cells[row, 1] = dgvRow.Cells["TravelId"].Value;
                    worksheet.Cells[row, 2] = dgvRow.Cells["DateOf"].Value;
                    worksheet.Cells[row, 3] = dgvRow.Cells["Count"].Value;
                    worksheet.Cells[row, 4] = dgvRow.Cells["Discount"].Value;
                    worksheet.Cells[row, 5] = dgvRow.Cells["FullRoute"].Value;
                    worksheet.Cells[row, 6] = dgvRow.Cells["FullName"].Value;

                    //По мере заполнения таблицы, рисуем сетку
                    worksheet.Range[$"A{row}:E{row}"].Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;

                    row++;
                }

                // Форматируем данные в Excel
                worksheet.Range["A5:E5"].Font.Bold = true;
                worksheet.Columns.AutoFit();

                // Сохраняем Excel-файл
                string fileName = System.Windows.Forms.Application.StartupPath + @"Export\Excel\Travels\" + $"Отчет_путёвок_{DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss")}.xlsx";
                workbook.SaveAs(fileName);

                // Открываем созданный Excel-файл
                excelApp.Visible = true;
                excelApp.Quit();

                MessageBox.Show($"Отчет сохранен как '{fileName}'");

            }
            catch (Exception ex)
            {
                excelApp.Quit();
                MessageBox.Show($"Ошибка при экспорте в Excel: {ex.Message}");
            }
        }
    }
}
