namespace UchProject
{
    partial class InsertData
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
            this.comboBoxTimeAndTypeOfLesson = new System.Windows.Forms.ComboBox();
            this.labelTypeAndTimeOfLesson = new System.Windows.Forms.Label();
            this.labelDayOfWeek = new System.Windows.Forms.Label();
            this.labelTypeOfWeek = new System.Windows.Forms.Label();
            this.labelGroup = new System.Windows.Forms.Label();
            this.labelTeacher = new System.Windows.Forms.Label();
            this.labelDiscipline = new System.Windows.Forms.Label();
            this.labelAuditory = new System.Windows.Forms.Label();
            this.comboBoxDayofWeek = new System.Windows.Forms.ComboBox();
            this.comboBoxTypeOfWeek = new System.Windows.Forms.ComboBox();
            this.comboBoxTeacher = new System.Windows.Forms.ComboBox();
            this.buttonAddChangeTeacher = new System.Windows.Forms.Button();
            this.comboBoxDiscipline = new System.Windows.Forms.ComboBox();
            this.comboBoxAuditory = new System.Windows.Forms.ComboBox();
            this.buttonAnalyseCollision = new System.Windows.Forms.Button();
            this.buttonAddRecord = new System.Windows.Forms.Button();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.buttonAddNewGroup = new System.Windows.Forms.Button();
            this.buttonAddDiscipline = new System.Windows.Forms.Button();
            this.buttonAddNumAuditory = new System.Windows.Forms.Button();
            this.buttonDeleteNumAuditory = new System.Windows.Forms.Button();
            this.buttonDeleteDiscipline = new System.Windows.Forms.Button();
            this.buttonDeleteGroup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxTimeAndTypeOfLesson
            // 
            this.comboBoxTimeAndTypeOfLesson.FormattingEnabled = true;
            this.comboBoxTimeAndTypeOfLesson.Items.AddRange(new object[] {
            "ЛЗ: 8.30-11.40",
            "ЛЗ:11.50-15.00",
            "ЛЗ:15.10-18.20",
            "ЛЗ:18.00-21.10",
            "ЛЗ:18.30-21.40",
            "ПР: 9.00-10.30",
            "ПР:10.45-12.15",
            "ПР:13.00-14.30",
            "ПР:14.45-16.15",
            "ПР:16.30-18.00"});
            this.comboBoxTimeAndTypeOfLesson.Location = new System.Drawing.Point(247, 7);
            this.comboBoxTimeAndTypeOfLesson.Name = "comboBoxTimeAndTypeOfLesson";
            this.comboBoxTimeAndTypeOfLesson.Size = new System.Drawing.Size(189, 21);
            this.comboBoxTimeAndTypeOfLesson.TabIndex = 0;
            this.comboBoxTimeAndTypeOfLesson.SelectedIndexChanged += new System.EventHandler(this.comboBoxTimeAndTypeOfLesson_SelectedIndexChanged);
            // 
            // labelTypeAndTimeOfLesson
            // 
            this.labelTypeAndTimeOfLesson.AutoSize = true;
            this.labelTypeAndTimeOfLesson.Location = new System.Drawing.Point(64, 10);
            this.labelTypeAndTimeOfLesson.Name = "labelTypeAndTimeOfLesson";
            this.labelTypeAndTimeOfLesson.Size = new System.Drawing.Size(177, 13);
            this.labelTypeAndTimeOfLesson.TabIndex = 1;
            this.labelTypeAndTimeOfLesson.Text = "Тип и время проведения занятия";
            // 
            // labelDayOfWeek
            // 
            this.labelDayOfWeek.AutoSize = true;
            this.labelDayOfWeek.Location = new System.Drawing.Point(168, 37);
            this.labelDayOfWeek.Name = "labelDayOfWeek";
            this.labelDayOfWeek.Size = new System.Drawing.Size(73, 13);
            this.labelDayOfWeek.TabIndex = 1;
            this.labelDayOfWeek.Text = "День недели";
            // 
            // labelTypeOfWeek
            // 
            this.labelTypeOfWeek.AutoSize = true;
            this.labelTypeOfWeek.Location = new System.Drawing.Point(176, 64);
            this.labelTypeOfWeek.Name = "labelTypeOfWeek";
            this.labelTypeOfWeek.Size = new System.Drawing.Size(65, 13);
            this.labelTypeOfWeek.TabIndex = 1;
            this.labelTypeOfWeek.Text = "Тип недели";
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new System.Drawing.Point(199, 91);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(42, 13);
            this.labelGroup.TabIndex = 1;
            this.labelGroup.Text = "Группа";
            // 
            // labelTeacher
            // 
            this.labelTeacher.AutoSize = true;
            this.labelTeacher.Location = new System.Drawing.Point(155, 147);
            this.labelTeacher.Name = "labelTeacher";
            this.labelTeacher.Size = new System.Drawing.Size(86, 13);
            this.labelTeacher.TabIndex = 1;
            this.labelTeacher.Text = "Преподаватель";
            // 
            // labelDiscipline
            // 
            this.labelDiscipline.AutoSize = true;
            this.labelDiscipline.Location = new System.Drawing.Point(171, 204);
            this.labelDiscipline.Name = "labelDiscipline";
            this.labelDiscipline.Size = new System.Drawing.Size(70, 13);
            this.labelDiscipline.TabIndex = 1;
            this.labelDiscipline.Text = "Дисциплина";
            // 
            // labelAuditory
            // 
            this.labelAuditory.AutoSize = true;
            this.labelAuditory.Location = new System.Drawing.Point(181, 260);
            this.labelAuditory.Name = "labelAuditory";
            this.labelAuditory.Size = new System.Drawing.Size(60, 13);
            this.labelAuditory.TabIndex = 1;
            this.labelAuditory.Text = "Аудитория";
            // 
            // comboBoxDayofWeek
            // 
            this.comboBoxDayofWeek.FormattingEnabled = true;
            this.comboBoxDayofWeek.Items.AddRange(new object[] {
            "Понедельник",
            "Вторник",
            "Среда",
            "Четверг",
            "Пятница",
            "Суббота"});
            this.comboBoxDayofWeek.Location = new System.Drawing.Point(247, 34);
            this.comboBoxDayofWeek.Name = "comboBoxDayofWeek";
            this.comboBoxDayofWeek.Size = new System.Drawing.Size(189, 21);
            this.comboBoxDayofWeek.TabIndex = 0;
            // 
            // comboBoxTypeOfWeek
            // 
            this.comboBoxTypeOfWeek.FormattingEnabled = true;
            this.comboBoxTypeOfWeek.Items.AddRange(new object[] {
            "Верхняя",
            "Нижняя"});
            this.comboBoxTypeOfWeek.Location = new System.Drawing.Point(247, 61);
            this.comboBoxTypeOfWeek.Name = "comboBoxTypeOfWeek";
            this.comboBoxTypeOfWeek.Size = new System.Drawing.Size(189, 21);
            this.comboBoxTypeOfWeek.TabIndex = 0;
            // 
            // comboBoxTeacher
            // 
            this.comboBoxTeacher.FormattingEnabled = true;
            this.comboBoxTeacher.Location = new System.Drawing.Point(247, 144);
            this.comboBoxTeacher.Name = "comboBoxTeacher";
            this.comboBoxTeacher.Size = new System.Drawing.Size(189, 21);
            this.comboBoxTeacher.TabIndex = 0;
            this.comboBoxTeacher.SelectedIndexChanged += new System.EventHandler(this.comboBoxTeacher_SelectedIndexChanged);
            this.comboBoxTeacher.Click += new System.EventHandler(this.comboBoxTeacher_SelectedIndexChanged);
            // 
            // buttonAddChangeTeacher
            // 
            this.buttonAddChangeTeacher.Location = new System.Drawing.Point(172, 172);
            this.buttonAddChangeTeacher.Name = "buttonAddChangeTeacher";
            this.buttonAddChangeTeacher.Size = new System.Drawing.Size(264, 23);
            this.buttonAddChangeTeacher.TabIndex = 2;
            this.buttonAddChangeTeacher.Text = "Добавить/Изменить ФИО преподавателя";
            this.buttonAddChangeTeacher.UseVisualStyleBackColor = true;
            this.buttonAddChangeTeacher.Click += new System.EventHandler(this.buttonAddChangeTeacher_Click);
            // 
            // comboBoxDiscipline
            // 
            this.comboBoxDiscipline.FormattingEnabled = true;
            this.comboBoxDiscipline.Location = new System.Drawing.Point(247, 201);
            this.comboBoxDiscipline.Name = "comboBoxDiscipline";
            this.comboBoxDiscipline.Size = new System.Drawing.Size(189, 21);
            this.comboBoxDiscipline.TabIndex = 0;
            // 
            // comboBoxAuditory
            // 
            this.comboBoxAuditory.FormattingEnabled = true;
            this.comboBoxAuditory.Location = new System.Drawing.Point(247, 257);
            this.comboBoxAuditory.Name = "comboBoxAuditory";
            this.comboBoxAuditory.Size = new System.Drawing.Size(189, 21);
            this.comboBoxAuditory.TabIndex = 0;
            // 
            // buttonAnalyseCollision
            // 
            this.buttonAnalyseCollision.Location = new System.Drawing.Point(100, 329);
            this.buttonAnalyseCollision.Name = "buttonAnalyseCollision";
            this.buttonAnalyseCollision.Size = new System.Drawing.Size(141, 23);
            this.buttonAnalyseCollision.TabIndex = 3;
            this.buttonAnalyseCollision.Text = "Проверить пересечения";
            this.buttonAnalyseCollision.UseVisualStyleBackColor = true;
            this.buttonAnalyseCollision.Click += new System.EventHandler(this.buttonAnalyseCollision_Click);
            // 
            // buttonAddRecord
            // 
            this.buttonAddRecord.Location = new System.Drawing.Point(247, 329);
            this.buttonAddRecord.Name = "buttonAddRecord";
            this.buttonAddRecord.Size = new System.Drawing.Size(129, 23);
            this.buttonAddRecord.TabIndex = 3;
            this.buttonAddRecord.Text = "Добавить запись";
            this.buttonAddRecord.UseVisualStyleBackColor = true;
            this.buttonAddRecord.Click += new System.EventHandler(this.buttonAddRecord_Click);
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Location = new System.Drawing.Point(247, 88);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(189, 21);
            this.comboBoxGroup.TabIndex = 0;
            // 
            // buttonAddNewGroup
            // 
            this.buttonAddNewGroup.Location = new System.Drawing.Point(247, 115);
            this.buttonAddNewGroup.Name = "buttonAddNewGroup";
            this.buttonAddNewGroup.Size = new System.Drawing.Size(189, 23);
            this.buttonAddNewGroup.TabIndex = 4;
            this.buttonAddNewGroup.Text = "Добавить номер группы";
            this.buttonAddNewGroup.UseVisualStyleBackColor = true;
            this.buttonAddNewGroup.Click += new System.EventHandler(this.buttonAddNewGroup_Click);
            // 
            // buttonAddDiscipline
            // 
            this.buttonAddDiscipline.Location = new System.Drawing.Point(247, 229);
            this.buttonAddDiscipline.Name = "buttonAddDiscipline";
            this.buttonAddDiscipline.Size = new System.Drawing.Size(188, 23);
            this.buttonAddDiscipline.TabIndex = 5;
            this.buttonAddDiscipline.Text = "Добавить название дисциплины";
            this.buttonAddDiscipline.UseVisualStyleBackColor = true;
            this.buttonAddDiscipline.Click += new System.EventHandler(this.buttonAddDiscipline_Click);
            // 
            // buttonAddNumAuditory
            // 
            this.buttonAddNumAuditory.Location = new System.Drawing.Point(247, 284);
            this.buttonAddNumAuditory.Name = "buttonAddNumAuditory";
            this.buttonAddNumAuditory.Size = new System.Drawing.Size(188, 23);
            this.buttonAddNumAuditory.TabIndex = 6;
            this.buttonAddNumAuditory.Text = "Добавить номер аудитории";
            this.buttonAddNumAuditory.UseVisualStyleBackColor = true;
            this.buttonAddNumAuditory.Click += new System.EventHandler(this.buttonAddNumAuditory_Click);
            // 
            // buttonDeleteNumAuditory
            // 
            this.buttonDeleteNumAuditory.Location = new System.Drawing.Point(67, 284);
            this.buttonDeleteNumAuditory.Name = "buttonDeleteNumAuditory";
            this.buttonDeleteNumAuditory.Size = new System.Drawing.Size(174, 23);
            this.buttonDeleteNumAuditory.TabIndex = 7;
            this.buttonDeleteNumAuditory.Text = "Удалить номер аудитории";
            this.buttonDeleteNumAuditory.UseVisualStyleBackColor = true;
            this.buttonDeleteNumAuditory.Click += new System.EventHandler(this.buttonDeleteNumAuditory_Click);
            // 
            // buttonDeleteDiscipline
            // 
            this.buttonDeleteDiscipline.Location = new System.Drawing.Point(67, 229);
            this.buttonDeleteDiscipline.Name = "buttonDeleteDiscipline";
            this.buttonDeleteDiscipline.Size = new System.Drawing.Size(174, 23);
            this.buttonDeleteDiscipline.TabIndex = 5;
            this.buttonDeleteDiscipline.Text = "Удалить название дисциплины";
            this.buttonDeleteDiscipline.UseVisualStyleBackColor = true;
            this.buttonDeleteDiscipline.Click += new System.EventHandler(this.buttonDeleteDiscipline_Click);
            // 
            // buttonDeleteGroup
            // 
            this.buttonDeleteGroup.Location = new System.Drawing.Point(67, 115);
            this.buttonDeleteGroup.Name = "buttonDeleteGroup";
            this.buttonDeleteGroup.Size = new System.Drawing.Size(174, 23);
            this.buttonDeleteGroup.TabIndex = 4;
            this.buttonDeleteGroup.Text = "Удалить номер группы";
            this.buttonDeleteGroup.UseVisualStyleBackColor = true;
            this.buttonDeleteGroup.Click += new System.EventHandler(this.buttonDeleteGroup_Click);
            // 
            // InsertData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 377);
            this.Controls.Add(this.buttonDeleteNumAuditory);
            this.Controls.Add(this.buttonAddNumAuditory);
            this.Controls.Add(this.buttonDeleteDiscipline);
            this.Controls.Add(this.buttonAddDiscipline);
            this.Controls.Add(this.buttonDeleteGroup);
            this.Controls.Add(this.buttonAddNewGroup);
            this.Controls.Add(this.buttonAddRecord);
            this.Controls.Add(this.buttonAnalyseCollision);
            this.Controls.Add(this.buttonAddChangeTeacher);
            this.Controls.Add(this.labelAuditory);
            this.Controls.Add(this.labelDiscipline);
            this.Controls.Add(this.labelTeacher);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.labelTypeOfWeek);
            this.Controls.Add(this.labelDayOfWeek);
            this.Controls.Add(this.labelTypeAndTimeOfLesson);
            this.Controls.Add(this.comboBoxAuditory);
            this.Controls.Add(this.comboBoxDiscipline);
            this.Controls.Add(this.comboBoxTeacher);
            this.Controls.Add(this.comboBoxGroup);
            this.Controls.Add(this.comboBoxTypeOfWeek);
            this.Controls.Add(this.comboBoxDayofWeek);
            this.Controls.Add(this.comboBoxTimeAndTypeOfLesson);
            this.Name = "InsertData";
            this.Text = "UchProject : insertData";
            this.Load += new System.EventHandler(this.InsertData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTimeAndTypeOfLesson;
        private System.Windows.Forms.Label labelTypeAndTimeOfLesson;
        private System.Windows.Forms.Label labelDayOfWeek;
        private System.Windows.Forms.Label labelTypeOfWeek;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Label labelTeacher;
        private System.Windows.Forms.Label labelDiscipline;
        private System.Windows.Forms.Label labelAuditory;
        private System.Windows.Forms.ComboBox comboBoxDayofWeek;
        private System.Windows.Forms.ComboBox comboBoxTypeOfWeek;
        private System.Windows.Forms.ComboBox comboBoxTeacher;
        private System.Windows.Forms.Button buttonAddChangeTeacher;
        private System.Windows.Forms.ComboBox comboBoxDiscipline;
        private System.Windows.Forms.ComboBox comboBoxAuditory;
        private System.Windows.Forms.Button buttonAnalyseCollision;
        private System.Windows.Forms.Button buttonAddRecord;
        private System.Windows.Forms.ComboBox comboBoxGroup;
        private System.Windows.Forms.Button buttonAddNewGroup;
        private System.Windows.Forms.Button buttonAddDiscipline;
        private System.Windows.Forms.Button buttonAddNumAuditory;
        private System.Windows.Forms.Button buttonDeleteNumAuditory;
        private System.Windows.Forms.Button buttonDeleteDiscipline;
        private System.Windows.Forms.Button buttonDeleteGroup;

    }
}

