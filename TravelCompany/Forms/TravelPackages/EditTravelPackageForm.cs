using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using TravelCompany.Data;
using TravelCompany.Models;

namespace TravelCompany.Forms.TravelPackages
{
    public partial class EditTravelPackageForm : Form
    {
        private readonly TravelContext _context;
        private readonly Models.TravelPackage selectedTravelPackage;

        public EditTravelPackageForm(Models.TravelPackage selectedTravelPackage)
        {
            InitializeComponent();
            _context = new TravelContext();
            this.selectedTravelPackage = selectedTravelPackage;

            int count = int.Parse(TravelPackagesCountEditTextBox.Text);
            int discount = int.Parse(TravelPackagesDiscountEditTextBox.Text);

            TravelPackagesRouteEditComboBox.Items.AddRange(_context.Routes.ToArray());
            TravelPackagesClientEditComboBox.Items.AddRange(_context.Clients.ToArray());

            TravelIdEditTextBox.Text = Convert.ToString(selectedTravelPackage.TravelId);
            TravelPackagesRouteEditComboBox.SelectedItem = _context.Routes.First(x => x.RouteId == selectedTravelPackage.RouteId);
            TravelPackagesClientEditComboBox.SelectedItem = _context.Clients.First(x => x.ClientId == selectedTravelPackage.ClientId);
            TravelPackagesDateOfEditDateTimePicker.Value = selectedTravelPackage.DateOf;
            count = selectedTravelPackage.Count;
            discount = selectedTravelPackage.Discount;
        }

        private void TravelPackagesEditSaveButton_Click(object sender, EventArgs e)
        {
            var selectedRoute = (Models.Route)TravelPackagesRouteEditComboBox.SelectedItem;
            var selectedClient = (Models.Client)TravelPackagesClientEditComboBox.SelectedItem;

            var newTravelPackage = new Models.TravelPackage
            {
                TravelId = Convert.ToInt32(TravelIdEditTextBox.Text),
                Route = selectedRoute,
                Client = selectedClient,
                DateOf = TravelPackagesDateOfEditDateTimePicker.Value,
                Count = Convert.ToInt32(TravelPackagesCountEditTextBox.Text),
                Discount = Convert.ToInt32(TravelPackagesDiscountEditTextBox.Text)
            };

            _context.Travels.Update(newTravelPackage);
            _context.SaveChanges();

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
