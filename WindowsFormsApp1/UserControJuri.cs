using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab7rkis.DBCon;

namespace lab7rkis
{
    public partial class UserControJuri : UserControl
    {
        public UserControJuri()
        {
            InitializeComponent();
        }

        public void Fill(User user, int number)
        {
            labelName.Text = "Жюри - " + number.ToString(); 
            userBindingSource.DataSource = user;
        }

        private void UserControJuri_Load(object sender, EventArgs e)
        {

        }
    }
}
