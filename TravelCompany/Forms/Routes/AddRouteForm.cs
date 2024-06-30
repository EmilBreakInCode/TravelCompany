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
using DocumentFormat.OpenXml.Bibliography;

namespace TravelCompany.Forms.Routes
{
    public partial class AddRouteForm : Form
    {
        private readonly TravelContext _context;
        public AddRouteForm()
        {
            InitializeComponent();
            _context = new TravelContext();
        }

        private void RouteSaveRoutesSaveAddButton_Click(object sender, EventArgs e)
        {
            var duration = Convert.ToInt32(RoutesDurationAddTextBox.Text);
            var coast = Convert.ToInt32(RoutesCoastAddTextBox.Text);
            var newRoute = new Models.Route()
            {
                RouteId = Convert.ToInt32(RouteIdAddTextBox.Text),
                Country = RoutesCountryAddTextBox.Text,
                Climate = RoutesClimateAddTextBox.Text,
                Hotel = RoutesHotelAddTextBox.Text,
                Duration = duration,
                Coast = coast
            };
            
            _context.Routes.Add(newRoute);
            _context.SaveChanges();

            DialogResult = DialogResult.OK;
            Close();

        }
    }
}
