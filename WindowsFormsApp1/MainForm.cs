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
using System.Text.Json;

namespace lab7rkis
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public static List<int> JuriList;


        private void activityDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            activityBindingSource.DataSource = DBConst.model.Activity.ToList();
        }

        private void buttonShowJuri_Click(object sender, EventArgs e)
        {
            JuriList = new List<int>();
            JuriList = JsonSerializer.Deserialize<List<int>>(activityDataGridView.CurrentRow.Cells[5].Value.ToString());
            FormShowJuri formShowJuri = new FormShowJuri();
            formShowJuri.ShowDialog();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Form1 activity = new Form1();
            activity.Show();
            activityBindingSource.DataSource = DBConst.model.Activity.ToList();
        }
    }
}
