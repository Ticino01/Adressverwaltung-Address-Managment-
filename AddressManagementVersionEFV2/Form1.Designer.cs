using Microsoft.EntityFrameworkCore;



namespace AddressManagementVersionEFV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            cityComboBox = new ComboBox();
            searchTextBox = new TextBox();
            label8 = new Label();
            SearchResultClear = new Button();
            SearchButton = new Button();
            DeleteButton = new Button();
            dataGridView1 = new DataGridView();
            cityTextBox = new TextBox();
            plzBox = new TextBox();
            houseNrBox = new TextBox();
            lastNameBox = new TextBox();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            editButton = new Button();
            UpdateButton = new Button();
            saveButton = new Button();
            phoneTextBox = new TextBox();
            emailTextBox = new TextBox();
            streetTextBox = new TextBox();
            nameTextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            newButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cityComboBox
            // 
            cityComboBox.FormattingEnabled = true;
            cityComboBox.Items.AddRange(new object[] { "comboBoxCities.Visible = false;" });
            cityComboBox.Location = new Point(460, 99);
            cityComboBox.Name = "cityComboBox";
            cityComboBox.Size = new Size(151, 28);
            cityComboBox.TabIndex = 51;
            cityComboBox.SelectedIndexChanged += cityComboBox_SelectedIndexChanged;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(523, 26);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PlaceholderText = "Search by Name or City";
            searchTextBox.Size = new Size(163, 27);
            searchTextBox.TabIndex = 49;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(460, 29);
            label8.Name = "label8";
            label8.Size = new Size(57, 20);
            label8.TabIndex = 48;
            label8.Text = "Search ";
            // 
            // SearchResultClear
            // 
            SearchResultClear.Anchor = AnchorStyles.None;
            SearchResultClear.Image = (Image)resources.GetObject("SearchResultClear.Image");
            SearchResultClear.Location = new Point(351, 197);
            SearchResultClear.Name = "SearchResultClear";
            SearchResultClear.Size = new Size(91, 39);
            SearchResultClear.TabIndex = 46;
            SearchResultClear.UseVisualStyleBackColor = true;
            SearchResultClear.Click += SearchResultClear_Click;
            // 
            // SearchButton
            // 
            SearchButton.Image = (Image)resources.GetObject("SearchButton.Image");
            SearchButton.Location = new Point(692, 23);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(106, 32);
            SearchButton.TabIndex = 50;
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Anchor = AnchorStyles.None;
            DeleteButton.Location = new Point(239, 196);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(93, 40);
            DeleteButton.TabIndex = 45;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(20, 242);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(778, 181);
            dataGridView1.TabIndex = 47;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // cityTextBox
            // 
            cityTextBox.Location = new Point(323, 98);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(119, 27);
            cityTextBox.TabIndex = 37;
            // 
            // plzBox
            // 
            plzBox.Location = new Point(95, 96);
            plzBox.Name = "plzBox";
            plzBox.Size = new Size(119, 27);
            plzBox.TabIndex = 35;
            plzBox.TextChanged += plzBox_TextChanged;
            plzBox.Leave += plzBox_Leave;
            // 
            // houseNrBox
            // 
            houseNrBox.Location = new Point(323, 57);
            houseNrBox.Name = "houseNrBox";
            houseNrBox.Size = new Size(119, 27);
            houseNrBox.TabIndex = 33;
            // 
            // lastNameBox
            // 
            lastNameBox.Location = new Point(323, 21);
            lastNameBox.Name = "lastNameBox";
            lastNameBox.Size = new Size(119, 27);
            lastNameBox.TabIndex = 29;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(248, 96);
            label9.Name = "label9";
            label9.Size = new Size(34, 20);
            label9.TabIndex = 36;
            label9.Text = "City";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(-97, 91);
            label7.Name = "label7";
            label7.Size = new Size(81, 20);
            label7.TabIndex = 34;
            label7.Text = "Postalcode";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(238, 60);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 32;
            label6.Text = "House-Nr";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(239, 22);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 28;
            label5.Text = "Lastname";
            // 
            // editButton
            // 
            editButton.Anchor = AnchorStyles.None;
            editButton.Location = new Point(8, 196);
            editButton.Margin = new Padding(2);
            editButton.Name = "editButton";
            editButton.Size = new Size(93, 40);
            editButton.TabIndex = 43;
            editButton.Text = "Save";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Anchor = AnchorStyles.None;
            UpdateButton.Location = new Point(121, 196);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(93, 40);
            UpdateButton.TabIndex = 44;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.None;
            saveButton.BackColor = SystemColors.ControlLightLight;
            saveButton.Image = (Image)resources.GetObject("saveButton.Image");
            saveButton.Location = new Point(-105, 196);
            saveButton.Margin = new Padding(2);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(93, 40);
            saveButton.TabIndex = 42;
            saveButton.UseVisualStyleBackColor = false;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(95, 134);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(119, 27);
            phoneTextBox.TabIndex = 39;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(323, 133);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(119, 27);
            emailTextBox.TabIndex = 41;
            // 
            // streetTextBox
            // 
            streetTextBox.Location = new Point(95, 59);
            streetTextBox.Name = "streetTextBox";
            streetTextBox.Size = new Size(119, 27);
            streetTextBox.TabIndex = 31;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(95, 19);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(119, 27);
            nameTextBox.TabIndex = 27;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(-84, 124);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 38;
            label4.Text = "Phone-Nr";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(248, 134);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 40;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(-84, 58);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 30;
            label2.Text = "Street";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(-84, 21);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 26;
            label1.Text = "Firstname";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new Point(12, 99);
            label10.Name = "label10";
            label10.Size = new Size(81, 20);
            label10.TabIndex = 54;
            label10.Text = "Postalcode";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Location = new Point(13, 138);
            label11.Name = "label11";
            label11.Size = new Size(72, 20);
            label11.TabIndex = 55;
            label11.Text = "Phone-Nr";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Location = new Point(21, 62);
            label12.Name = "label12";
            label12.Size = new Size(48, 20);
            label12.TabIndex = 53;
            label12.Text = "Street";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Location = new Point(12, 26);
            label13.Name = "label13";
            label13.Size = new Size(73, 20);
            label13.TabIndex = 52;
            label13.Text = "Firstname";
            // 
            // newButton
            // 
            newButton.Anchor = AnchorStyles.None;
            newButton.Location = new Point(448, 197);
            newButton.Name = "newButton";
            newButton.Size = new Size(90, 40);
            newButton.TabIndex = 56;
            newButton.Text = "New";
            newButton.UseVisualStyleBackColor = true;
            newButton.Click += newButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 450);
            Controls.Add(newButton);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(cityComboBox);
            Controls.Add(searchTextBox);
            Controls.Add(label8);
            Controls.Add(SearchResultClear);
            Controls.Add(SearchButton);
            Controls.Add(DeleteButton);
            Controls.Add(dataGridView1);
            Controls.Add(cityTextBox);
            Controls.Add(plzBox);
            Controls.Add(houseNrBox);
            Controls.Add(lastNameBox);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(editButton);
            Controls.Add(UpdateButton);
            Controls.Add(saveButton);
            Controls.Add(phoneTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(streetTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cityComboBox;
        private TextBox searchTextBox;
        private Label label8;
        private Button SearchResultClear;
        private Button SearchButton;
        private Button DeleteButton;
        private DataGridView dataGridView1;
        private TextBox cityTextBox;
        private TextBox plzBox;
        private TextBox houseNrBox;
        private TextBox lastNameBox;
        private Label label9;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button editButton;
        private Button UpdateButton;
        private Button saveButton;
        private TextBox phoneTextBox;
        private TextBox emailTextBox;
        private TextBox streetTextBox;
        private TextBox nameTextBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Button newButton;
    }
}
