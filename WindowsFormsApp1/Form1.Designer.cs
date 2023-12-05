namespace lab7rkis
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label dayLabel;
            System.Windows.Forms.Label eventPlanIDLabel;
            System.Windows.Forms.Label groupsJuryLabel;
            System.Windows.Forms.Label moderatorIDLabel;
            System.Windows.Forms.Label startedAtLabel;
            System.Windows.Forms.Label titleLabel;
            this.dayTextBox = new System.Windows.Forms.TextBox();
            this.eventPlanIDComboBox = new System.Windows.Forms.ComboBox();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupsJuryComboBox = new System.Windows.Forms.ComboBox();
            this.userBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.moderatorIDComboBox = new System.Windows.Forms.ComboBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.startedAtDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddActivity = new System.Windows.Forms.Button();
            this.buttonAddJuri = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            dayLabel = new System.Windows.Forms.Label();
            eventPlanIDLabel = new System.Windows.Forms.Label();
            groupsJuryLabel = new System.Windows.Forms.Label();
            moderatorIDLabel = new System.Windows.Forms.Label();
            startedAtLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dayLabel
            // 
            dayLabel.AutoSize = true;
            dayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dayLabel.Location = new System.Drawing.Point(228, 191);
            dayLabel.Name = "dayLabel";
            dayLabel.Size = new System.Drawing.Size(48, 20);
            dayLabel.TabIndex = 29;
            dayLabel.Text = "День";
            // 
            // eventPlanIDLabel
            // 
            eventPlanIDLabel.AutoSize = true;
            eventPlanIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            eventPlanIDLabel.Location = new System.Drawing.Point(228, 157);
            eventPlanIDLabel.Name = "eventPlanIDLabel";
            eventPlanIDLabel.Size = new System.Drawing.Size(117, 20);
            eventPlanIDLabel.TabIndex = 31;
            eventPlanIDLabel.Text = "План события";
            // 
            // groupsJuryLabel
            // 
            groupsJuryLabel.AutoSize = true;
            groupsJuryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            groupsJuryLabel.Location = new System.Drawing.Point(228, 329);
            groupsJuryLabel.Name = "groupsJuryLabel";
            groupsJuryLabel.Size = new System.Drawing.Size(52, 20);
            groupsJuryLabel.TabIndex = 33;
            groupsJuryLabel.Text = "Жюри";
            // 
            // moderatorIDLabel
            // 
            moderatorIDLabel.AutoSize = true;
            moderatorIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            moderatorIDLabel.Location = new System.Drawing.Point(228, 283);
            moderatorIDLabel.Name = "moderatorIDLabel";
            moderatorIDLabel.Size = new System.Drawing.Size(96, 20);
            moderatorIDLabel.TabIndex = 35;
            moderatorIDLabel.Text = "Модератор";
            // 
            // startedAtLabel
            // 
            startedAtLabel.AutoSize = true;
            startedAtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            startedAtLabel.Location = new System.Drawing.Point(228, 239);
            startedAtLabel.Name = "startedAtLabel";
            startedAtLabel.Size = new System.Drawing.Size(104, 20);
            startedAtLabel.TabIndex = 37;
            startedAtLabel.Text = "Начало мер.";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            titleLabel.Location = new System.Drawing.Point(228, 102);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(83, 20);
            titleLabel.TabIndex = 39;
            titleLabel.Text = "Название";
            // 
            // dayTextBox
            // 
            this.dayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dayTextBox.Location = new System.Drawing.Point(385, 188);
            this.dayTextBox.Name = "dayTextBox";
            this.dayTextBox.Size = new System.Drawing.Size(200, 26);
            this.dayTextBox.TabIndex = 30;
            // 
            // eventPlanIDComboBox
            // 
            this.eventPlanIDComboBox.DataSource = this.eventBindingSource;
            this.eventPlanIDComboBox.DisplayMember = "Title";
            this.eventPlanIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eventPlanIDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.eventPlanIDComboBox.FormattingEnabled = true;
            this.eventPlanIDComboBox.Location = new System.Drawing.Point(385, 142);
            this.eventPlanIDComboBox.Name = "eventPlanIDComboBox";
            this.eventPlanIDComboBox.Size = new System.Drawing.Size(200, 28);
            this.eventPlanIDComboBox.TabIndex = 32;
            this.eventPlanIDComboBox.ValueMember = "ID";
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(lab7rkis.DBCon.Event);
            // 
            // groupsJuryComboBox
            // 
            this.groupsJuryComboBox.DataSource = this.userBindingSource1;
            this.groupsJuryComboBox.DisplayMember = "Surname";
            this.groupsJuryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupsJuryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupsJuryComboBox.FormattingEnabled = true;
            this.groupsJuryComboBox.Location = new System.Drawing.Point(385, 329);
            this.groupsJuryComboBox.Name = "groupsJuryComboBox";
            this.groupsJuryComboBox.Size = new System.Drawing.Size(200, 28);
            this.groupsJuryComboBox.TabIndex = 34;
            this.groupsJuryComboBox.ValueMember = "ID";
            // 
            // userBindingSource1
            // 
            this.userBindingSource1.DataSource = typeof(lab7rkis.DBCon.User);
            // 
            // moderatorIDComboBox
            // 
            this.moderatorIDComboBox.DataSource = this.userBindingSource;
            this.moderatorIDComboBox.DisplayMember = "Surname";
            this.moderatorIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.moderatorIDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.moderatorIDComboBox.FormattingEnabled = true;
            this.moderatorIDComboBox.Location = new System.Drawing.Point(385, 280);
            this.moderatorIDComboBox.Name = "moderatorIDComboBox";
            this.moderatorIDComboBox.Size = new System.Drawing.Size(200, 28);
            this.moderatorIDComboBox.TabIndex = 36;
            this.moderatorIDComboBox.ValueMember = "ID";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(lab7rkis.DBCon.User);
            // 
            // startedAtDateTimePicker
            // 
            this.startedAtDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.startedAtDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startedAtDateTimePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.startedAtDateTimePicker.Location = new System.Drawing.Point(385, 235);
            this.startedAtDateTimePicker.Name = "startedAtDateTimePicker";
            this.startedAtDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.startedAtDateTimePicker.TabIndex = 38;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.titleTextBox.Location = new System.Drawing.Point(385, 99);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(200, 26);
            this.titleTextBox.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(252, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "Добавление новой активности";
            // 
            // buttonAddActivity
            // 
            this.buttonAddActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddActivity.Location = new System.Drawing.Point(256, 447);
            this.buttonAddActivity.Name = "buttonAddActivity";
            this.buttonAddActivity.Size = new System.Drawing.Size(300, 38);
            this.buttonAddActivity.TabIndex = 27;
            this.buttonAddActivity.Text = "Добавить новую активность";
            this.buttonAddActivity.UseVisualStyleBackColor = true;
            this.buttonAddActivity.Click += new System.EventHandler(this.buttonAddActivity_Click);
            // 
            // buttonAddJuri
            // 
            this.buttonAddJuri.Location = new System.Drawing.Point(660, 330);
            this.buttonAddJuri.Name = "buttonAddJuri";
            this.buttonAddJuri.Size = new System.Drawing.Size(104, 27);
            this.buttonAddJuri.TabIndex = 26;
            this.buttonAddJuri.Text = "добавить";
            this.buttonAddJuri.UseVisualStyleBackColor = true;
            this.buttonAddJuri.Click += new System.EventHandler(this.buttonAddJuri_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(99, 41);
            this.buttonBack.TabIndex = 25;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 505);
            this.Controls.Add(dayLabel);
            this.Controls.Add(this.dayTextBox);
            this.Controls.Add(eventPlanIDLabel);
            this.Controls.Add(this.eventPlanIDComboBox);
            this.Controls.Add(groupsJuryLabel);
            this.Controls.Add(this.groupsJuryComboBox);
            this.Controls.Add(moderatorIDLabel);
            this.Controls.Add(this.moderatorIDComboBox);
            this.Controls.Add(startedAtLabel);
            this.Controls.Add(this.startedAtDateTimePicker);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddActivity);
            this.Controls.Add(this.buttonAddJuri);
            this.Controls.Add(this.buttonBack);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dayTextBox;
        private System.Windows.Forms.ComboBox eventPlanIDComboBox;
        private System.Windows.Forms.ComboBox groupsJuryComboBox;
        private System.Windows.Forms.ComboBox moderatorIDComboBox;
        private System.Windows.Forms.DateTimePicker startedAtDateTimePicker;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddActivity;
        private System.Windows.Forms.Button buttonAddJuri;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.BindingSource userBindingSource1;
        private System.Windows.Forms.BindingSource userBindingSource;
    }
}