using System.Security.Policy;

namespace DecanatPRO.WinForms
{
    partial class StudentView
    {
        private System.ComponentModel.IContainer? components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblName = new Label();
            lblSpeciality = new Label();
            lblGroup = new Label();
            Name_TextBox = new TextBox();
            Speciality_TextBox = new TextBox();
            Group_TextBox = new TextBox();
            AddStudent_Button = new Button();
            DeleteStudent_Button = new Button();
            Students_ListView = new ListView();
            colName = new ColumnHeader();
            colSpeciality = new ColumnHeader();
            colGroup = new ColumnHeader();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 15);
            lblName.Name = "lblName";
            lblName.Text = "ФИО";
            // 
            // lblSpeciality
            // 
            lblSpeciality.AutoSize = true;
            lblSpeciality.Location = new Point(245, 15);
            lblSpeciality.Name = "lblSpeciality";
            lblSpeciality.Text = "Направление";
            // 
            // lblGroup
            // 
            lblGroup.AutoSize = true;
            lblGroup.Location = new Point(428, 15);
            lblGroup.Name = "lblGroup";
            lblGroup.Text = "Группа";
            // 
            // Name_TextBox
            // 
            Name_TextBox.Location = new Point(12, 35);
            Name_TextBox.Name = "Name_TextBox";
            Name_TextBox.Size = new Size(220, 23);
            Name_TextBox.TabIndex = 0;
            // 
            // Speciality_TextBox
            // 
            Speciality_TextBox.Location = new Point(245, 35);
            Speciality_TextBox.Name = "Speciality_TextBox";
            Speciality_TextBox.Size = new Size(170, 23);
            Speciality_TextBox.TabIndex = 1;
            // 
            // Group_TextBox
            // 
            Group_TextBox.Location = new Point(428, 35);
            Group_TextBox.Name = "Group_TextBox";
            Group_TextBox.Size = new Size(110, 23);
            Group_TextBox.TabIndex = 2;
            // 
            // AddStudent_Button
            // 
            AddStudent_Button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddStudent_Button.Location = new Point(552, 33);
            AddStudent_Button.Name = "AddStudent_Button";
            AddStudent_Button.Size = new Size(156, 27);
            AddStudent_Button.TabIndex = 3;

            AddStudent_Button.Text = "Добавить";
            AddStudent_Button.UseVisualStyleBackColor = true;
            AddStudent_Button.Click += AddStudent_Button_Click;
            // 
            // Students_ListView
            // 
            Students_ListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Students_ListView.Columns.AddRange(new ColumnHeader[] { colName, colSpeciality, colGroup });
            Students_ListView.FullRowSelect = true;
            Students_ListView.GridLines = true;
            Students_ListView.HideSelection = false;
            Students_ListView.Location = new Point(12, 75);
            Students_ListView.MultiSelect = false;
            Students_ListView.Name = "Students_ListView";
            Students_ListView.Size = new Size(696, 310);
            Students_ListView.Sorting = SortOrder.None;
            Students_ListView.TabIndex = 4;
            Students_ListView.UseCompatibleStateImageBehavior = false;
            Students_ListView.View = System.Windows.Forms.View.Details;
            // 
            // colName
            // 
            colName.Text = "ФИО";
            colName.Width = 300;
            // 
            // colSpeciality
            // 
            colSpeciality.Text = "Направление";
            colSpeciality.Width = 220;
            // 
            // colGroup
            // 
            colGroup.Text = "Группа";
            colGroup.Width = 150;
            // 
            // DeleteStudent_Button
            // 
            DeleteStudent_Button.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DeleteStudent_Button.Location = new Point(12, 395);
            DeleteStudent_Button.Name = "DeleteStudent_Button";
            DeleteStudent_Button.Size = new Size(696, 32);
            DeleteStudent_Button.TabIndex = 5;
            DeleteStudent_Button.Text = "Удалить";
            DeleteStudent_Button.UseVisualStyleBackColor = true;
            DeleteStudent_Button.Click += DeleteStudent_Button_Click;
            // 
            // StudentView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 440);
            Controls.Add(lblName);
            Controls.Add(lblSpeciality);
            Controls.Add(lblGroup);
            Controls.Add(Name_TextBox);
            Controls.Add(Speciality_TextBox);
            Controls.Add(Group_TextBox);
            Controls.Add(AddStudent_Button);
            Controls.Add(Students_ListView);
            Controls.Add(DeleteStudent_Button);
            MinimumSize = new Size(640, 380);
            Name = "StudentView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DecanatPRO (MVP)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblSpeciality;
        private Label lblGroup;
        private TextBox Name_TextBox;
        private TextBox Speciality_TextBox;
        private TextBox Group_TextBox;
        private Button AddStudent_Button;
        private Button DeleteStudent_Button;
        private ListView Students_ListView;
        private ColumnHeader colName;
        private ColumnHeader colSpeciality;
        private ColumnHeader colGroup;
    }
}

