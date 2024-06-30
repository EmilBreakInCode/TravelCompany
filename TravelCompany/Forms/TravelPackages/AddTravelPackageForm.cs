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

    public partial class AddTravelPackageForm : Form
    {
        private readonly TravelContext _context;

        public AddTravelPackageForm(TravelContext context)
        {
            InitializeComponent();
            _context = new TravelContext();

            TravelPackagesRouteAddComboBox.Items.AddRange(_context.Routes.ToArray());
            TravelPackagesClientAddComboBox.Items.AddRange(_context.Clients.ToArray());
        }

        private void TravelPackagesAddSaveButton_Click(object sender, EventArgs e)
        {
            var selectedRoute = (Models.Route)TravelPackagesRouteAddComboBox.SelectedItem;
            var selectedClient = (Models.Client)TravelPackagesClientAddComboBox.SelectedItem;
            

            var newTravelPackage = new Models.TravelPackage
            {
                TravelId = Convert.ToInt32(TravelIdAddTextBox.Text),
                Route = selectedRoute,
                Client = selectedClient,
                DateOf = TravelPackagesDateOfAddDateTimePicker.Value,
                Count = Convert.ToInt32(TravelPackagesCountAddTextBox.Text),
                Discount = Convert.ToInt32(TravelPackagesDiscountAddTextBox),
            };

            _context.Travels.Add(newTravelPackage);
            _context.SaveChanges();

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
