using DocumentFormat.OpenXml.Drawing.Diagrams;
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
    public partial class WordExportForm : Form
    {
        // Конструктор формы WordExportForm, принимающий MainForm в качестве параметра
        private MainForm _mainForm;
        public WordExportForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        // Метод, заменяющий текст в документе Word на заданный текст замены
        private void ReplaceText(Microsoft.Office.Interop.Word.Document document, string placeholder, string replacement)
        {
            if(document != null)
            {
                Microsoft.Office.Interop.Word.Range rng = document.Content;
                rng.Find.Text = placeholder;
                rng.Find.Replacement.Text = replacement;
                rng.Find.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);
            }
            else
            {
                // Обработка ситуации, когда document равен null
                MessageBox.Show("Ошибка: document равен null");
            }
        }
        //Обработчик события нажатия на кнопку Клиенты
        private void ClientsButton_Click(object sender, EventArgs e)
        {
            //Создаётся новый экземпляр Word
            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
            // Открываем шаблонный документ Word
            string templatePath = System.Windows.Forms.Application.StartupPath + @"Export\Word\Clients\Отчет_клиентов.doc";
            // Создаем переменную для хранения документа Word
            Microsoft.Office.Interop.Word.Document? wordDoc = null;

            try
            {
                // Открываем шаблонный документ Word
                wordDoc = wordApp.Documents.Open(templatePath);

                // Проверяем, что документ был успешно открыт
                if (wordDoc != null)
                {
                    // Заменяем метку <Today> на текущую дату
                    ReplaceText(wordDoc, "<Today>", "Дата документа: " + DateTime.Now.ToShortDateString());

                    // Находим метку <Table> в документе
                    Microsoft.Office.Interop.Word.Range rng = wordDoc.Range();
                    rng.Find.Text = "<Table>";

                    if (rng.Find.Execute())
                    {
                        // Удаляем метку <Table>
                        rng.Text = "";

                        // Создаем новую таблицу
                        Object defaultTableBehavior = Microsoft.Office.Interop.Word.WdDefaultTableBehavior.wdWord9TableBehavior;
                        Object autoFitBehavior = Microsoft.Office.Interop.Word.WdAutoFitBehavior.wdAutoFitContent;
                        Microsoft.Office.Interop.Word.Table tbl = rng.Tables.Add(rng, _mainForm.GetClientsDataGridView().Rows.Count + 1, 7, ref defaultTableBehavior, ref autoFitBehavior);

                        // Форматируем таблицу
                        tbl.Range.Font.Size = 14;
                        tbl.set_Style("Сетка таблицы");

                        // Заполняем таблицу данными из DataGridView
                        tbl.Cell(1, 1).Range.Text = "№ п/п";
                        tbl.Cell(1, 2).Range.Text = "Фамилия";
                        tbl.Cell(1, 3).Range.Text = "Имя";
                        tbl.Cell(1, 4).Range.Text = "Отчество";
                        tbl.Cell(1, 5).Range.Text = "Адрес";
                        tbl.Cell(1, 6).Range.Text = "Телефон";
                        tbl.Rows[1].Range.Font.Italic = 1;
                        tbl.Rows[1].Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;

                        // Заполняем таблицу данными из DataGridView
                        for (int i = 0; i < _mainForm.GetClientsDataGridView().Rows.Count; i++)
                        {
                            tbl.Cell(i + 2, 1).Range.Text = (i + 1).ToString();
                            tbl.Cell(i + 2, 2).Range.Text = _mainForm.GetClientsDataGridView().Rows[i].Cells["Surname"].Value.ToString();
                            tbl.Cell(i + 2, 3).Range.Text = _mainForm.GetClientsDataGridView().Rows[i].Cells["Firstname"].Value.ToString();
                            tbl.Cell(i + 2, 4).Range.Text = _mainForm.GetClientsDataGridView().Rows[i].Cells["Patronymic"].Value.ToString();
                            tbl.Cell(i + 2, 5).Range.Text = _mainForm.GetClientsDataGridView().Rows[i].Cells["Address"].Value.ToString();
                            tbl.Cell(i + 2, 6).Range.Text = _mainForm.GetClientsDataGridView().Rows[i].Cells["Telephone"].Value.ToString();                          
                        }
                    }
                    else
                    {
                        // Если метка<Table> не найдена, заменяем ее на пустую строку
                        ReplaceText(wordDoc, "Table", "");
                    }

                    // Сохраняем Word-файл с сформированным отчетом
                    string fileName = System.Windows.Forms.Application.StartupPath + @"Export\Word\Clients\" + $"Отчет_клиентов_{DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss")}.doc";
                    wordDoc.SaveAs(FileName: fileName);

                    // Отображаем сформированный документ Word
                    wordDoc.Activate();
                    wordApp.Visible = true;
                    wordApp.Activate();

                    // Закрываем документ Word и приложение Word
                    wordDoc.Close();
                    wordApp.Quit();

                    // Освобождаем объекты Word
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(wordDoc);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(wordApp);
                }
                else
                {
                    // Обработка ситуации, когда wordDoc равен null
                    MessageBox.Show("Ошибка: wordDoc равен null");
                }
            }
            catch (Exception ex)
            {
                // Закрываем документ Word и приложение Word
                wordDoc?.Close();
                wordApp.Quit();

                // Освобождаем объекты Word
                System.Runtime.InteropServices.Marshal.ReleaseComObject(wordDoc);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(wordApp);

                // Выводим сообщение об ошибке
                MessageBox.Show($"Ошибка при экспорте в Word: {ex.Message}");
            }
        }

        private void RoutesButton_Click(object sender, EventArgs e)
        {
            //Создаётся новый экземпляр Word
            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
            // Открываем шаблонный документ Word
            string templatePath = System.Windows.Forms.Application.StartupPath + @"Export\Word\Routes\Отчет_маршрутов.doc";
            // Создаем переменную для хранения документа Word
            Microsoft.Office.Interop.Word.Document? wordDoc = null;

            try
            {
                // Открываем шаблонный документ Word
                wordDoc = wordApp.Documents.Open(templatePath);

                // Проверяем, что документ был успешно открыт
                if (wordDoc != null)
                {
                    // Заменяем метку <Today> на текущую дату
                    ReplaceText(wordDoc, "<Today>", "Дата документа: "+DateTime.Now.ToShortDateString());

                    // Находим метку <Table> в документе
                    Microsoft.Office.Interop.Word.Range rng = wordDoc.Range();
                    rng.Find.Text = "<Table>";

                    if (rng.Find.Execute())
                    {
                        // Удаляем метку <Table>
                        rng.Text = "";

                        // Создаем новую таблицу
                        Object defaultTableBehavior = Microsoft.Office.Interop.Word.WdDefaultTableBehavior.wdWord9TableBehavior;
                        Object autoFitBehavior = Microsoft.Office.Interop.Word.WdAutoFitBehavior.wdAutoFitContent;
                        Microsoft.Office.Interop.Word.Table tbl = rng.Tables.Add(rng, _mainForm.GetRoutesDataGridView().Rows.Count + 1, 7, ref defaultTableBehavior, ref autoFitBehavior);

                        // Форматируем таблицу
                        tbl.Range.Font.Size = 14;
                        tbl.set_Style("Сетка таблицы");

                        // Заполняем таблицу данными из DataGridView
                        tbl.Cell(1, 1).Range.Text = "№ п/п";
                        tbl.Cell(1, 2).Range.Text = "Страна";
                        tbl.Cell(1, 3).Range.Text = "Климат";
                        tbl.Cell(1, 4).Range.Text = "Длительность";
                        tbl.Cell(1, 5).Range.Text = "Отель";
                        tbl.Cell(1, 6).Range.Text = "Стоимость";
                        tbl.Rows[1].Range.Font.Italic = 1;
                        tbl.Rows[1].Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;

                        // Заполняем таблицу данными из DataGridView
                        for (int i = 0; i < _mainForm.GetRoutesDataGridView().Rows.Count; i++)
                        {
                            tbl.Cell(i + 2, 1).Range.Text = (i + 1).ToString();
                            tbl.Cell(i + 2, 2).Range.Text = _mainForm.GetRoutesDataGridView().Rows[i].Cells["Country"].Value.ToString();
                            tbl.Cell(i + 2, 3).Range.Text = _mainForm.GetRoutesDataGridView().Rows[i].Cells["Climate"].Value.ToString();
                            tbl.Cell(i + 2, 4).Range.Text = _mainForm.GetRoutesDataGridView().Rows[i].Cells["Duration"].Value.ToString();
                            tbl.Cell(i + 2, 5).Range.Text = _mainForm.GetRoutesDataGridView().Rows[i].Cells["Hotel"].Value.ToString();
                            tbl.Cell(i + 2, 6).Range.Text = _mainForm.GetRoutesDataGridView().Rows[i].Cells["Coast"].Value.ToString();
                        }
                    }
                    else
                    {
                        // Если метка<Table> не найдена, заменяем ее на пустую строку
                        ReplaceText(wordDoc, "Table", "");
                    }

                    // Сохраняем Word-файл с сформированным отчетом
                    string fileName = System.Windows.Forms.Application.StartupPath + @"Export\Word\Routes\" + $"Отчет_маршрутов_{DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss")}.doc";
                    wordDoc.SaveAs(FileName: fileName);

                    // Отображаем сформированный документ Word
                    wordDoc.Activate();
                    wordApp.Visible = true;
                    wordApp.Activate();

                    // Закрываем документ Word и приложение Word
                    wordDoc.Close();
                    wordApp.Quit();

                    // Освобождаем объекты Word
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(wordDoc);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(wordApp);
                }
                else
                {
                    // Обработка ситуации, когда wordDoc равен null
                    MessageBox.Show("Ошибка: wordDoc равен null");
                }
            }
            catch (Exception ex)
            {
                // Закрываем документ Word и приложение Word
                wordDoc?.Close();
                wordApp.Quit();

                // Освобождаем объекты Word
                System.Runtime.InteropServices.Marshal.ReleaseComObject(wordDoc);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(wordApp);

                // Выводим сообщение об ошибке
                MessageBox.Show($"Ошибка при экспорте в Word: {ex.Message}");
            }
        }

        private void TravelPackagesButtton_Click(object sender, EventArgs e)
        {
            //Создаётся новый экземпляр Word
            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
            // Открываем шаблонный документ Word
            string templatePath = System.Windows.Forms.Application.StartupPath + @"Export\Word\Travels\Отчет_путёвок.doc";
            // Создаем переменную для хранения документа Word
            Microsoft.Office.Interop.Word.Document? wordDoc = null;

            try
            {
                // Открываем шаблонный документ Word
                wordDoc = wordApp.Documents.Open(templatePath);

                // Проверяем, что документ был успешно открыт
                if (wordDoc != null)
                {
                    // Заменяем метку <Today> на текущую дату
                    ReplaceText(wordDoc, "<Today>", "Дата документа: " + DateTime.Now.ToShortDateString());

                    // Находим метку <Table> в документе
                    Microsoft.Office.Interop.Word.Range rng = wordDoc.Range();
                    rng.Find.Text = "<Table>";

                    if (rng.Find.Execute())
                    {
                        // Удаляем метку <Table>
                        rng.Text = "";

                        // Создаем новую таблицу
                        Object defaultTableBehavior = Microsoft.Office.Interop.Word.WdDefaultTableBehavior.wdWord9TableBehavior;
                        Object autoFitBehavior = Microsoft.Office.Interop.Word.WdAutoFitBehavior.wdAutoFitContent;
                        Microsoft.Office.Interop.Word.Table tbl = rng.Tables.Add(rng, _mainForm.GetTravelPackagesDataGridView().Rows.Count + 1, 7, ref defaultTableBehavior, ref autoFitBehavior);

                        // Форматируем таблицу
                        tbl.Range.Font.Size = 14;
                        tbl.set_Style("Сетка таблицы");

                        // Заполняем таблицу данными из DataGridView
                        tbl.Cell(1, 1).Range.Text = "№ п/п";
                        tbl.Cell(1, 2).Range.Text = "Маршрут детально";
                        tbl.Cell(1, 3).Range.Text = "ФИО полостью";
                        tbl.Cell(1, 4).Range.Text = "Дата отправления";
                        tbl.Cell(1, 5).Range.Text = "Количество";
                        tbl.Cell(1, 6).Range.Text = "Скидка";
                        tbl.Rows[1].Range.Font.Italic = 1;
                        tbl.Rows[1].Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;

                        // Заполняем таблицу данными из DataGridView
                        for (int i = 0; i < _mainForm.GetTravelPackagesDataGridView().Rows.Count; i++)
                        {
                            tbl.Cell(i + 2, 1).Range.Text = (i + 1).ToString();
                            tbl.Cell(i + 2, 2).Range.Text = _mainForm.GetTravelPackagesDataGridView().Rows[i].Cells["FullRoute"].Value.ToString();
                            tbl.Cell(i + 2, 3).Range.Text = _mainForm.GetTravelPackagesDataGridView().Rows[i].Cells["FullName"].Value.ToString();
                            tbl.Cell(i + 2, 4).Range.Text = _mainForm.GetTravelPackagesDataGridView().Rows[i].Cells["DateOf"].Value.ToString();
                            tbl.Cell(i + 2, 5).Range.Text = _mainForm.GetTravelPackagesDataGridView().Rows[i].Cells["Count"].Value.ToString();
                            tbl.Cell(i + 2, 6).Range.Text = _mainForm.GetTravelPackagesDataGridView().Rows[i].Cells["Discount"].Value.ToString();
                        }
                    }
                    else
                    {
                        // Если метка<Table> не найдена, заменяем ее на пустую строку
                        ReplaceText(wordDoc, "Table", "");
                    }

                    // Сохраняем Word-файл с сформированным отчетом
                    string fileName = System.Windows.Forms.Application.StartupPath + @"Export\Word\Travels\" + $"Отчет_путёвок_{DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss")}.doc";
                    wordDoc.SaveAs(FileName: fileName);

                    // Отображаем сформированный документ Word
                    wordDoc.Activate();
                    wordApp.Visible = true;
                    wordApp.Activate();

                    // Закрываем документ Word и приложение Word
                    wordDoc.Close();
                    wordApp.Quit();

                    // Освобождаем объекты Word
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(wordDoc);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(wordApp);
                }
                else
                {
                    // Обработка ситуации, когда wordDoc равен null
                    MessageBox.Show("Ошибка: wordDoc равен null");
                }
            }
            catch (Exception ex)
            {
                // Закрываем документ Word и приложение Word
                wordDoc?.Close();
                wordApp.Quit();

                // Освобождаем объекты Word
                System.Runtime.InteropServices.Marshal.ReleaseComObject(wordDoc);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(wordApp);

                // Выводим сообщение об ошибке
                MessageBox.Show($"Ошибка при экспорте в Word: {ex.Message}");
            }
        }
    }
}
