using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab7rkis.DBCon;

namespace lab7rkis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<int> Id_Juri = new List<int>();

        private void Form1_Load(object sender, EventArgs e)
        {
            eventBindingSource.DataSource = DBConst.model.Event.ToList();
            userBindingSource.DataSource = DBConst.model.User.Where(x => x.RoleID == 1).ToList();
            userBindingSource1.DataSource = DBConst.model.User.Where(x => x.RoleID == 2).ToList();
        }

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

        private void buttonAddActivity_Click(object sender, EventArgs e)
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
                MessageBox.Show("В поле день запишите целочисленное значение!");
                return;
            }
            Activity activity = new Activity();
            activity.Title = titleTextBox.Text;
            activity.EventPlanID = (int)eventPlanIDComboBox.SelectedValue;
            activity.Day = Convert.ToInt32(dayTextBox.Text);
            activity.StartedAt = startedAtDateTimePicker.Value.TimeOfDay;
            activity.ModeratorID = (int)moderatorIDComboBox.SelectedValue;
            activity.GroupsJury = JsonSerializer.Serialize(Id_Juri);
            DBConst.model.Activity.Add(activity);
            try
            {
                DBConst.model.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            Close();
        }
    }
}
