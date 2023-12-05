using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using lab7rkis.DBCon;
using System.ComponentModel.Design;

namespace lab7rkis
{
    public partial class FormAddActivity : Form
    {
        public FormAddActivity()
        {
            InitializeComponent();
        }

        private List<int> Id_Juri = new List<int>();

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAddJuri_Click(object sender, EventArgs e)
        {
            int id = (int)groupsJuryComboBox.SelectedValue;
            if (!Id_Juri.Contains(id))
            {
                Id_Juri.Add(id);
                MessageBox.Show($"Пользователь с ID - {groupsJuryComboBox.SelectedValue} добавлен");
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(titleTextBox.Text))
            {
                MessageBox.Show("Заполните поле Название!");
                return;
            }
            try
            {
                Convert.ToInt32(dayTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Добавте хотябы одного члена жюри!");
                return;
            }
            Activity activity = new Activity();
            activity.Title = titleTextBox.Text;
            activity.EventPlanID = (int)eventPlanIDComboBox.SelectedValue;
            activity.Day = Convert.ToInt32(dayTextBox.Text);
            activity.StartedAt = startedAtDateTimePicker.Value.TimeOfDay;
            activity.ModeratorID = (int)moderatorIDComboBox.SelectedValue;
            activity.GroupsJury = JsonSerializer.Serialize(groupsJuryComboBox);
            DBConst.model.Activity.Add(activity);
            try
            {
                DBConst.model.SaveChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            Close();
        }

        private void FormAddActivity_Load(object sender, EventArgs e)
        {
            eventBindingSource.DataSource = DBConst.model.Event.ToList();
            UserBindingSource.DataSource = DBConst.model.User.Where(x => x.RoleID == 1).ToList();
            UserBindingSource2.DataSource = DBConst.model.User.Where(x => x.RoleID == 2).ToList();
        }
    }
}
