using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace api_front_csharp.Customers
{
    public partial class CustomerContent : UserControl
    {
        public CustomerContent()
        {
            InitializeComponent();
        }

        // ID
        public string IdText
        {
            set { idLbl.Text = value; }
        }

        // Name
        public string NameText
        {
            set { nameLbl.Text = value; }
        }

        // Email
        public string EmailText
        {
            set { emailLbl.Text = value; }
        }

        // Contact
        public string ContactText
        {
            set { contactLbl.Text = value; }
        }
    }
}
