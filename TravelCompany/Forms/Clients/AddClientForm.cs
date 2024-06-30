using TravelCompany.Data;
using TravelCompany.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelCompany.Forms.Clients
{
    public partial class AddClientForm : Form
    {
        private readonly TravelContext _context;
        public AddClientForm()
        {
            InitializeComponent();
            _context = new TravelContext();
        }
        private void ClientSaveAddButton_Click(object sender, EventArgs e)
        {
            var client = new Models.Client
            {
                ClientId = Convert.ToInt32(ClientIdAddTextBox.Text),
                Surname = ClientSurnameAddTextBox.Text,
                Firstname = ClientFirstnameAddTextBox.Text,
                Patronymic = ClientPatronymcAddTextBox.Text,
                Address = ClientAddressAddTextBox.Text,
                Telephone = ClientTelephoneAddTextBox.Text

            };
            _context.Clients.Add(client);
            _context.SaveChanges();

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
