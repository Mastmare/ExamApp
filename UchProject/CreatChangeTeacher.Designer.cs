namespace UchProject
{
    partial class CreatChangeTeacher
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
            this.comboBoxAddChangeTeacher = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddNewTeacher = new System.Windows.Forms.Button();
            this.textBoxNewName = new System.Windows.Forms.TextBox();
            this.buttonChangeTeacher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxAddChangeTeacher
            // 
            this.comboBoxAddChangeTeacher.FormattingEnabled = true;
            this.comboBoxAddChangeTeacher.Location = new System.Drawing.Point(12, 12);
            this.comboBoxAddChangeTeacher.Name = "comboBoxAddChangeTeacher";
            this.comboBoxAddChangeTeacher.Size = new System.Drawing.Size(237, 21);
            this.comboBoxAddChangeTeacher.TabIndex = 0;
            this.comboBoxAddChangeTeacher.SelectedIndexChanged += new System.EventHandler(this.comboBoxAddChangeTeacher_SelectedIndexChanged);
            this.comboBoxAddChangeTeacher.Click += new System.EventHandler(this.comboBoxAddChangeTeacher_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите или введите ФИО преподавателя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Новое имя преподавателя";
            // 
            // buttonAddNewTeacher
            // 
            this.buttonAddNewTeacher.Location = new System.Drawing.Point(255, 10);
            this.buttonAddNewTeacher.Name = "buttonAddNewTeacher";
            this.buttonAddNewTeacher.Size = new System.Drawing.Size(146, 23);
            this.buttonAddNewTeacher.TabIndex = 3;
            this.buttonAddNewTeacher.Text = "Добавить преподавателя";
            this.buttonAddNewTeacher.UseVisualStyleBackColor = true;
            this.buttonAddNewTeacher.Click += new System.EventHandler(this.buttonAddNewTeacher_Click);
            // 
            // textBoxNewName
            // 
            this.textBoxNewName.Location = new System.Drawing.Point(12, 61);
            this.textBoxNewName.Name = "textBoxNewName";
            this.textBoxNewName.Size = new System.Drawing.Size(237, 20);
            this.textBoxNewName.TabIndex = 4;
            // 
            // buttonChangeTeacher
            // 
            this.buttonChangeTeacher.Location = new System.Drawing.Point(255, 58);
            this.buttonChangeTeacher.Name = "buttonChangeTeacher";
            this.buttonChangeTeacher.Size = new System.Drawing.Size(146, 23);
            this.buttonChangeTeacher.TabIndex = 3;
            this.buttonChangeTeacher.Text = "Изменить ФИО";
            this.buttonChangeTeacher.UseVisualStyleBackColor = true;
            this.buttonChangeTeacher.Click += new System.EventHandler(this.buttonChangeTeacher_Click);
            // 
            // CreatChangeTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 265);
            this.Controls.Add(this.textBoxNewName);
            this.Controls.Add(this.buttonChangeTeacher);
            this.Controls.Add(this.buttonAddNewTeacher);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxAddChangeTeacher);
            this.Name = "CreatChangeTeacher";
            this.Text = "CreatChangeTeacher";
            this.Load += new System.EventHandler(this.CreatChangeTeacher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAddChangeTeacher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddNewTeacher;
        private System.Windows.Forms.TextBox textBoxNewName;
        private System.Windows.Forms.Button buttonChangeTeacher;
    }
}