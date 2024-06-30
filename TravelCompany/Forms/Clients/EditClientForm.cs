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


namespace TravelCompany.Forms
{
    public partial class EditClientForm : Form
    {
        private readonly TravelContext _context;
        private readonly Models.Client _selectedClient;

        public EditClientForm(Models.Client selectedClient)
        {
            InitializeComponent();

            _context = new TravelContext();
            _selectedClient = selectedClient;

            ClientIdEditTextBox.Text = Convert.ToString(_selectedClient.ClientId);
            ClientSurnameEditTextBox.Text = _selectedClient.Surname;
            ClientFirstnameEditTextBox.Text = _selectedClient.Firstname;
            ClientPatronymicEditTextBox.Text = _selectedClient.Patronymic;
            ClientAddressEditTextBox.Text = _selectedClient.Address;
            ClientTelephoneEditTextBox.Text = _selectedClient.Telephone;
        }

        private void ClientSaveAddButton_Click(object sender, EventArgs e)
        {
            var client = new Models.Client
            {
                ClientId = Convert.ToInt32(ClientIdEditTextBox.Text),
                Surname = ClientSurnameEditTextBox.Text,
                Firstname = ClientFirstnameEditTextBox.Text,
                Patronymic = ClientPatronymicEditTextBox.Text,
                Address = ClientAddressEditTextBox.Text,
                Telephone = ClientTelephoneEditTextBox.Text

            };
            _context.Clients.Update(client);
            _context.SaveChanges();

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
