using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TravelCompany.Data;
using TravelCompany.Forms.Clients;
using TravelCompany.Forms.Routes;
using TravelCompany.Forms.TravelPackages;
using TravelCompany.Forms.ExportForms;
using TravelCompany.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
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
using TravelCompany.Forms;

namespace TravelCompany
{
    public partial class MainForm : Form
    {
        private readonly TravelContext _context;
        private bool _sortAscending = true;
        //������ ����������
        private Microsoft.Office.Interop.Excel.Application ExcelApp;
        //������ ���� Excel
        private Microsoft.Office.Interop.Excel.Window ExcelWindow;
        //������ ������� �����
        private Microsoft.Office.Interop.Excel.Workbook Workbook;
        //����� ������ Excel
        private Microsoft.Office.Interop.Excel.Sheets ExcelSheets;
        //������ �������� �����
        private Microsoft.Office.Interop.Excel.Worksheet Worksheet;
        //�������� �����
        private Microsoft.Office.Interop.Excel.Range range;

        //private MainForm _mainForm;

        //����������� ����� WordExportForm, ����������� MainForm � �������� ���������

        /*public MainForm()
        {
            InitializeComponent();
        }*/

        public MainForm()
        {
            InitializeComponent();
            _context = new TravelContext();
            UpdateLoadDataGridView();
        }

        private void UpdateLoadDataGridView()
        {
            //������������� �������� ������ ��� clientsDataGridView �� ������� Clients
            //���������� Select() ��� ������ � �������� ������ ����� � ��������� ���
            clientsDataGridView.DataSource = _context.Clients.AsNoTracking()
                .Select(c => new
                {

                    ClientId = c.ClientId, //�������� ID �������
                    Surname = c.Surname, //�������� ������� �������
                    Firstname = c.Firstname, //�������� ��� �������
                    Patronymic = c.Patronymic, //�������� �������� �������
                    Address = c.Address, //�������� ����� �������
                    Telephone = c.Telephone, //�������� ������� �������
                }).ToList();

            //������������� �������� ������ ��� routesDataGridView �� ������� Routes
            //���������� Select() ��� ������ � �������� ������ ����� � ��������� ���
            routesDataGridView.DataSource = _context.Routes.AsNoTracking()
                .Select(r => new
                {
                    RouteId = r.RouteId, //�������� ID ��������
                    Country = r.Country, //�������� ������ ��������
                    Climate = r.Climate, //�������� ������ ��������
                    Duration = r.Duration, //�������� ������������ ��������
                    Hotel = r.Hotel, //�������� ����� ��������
                    Coast = r.Coast //�������� ��������� ��������

                }).ToList();

            //������������� �������� ������ ��� travelPackageDataGridView �� ������� TravelPackage
            travelPackagesDataGridView.DataSource = _context.Travels.AsNoTracking()
                .Select(t => new
                {
                    TravelId = t.TravelId, //�������� ID ������
                    FullRoute = t.Route.FullRoute, //�������� ������ ������������ ��������
                    FullName = t.Client.FullName, //�������� ������ ��� �������
                    DateOf = t.DateOf, //�������� ����
                    Count = t.Count, //�������� ����������
                    Discount = t.Discount //�������� ������

                }).ToList();

            //����������� ������� "FullName" � travelPackageDataGridView
            travelPackagesDataGridView.Columns["FullName"].DataPropertyName = "FullName";
            travelPackagesDataGridView.Columns["FullName"].ValueType = typeof(string);

            if (travelPackagesDataGridView.Columns.Contains("FullName"))
            {
                travelPackagesDataGridView.Columns.Remove("FullName");
            }

            //����������� ������� "FullRoute" � travelPackageDataGridView
            travelPackagesDataGridView.Columns["FullRoute"].DataPropertyName = "FullRoute";
            travelPackagesDataGridView.Columns["FullRoute"].ValueType = typeof(string);

            if (travelPackagesDataGridView.Columns.Contains("FullRoute"))
            {
                travelPackagesDataGridView.Columns.Remove("FullRoute");
            }

            //��������� ����������� ������ � DataGridView
            clientsDataGridView.Refresh();
            routesDataGridView.Refresh();
            travelPackagesDataGridView.Refresh();

            //��������� ���������� ������� ����������
            clientsDataGridView.ColumnHeaderMouseClick += ClientsDataGridView_ColumnHeaderMouseClick;
            routesDataGridView.ColumnHeaderMouseClick += RoutesDataGridView_ColumnHeaderMouseClick;
            travelPackagesDataGridView.ColumnHeaderMouseClick += TravelPackageDataGridView_ColumnHeaderMouseClick;

        }

        private IList SortList(IList list, string columnName, bool ascending)
        {
            var type = list[0].GetType();
            var property = type.GetProperty(columnName);
            if (property != null)
            {
                if (ascending)
                {
                    return list.Cast<object>().OrderBy(x => property.GetValue(x, null)).ToList();
                }
                else
                {
                    return list.Cast<object>().OrderByDescending(x => property.GetValue(x, null)).ToList();
                }
            }
            return list;
        }

        private void SortDataGridView(DataGridView dataGridView, string columnName, bool ascending)
        {
            var dataSource = (IList)dataGridView.DataSource;
            if (dataSource != null)
            {
                var sortedDataSource = SortList(dataSource, columnName, ascending);
                dataGridView.DataSource = sortedDataSource;
                dataGridView.Refresh();
            }
        }

        private void ClientsDataGridView_ColumnHeaderMouseClick(object? sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                DataGridViewColumn column = clientsDataGridView.Columns[e.ColumnIndex];
                SortDataGridView(clientsDataGridView, column.Name, _sortAscending);
                _sortAscending = !_sortAscending;
            }
        }

        private void RoutesDataGridView_ColumnHeaderMouseClick(object? sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                DataGridViewColumn column = routesDataGridView.Columns[e.ColumnIndex];
                SortDataGridView(routesDataGridView, column.Name, _sortAscending);
                _sortAscending = !_sortAscending;
            }
        }

        private void TravelPackageDataGridView_ColumnHeaderMouseClick(object? sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                DataGridViewColumn column = travelPackagesDataGridView.Columns[e.ColumnIndex];
                SortDataGridView(travelPackagesDataGridView, column.Name, _sortAscending);
                _sortAscending = !_sortAscending;
            }
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            using var form = new AddClientForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                //�������� ������ DataGidView
                UpdateLoadDataGridView();
            }
        }

        private void buttonEditClient_Click(Object sender, EventArgs e)
        {
            if (clientsDataGridView.SelectedRows.Count < 1)
            {
                MessageBox.Show("�������� �������");
                return;
            }

            var selectedItemObject = clientsDataGridView.SelectedRows[0].DataBoundItem;
            var selectedItemId = (int?)selectedItemObject.GetType().GetProperty("ClientId")?.GetValue(selectedItemObject);

            var item = _context.Clients.First(x => x.ClientId == selectedItemId);

            using var form = new EditClientForm(item);
            if (form.ShowDialog() == DialogResult.OK)
            {
                //�������� ������ � DataGridView
                UpdateLoadDataGridView();
            }
        }

        private void buttonDelClient_Click(object sender, EventArgs e)
        {
            if (clientsDataGridView.SelectedRows.Count < 1)
            {
                MessageBox.Show("�������� �������");
                return;
            }
            var selectedItemObject = clientsDataGridView.SelectedRows[0].DataBoundItem;
            var selectedItemId = (int?)selectedItemObject.GetType().GetProperty("ClientId")?.GetValue(selectedItemObject);

            var item = _context.Clients.AsNoTracking().First(x => x.ClientId == selectedItemId);

            _context.Clients.Remove(item);
            _context.SaveChanges();
            UpdateLoadDataGridView();
        }

        private void buttonAddRoute_Click(object sender, EventArgs e)
        {
            using var form = new AddRouteForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                //�������� ������ DataGridView
                UpdateLoadDataGridView();
            }
        }

        private void buttonEditRoute_Click(object sender, EventArgs e)
        {
            if (routesDataGridView.SelectedRows.Count < 1)
            {
                MessageBox.Show("�������� �������");
                return;
            }

            var selectedItemObject = routesDataGridView.SelectedRows[0].DataBoundItem;
            var selectedItemId = (int?)selectedItemObject.GetType().GetProperty("RouteId")?.GetValue(selectedItemObject);

            var item = _context.Routes.First(x => x.RouteId == selectedItemId);

            using var form = new EditRouteForm(item);
            if (form.ShowDialog() == DialogResult.OK)
            {
                //�������� ������ � DataGridView
                UpdateLoadDataGridView();
            }
        }

        private void buttonDelRoute_Click(object sender, EventArgs e)
        {
            if (routesDataGridView.SelectedRows.Count < 1)
            {
                MessageBox.Show("�������� �������");
                return;
            }
            var selectedItemObject = routesDataGridView.SelectedRows[0].DataBoundItem;
            var selectedItemId = (int?)selectedItemObject.GetType().GetProperty("RouteId")?.GetValue(selectedItemObject);

            var item = _context.Routes.AsNoTracking().First(x => x.RouteId == selectedItemId);

            _context.Routes.Remove(item);
            _context.SaveChanges();
            UpdateLoadDataGridView();
        }

        private void buttonAddTravelPackage_Click(object sender, EventArgs e)
        {
            using var form = new AddTravelPackageForm(_context);
            if (form.ShowDialog() == DialogResult.OK)
            {
                //�������� ������ DataGridView
                UpdateLoadDataGridView();
            }
        }

        private void buttonEditTravelPackage_Click(object sender, EventArgs e)
        {
            if (routesDataGridView.SelectedRows.Count < 1)
            {
                MessageBox.Show("�������� �������");
                return;
            }

            var selectedItemObject = travelPackagesDataGridView.SelectedRows[0].DataBoundItem;
            var selectedItemId = (int?)selectedItemObject.GetType().GetProperty("TravelId")?.GetValue(selectedItemObject);

            var item = _context.Travels.First(x => x.TravelId == selectedItemId);

            using var form = new EditTravelPackageForm(item);
            if (form.ShowDialog() == DialogResult.OK)
            {
                //�������� ������ � DataGridView
                UpdateLoadDataGridView();
            }
        }

        private void buttonDelTravelPackage_Click(object sender, EventArgs e)
        {
            if (travelPackagesDataGridView.SelectedRows.Count < 1)
            {
                MessageBox.Show("�������� �������");
                return;
            }
            var selectedItemObject = travelPackagesDataGridView.SelectedRows[0].DataBoundItem;
            var selectedItemId = (int?)selectedItemObject.GetType().GetProperty("TravelId")?.GetValue(selectedItemObject);

            var item = _context.Travels.AsNoTracking().First(x => x.TravelId == selectedItemId);

            _context.Travels.Remove(item);
            _context.SaveChanges();
            UpdateLoadDataGridView();
        }

        public DataGridView GetClientsDataGridView()
        {
            return clientsDataGridView;
        }

        public DataGridView GetRoutesDataGridView()
        {
            return routesDataGridView;
        }

        public DataGridView GetTravelPackagesDataGridView()
        {
            return travelPackagesDataGridView;
        }

        private void buttonWord_Click(object sender, EventArgs e)
        {
            WordExportForm wordExportForm = new WordExportForm(this);
            wordExportForm.ShowDialog();
        }

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            ExcelExportForm excelExportForm = new ExcelExportForm(this);
            excelExportForm.ShowDialog();
        }

        private void buttonHTML_Click(object sender, EventArgs e)
        {
            HtmlExportForm htmlExportForm = new HtmlExportForm(this);
            htmlExportForm.ShowDialog();
        }
    }
}