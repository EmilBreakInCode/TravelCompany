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
using TravelCompany.Models;
using Microsoft.EntityFrameworkCore;

namespace TravelCompany.Forms.Routes
{
    public partial class EditRouteForm : Form
    {   
        private readonly TravelContext _context;
        private readonly Models.Route _selectedRoute;
        public EditRouteForm(Models.Route selectedRoute)
        {
            InitializeComponent();
            _context = new TravelContext();
            _selectedRoute = selectedRoute;

            string duration = _selectedRoute.Duration.ToString();
            string coast = _selectedRoute.Coast.ToString();

            RouteIdEditTextBox.Text = Convert.ToString(selectedRoute.RouteId);
            RoutesCountryEditTextBox.Text = selectedRoute.Country;
            RoutesClimateEditTextBox.Text = selectedRoute.Climate;
            RoutesHotelEditTextBox.Text = selectedRoute.Hotel;
            RoutesDurationEditTextBox.Text = duration;
            RoutesCoastEditTextBox.Text = coast;
        }

        private void RouteSaveRoutesSaveEditButton_Click(object sender, EventArgs e)
        {
            var newRoute = new Models.Route()
            {
                RouteId = Convert.ToInt32(RouteIdEditTextBox.Text),
                Country = RoutesCountryEditTextBox.Text,
                Climate = RoutesClimateEditTextBox.Text,
                Hotel = RoutesHotelEditTextBox.Text,
                Duration = Convert.ToInt32(RoutesDurationEditTextBox.Text),
                Coast = Convert.ToInt32(RoutesCoastEditTextBox.Text)
            };

            _context.Routes.Update(newRoute);
            _context.SaveChanges();

            DialogResult = DialogResult.OK;
            Close();

        }
    }
}
