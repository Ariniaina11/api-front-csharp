using api_front_csharp.Customers;
using api_front_csharp.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using api_front_csharp.Classes;

namespace api_front_csharp
{
    public partial class Home : Form
    {
        private HttpClient CLIENT;
        private List<User> USERS;
        private List<Customer> CUSTOMERS;

        public Home()
        {
            InitializeComponent();

            CLIENT = new HttpClient();
            USERS = new List<User>();
            CUSTOMERS = new List<Customer>();
        }

        // Close the app
        private void closeBtn_Click(object sender, EventArgs e)
        {
            DialogResult dR = MessageBox.Show("Did you want to exit ?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(dR == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Click on 'Users'
        private void userBtn_Click(object sender, EventArgs e)
        {
            // Before request
            beforeRequest(userBtn, customerBtn);

            // Add user header
            UserHeader uH = new UserHeader();
            uH.Dock = DockStyle.Fill;
            uH.BorderStyle = BorderStyle.FixedSingle;

            headerPnl.Controls.Add(uH);

            // Add user content
            getUserContent();
        }

        // Click on 'Customers'
        private void customerBtn_Click(object sender, EventArgs e)
        {
            // Before request
            beforeRequest(customerBtn, userBtn);

            // Add customer header
            CustomerHeader cH = new CustomerHeader();
            cH.Dock = DockStyle.Fill;
            cH.BorderStyle = BorderStyle.FixedSingle;

            headerPnl.Controls.Add(cH);

            // Add customer content
            getCustomerContent();
        }

        // ================================ FONCTIONS ================================ //

        // Get all users
        async void getUserContent()
        {
            contenPnl.Controls.Add(loadingLbl);
            loadingLbl.Text = "Getting users...";

            try
            {
                string url = "http://localhost:8000/api/users";
                HttpResponseMessage response = await CLIENT.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string content = await response.Content.ReadAsStringAsync();
                UserJsonObject data = JsonConvert.DeserializeObject<UserJsonObject>(content);

                // Clear again the content before adding data
                contenPnl.Controls.Clear();

                // Add user content
                foreach (User user in data.Users)
                {
                    UserContent uC = new UserContent();
                    uC.Dock = DockStyle.Top;
                    uC.BorderStyle = BorderStyle.FixedSingle;

                    // Props
                    uC.IdText = user.ID.ToString();
                    uC.UsernameText = user.Name;
                    uC.EmailText = user.Email;

                    contenPnl.Controls.Add(uC);

                    afterRequest(true);
                }
            }
            catch (HttpRequestException e)
            {
                MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                afterRequest(false);
            }
        }

        // Get all customers
        async void getCustomerContent()
        {
            contenPnl.Controls.Add(loadingLbl);
            loadingLbl.Text = "Getting customers...";

            try
            {
                string url = "http://localhost:8000/api/customers";
                HttpResponseMessage response = await CLIENT.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string content = await response.Content.ReadAsStringAsync();
                CustomerJsonObject data = JsonConvert.DeserializeObject<CustomerJsonObject>(content);

                // Clear again the content before adding data
                contenPnl.Controls.Clear();

                // Add user content
                foreach (Customer customer in data.Customers)
                {
                    CustomerContent cC = new CustomerContent();
                    cC.Dock = DockStyle.Top;
                    cC.BorderStyle = BorderStyle.FixedSingle;

                    // Props
                    cC.IdText = customer.ID.ToString();
                    cC.NameText = $"{customer.First_Name} {customer.Last_Name}";
                    cC.EmailText = customer.Email;
                    cC.ContactText = customer.Contact;

                    contenPnl.Controls.Add(cC);

                    afterRequest(true);
                }
            }
            catch (HttpRequestException e)
            {
                MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                afterRequest(false);
            }
        }

        // Before requests to API
        void beforeRequest(Button buttonClicked, Button otherButton)
        {
            // Button colors
            buttonClicked.BackColor = Color.Gray;
            otherButton.BackColor = Color.FromArgb(0, 64, 64);

            // Disable buttons
            buttonClicked.Enabled = false;
            otherButton.Enabled = false;

            // Remove all controls on panel
            contenPnl.Controls.Clear();
            headerPnl.Controls.Clear();
        }

        // After requests to API
        void afterRequest(bool result)
        {
            // Not having response from API
            if (!result)
            {
                loadingLbl.Text = "<No data>";
            }

            // Enable buttons
            customerBtn.Enabled = true;
            userBtn.Enabled = true;
        }
    }
}
