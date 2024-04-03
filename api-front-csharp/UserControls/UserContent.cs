using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace api_front_csharp.Users
{
    public partial class UserContent : UserControl
    {
        public UserContent()
        {
            InitializeComponent();
        }

        // ID
        public string IdText
        {
            set { idLbl.Text = value; }
        }

        // Name
        public string UsernameText
        {
            set { usernameLbl.Text = value; }
        }

        // Email
        public string EmailText
        {
            set { emailLbl.Text = value; }
        }
    }
}
