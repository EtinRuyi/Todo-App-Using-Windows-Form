namespace ToDoApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Header = new Label();
            Title = new Label();
            TitleBox = new TextBox();
            Description = new Label();
            AddButton = new Button();
            LoadAllTodo = new Button();
            DeleteTodo = new Button();
            EditTodo = new Button();
            SearchTodo = new Button();
            SearchBox = new TextBox();
            DescriptionBox = new TextBox();
            StartDate = new Label();
            label3 = new Label();
            EndDateBox = new DateTimePicker();
            StartDateBox = new DateTimePicker();
            EndDate = new Label();
            TodoView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)TodoView).BeginInit();
            SuspendLayout();
            // 
            // Header
            // 
            Header.AllowDrop = true;
            Header.BackColor = Color.FromArgb(255, 128, 0);
            Header.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            Header.Location = new Point(-1, 0);
            Header.Name = "Header";
            Header.Size = new Size(1181, 50);
            Header.TabIndex = 0;
            Header.Text = "ToDo App";
            Header.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Title
            // 
            Title.AllowDrop = true;
            Title.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Title.ForeColor = Color.White;
            Title.Location = new Point(24, 90);
            Title.Name = "Title";
            Title.Size = new Size(56, 26);
            Title.TabIndex = 1;
            Title.Text = "Title";
            Title.TextAlign = ContentAlignment.BottomLeft;
            // 
            // TitleBox
            // 
            TitleBox.AllowDrop = true;
            TitleBox.Location = new Point(24, 112);
            TitleBox.Multiline = true;
            TitleBox.Name = "TitleBox";
            TitleBox.Size = new Size(327, 36);
            TitleBox.TabIndex = 2;
            // 
            // Description
            // 
            Description.AllowDrop = true;
            Description.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Description.ForeColor = Color.White;
            Description.Location = new Point(24, 154);
            Description.Name = "Description";
            Description.Size = new Size(124, 29);
            Description.TabIndex = 3;
            Description.Text = "Description";
            Description.TextAlign = ContentAlignment.BottomLeft;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(24, 272);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(124, 44);
            AddButton.TabIndex = 5;
            AddButton.Text = "Add / Update";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // LoadAllTodo
            // 
            LoadAllTodo.ForeColor = SystemColors.ControlText;
            LoadAllTodo.Location = new Point(220, 272);
            LoadAllTodo.Name = "LoadAllTodo";
            LoadAllTodo.Size = new Size(131, 44);
            LoadAllTodo.TabIndex = 6;
            LoadAllTodo.Text = "Load All Todo";
            LoadAllTodo.UseVisualStyleBackColor = true;
            LoadAllTodo.Click += LoadAllTodo_Click;
            // 
            // DeleteTodo
            // 
            DeleteTodo.Location = new Point(642, 272);
            DeleteTodo.Name = "DeleteTodo";
            DeleteTodo.Size = new Size(113, 44);
            DeleteTodo.TabIndex = 7;
            DeleteTodo.Text = "Delete Selected";
            DeleteTodo.UseVisualStyleBackColor = true;
            DeleteTodo.Click += DeleteTodo_Click;
            // 
            // EditTodo
            // 
            EditTodo.Location = new Point(424, 272);
            EditTodo.Name = "EditTodo";
            EditTodo.Size = new Size(130, 44);
            EditTodo.TabIndex = 8;
            EditTodo.Text = "Edit Selected";
            EditTodo.UseVisualStyleBackColor = true;
            EditTodo.Click += EditTodo_Click;
            // 
            // SearchTodo
            // 
            SearchTodo.BackColor = SystemColors.ButtonFace;
            SearchTodo.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            SearchTodo.Location = new Point(1046, 16);
            SearchTodo.Name = "SearchTodo";
            SearchTodo.Size = new Size(113, 27);
            SearchTodo.TabIndex = 9;
            SearchTodo.Text = "Search";
            SearchTodo.UseVisualStyleBackColor = false;
            SearchTodo.Click += SearchTodo_Click;
            // 
            // SearchBox
            // 
            SearchBox.AllowDrop = true;
            SearchBox.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point);
            SearchBox.Location = new Point(907, 16);
            SearchBox.Multiline = true;
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(145, 27);
            SearchBox.TabIndex = 11;
            SearchBox.Text = "Enter Title/Description";
            SearchBox.TextAlign = HorizontalAlignment.Center;
            // 
            // DescriptionBox
            // 
            DescriptionBox.AllowDrop = true;
            DescriptionBox.Location = new Point(24, 186);
            DescriptionBox.Multiline = true;
            DescriptionBox.Name = "DescriptionBox";
            DescriptionBox.Size = new Size(1135, 66);
            DescriptionBox.TabIndex = 12;
            // 
            // StartDate
            // 
            StartDate.AllowDrop = true;
            StartDate.BackColor = Color.FromArgb(255, 128, 0);
            StartDate.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            StartDate.ForeColor = SystemColors.ControlText;
            StartDate.Location = new Point(868, 89);
            StartDate.Name = "StartDate";
            StartDate.Size = new Size(69, 26);
            StartDate.TabIndex = 13;
            StartDate.Text = "Start Date";
            StartDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(237, 272);
            label3.Name = "label3";
            label3.Size = new Size(0, 17);
            label3.TabIndex = 14;
            // 
            // EndDateBox
            // 
            EndDateBox.Location = new Point(931, 121);
            EndDateBox.Name = "EndDateBox";
            EndDateBox.Size = new Size(228, 25);
            EndDateBox.TabIndex = 15;
            // 
            // StartDateBox
            // 
            StartDateBox.Location = new Point(931, 90);
            StartDateBox.Name = "StartDateBox";
            StartDateBox.Size = new Size(228, 25);
            StartDateBox.TabIndex = 16;
            // 
            // EndDate
            // 
            EndDate.AllowDrop = true;
            EndDate.BackColor = Color.FromArgb(255, 128, 0);
            EndDate.Location = new Point(868, 121);
            EndDate.Name = "EndDate";
            EndDate.Size = new Size(69, 25);
            EndDate.TabIndex = 17;
            EndDate.Text = "End Date";
            EndDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TodoView
            // 
            TodoView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TodoView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TodoView.Location = new Point(24, 322);
            TodoView.Name = "TodoView";
            TodoView.RowTemplate.Height = 25;
            TodoView.Size = new Size(1135, 321);
            TodoView.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(1180, 656);
            Controls.Add(TodoView);
            Controls.Add(EndDate);
            Controls.Add(StartDateBox);
            Controls.Add(EndDateBox);
            Controls.Add(label3);
            Controls.Add(StartDate);
            Controls.Add(DescriptionBox);
            Controls.Add(SearchBox);
            Controls.Add(SearchTodo);
            Controls.Add(EditTodo);
            Controls.Add(DeleteTodo);
            Controls.Add(LoadAllTodo);
            Controls.Add(AddButton);
            Controls.Add(Description);
            Controls.Add(TitleBox);
            Controls.Add(Title);
            Controls.Add(Header);
            Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            Text = "TODoApp";
            ((System.ComponentModel.ISupportInitialize)TodoView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Header;
        private Label Title;
        private TextBox TitleBox;
        private Label Description;
        private Button AddButton;
        private Button LoadAllTodo;
        private Button DeleteTodo;
        private Button EditTodo;
        private Button SearchTodo;
        private TextBox SearchBox;
        private TextBox DescriptionBox;
        private Label StartDate;
        private Label label3;
        private DateTimePicker EndDateBox;
        private DateTimePicker StartDateBox;
        private Label EndDate;
        private DataGridView TodoView;
    }
}