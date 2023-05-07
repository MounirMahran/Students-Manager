namespace Students_Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.mtbPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mtbLevel = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtbID = new System.Windows.Forms.MaskedTextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StudentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Level = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BirthDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbListViewTiles = new System.Windows.Forms.RadioButton();
            this.rbListViewList = new System.Windows.Forms.RadioButton();
            this.rbListViewSmallIcon = new System.Windows.Forms.RadioButton();
            this.rbListViewLargeIcon = new System.Windows.Forms.RadioButton();
            this.rbListViewDetails = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.cbGender);
            this.groupBox1.Controls.Add(this.mtbPhoneNumber);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.mtbLevel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.mtbID);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 254);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Student Info";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(73, 214);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(234, 25);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Birth Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(234, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Gender";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(292, 159);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(98, 34);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(292, 114);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 34);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbGender
            // 
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(292, 27);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(98, 25);
            this.cbGender.TabIndex = 8;
            // 
            // mtbPhoneNumber
            // 
            this.mtbPhoneNumber.Location = new System.Drawing.Point(73, 168);
            this.mtbPhoneNumber.Mask = "(+20) 00-000-000-00";
            this.mtbPhoneNumber.Name = "mtbPhoneNumber";
            this.mtbPhoneNumber.Size = new System.Drawing.Size(142, 25);
            this.mtbPhoneNumber.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ph. Num";
            // 
            // mtbLevel
            // 
            this.mtbLevel.Location = new System.Drawing.Point(73, 121);
            this.mtbLevel.Mask = "0";
            this.mtbLevel.Name = "mtbLevel";
            this.mtbLevel.Size = new System.Drawing.Size(142, 25);
            this.mtbLevel.TabIndex = 5;
            this.mtbLevel.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID";
            // 
            // mtbID
            // 
            this.mtbID.Location = new System.Drawing.Point(73, 74);
            this.mtbID.Mask = "00000000";
            this.mtbID.Name = "mtbID";
            this.mtbID.Size = new System.Drawing.Size(142, 25);
            this.mtbID.TabIndex = 2;
            this.mtbID.ValidatingType = typeof(int);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(73, 27);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(142, 25);
            this.tbName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(268, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Students Manager";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.StudentName,
            this.Level,
            this.PhoneNumber,
            this.Gender,
            this.BirthDate});
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.imageList2;
            this.listView1.Location = new System.Drawing.Point(12, 313);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(749, 200);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 79;
            // 
            // StudentName
            // 
            this.StudentName.Text = "Name";
            this.StudentName.Width = 171;
            // 
            // Level
            // 
            this.Level.Text = "Level";
            this.Level.Width = 62;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Text = "Phone Number";
            this.PhoneNumber.Width = 117;
            // 
            // Gender
            // 
            this.Gender.Text = "Gender";
            this.Gender.Width = 74;
            // 
            // BirthDate
            // 
            this.BirthDate.Text = "Birth Date";
            this.BirthDate.Width = 193;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "avatar_face_girl_female_woman_profile_smiley_happy_people_icon_181656.png");
            this.imageList2.Images.SetKeyName(1, "avatar_face_man_boy_profile_smiley_happy_people_icon_181659.png");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "avatar_face_girl_female_woman_profile_smiley_happy_people_icon_181656.png");
            this.imageList1.Images.SetKeyName(1, "avatar_face_man_boy_profile_smiley_happy_people_icon_181659.png");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbListViewTiles);
            this.panel1.Controls.Add(this.rbListViewList);
            this.panel1.Controls.Add(this.rbListViewSmallIcon);
            this.panel1.Controls.Add(this.rbListViewLargeIcon);
            this.panel1.Controls.Add(this.rbListViewDetails);
            this.panel1.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(588, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(117, 208);
            this.panel1.TabIndex = 3;
            // 
            // rbListViewTiles
            // 
            this.rbListViewTiles.AutoSize = true;
            this.rbListViewTiles.Location = new System.Drawing.Point(15, 178);
            this.rbListViewTiles.Name = "rbListViewTiles";
            this.rbListViewTiles.Size = new System.Drawing.Size(59, 22);
            this.rbListViewTiles.TabIndex = 4;
            this.rbListViewTiles.TabStop = true;
            this.rbListViewTiles.Text = "Tiles";
            this.rbListViewTiles.UseVisualStyleBackColor = true;
            this.rbListViewTiles.CheckedChanged += new System.EventHandler(this.rbListViewTiles_CheckedChanged);
            // 
            // rbListViewList
            // 
            this.rbListViewList.AutoSize = true;
            this.rbListViewList.Location = new System.Drawing.Point(15, 132);
            this.rbListViewList.Name = "rbListViewList";
            this.rbListViewList.Size = new System.Drawing.Size(51, 22);
            this.rbListViewList.TabIndex = 3;
            this.rbListViewList.TabStop = true;
            this.rbListViewList.Text = "List";
            this.rbListViewList.UseVisualStyleBackColor = true;
            this.rbListViewList.CheckedChanged += new System.EventHandler(this.rbListViewList_CheckedChanged);
            // 
            // rbListViewSmallIcon
            // 
            this.rbListViewSmallIcon.AutoSize = true;
            this.rbListViewSmallIcon.Location = new System.Drawing.Point(15, 96);
            this.rbListViewSmallIcon.Name = "rbListViewSmallIcon";
            this.rbListViewSmallIcon.Size = new System.Drawing.Size(96, 22);
            this.rbListViewSmallIcon.TabIndex = 2;
            this.rbListViewSmallIcon.TabStop = true;
            this.rbListViewSmallIcon.Text = "Small Icon";
            this.rbListViewSmallIcon.UseVisualStyleBackColor = true;
            this.rbListViewSmallIcon.CheckedChanged += new System.EventHandler(this.rbListViewSmallIcon_CheckedChanged);
            // 
            // rbListViewLargeIcon
            // 
            this.rbListViewLargeIcon.AutoSize = true;
            this.rbListViewLargeIcon.Location = new System.Drawing.Point(14, 56);
            this.rbListViewLargeIcon.Name = "rbListViewLargeIcon";
            this.rbListViewLargeIcon.Size = new System.Drawing.Size(95, 22);
            this.rbListViewLargeIcon.TabIndex = 1;
            this.rbListViewLargeIcon.TabStop = true;
            this.rbListViewLargeIcon.Text = "Large Icon";
            this.rbListViewLargeIcon.UseVisualStyleBackColor = true;
            this.rbListViewLargeIcon.CheckedChanged += new System.EventHandler(this.rbListViewLargeIcon_CheckedChanged);
            // 
            // rbListViewDetails
            // 
            this.rbListViewDetails.AutoSize = true;
            this.rbListViewDetails.Checked = true;
            this.rbListViewDetails.Location = new System.Drawing.Point(14, 18);
            this.rbListViewDetails.Name = "rbListViewDetails";
            this.rbListViewDetails.Size = new System.Drawing.Size(73, 22);
            this.rbListViewDetails.TabIndex = 0;
            this.rbListViewDetails.TabStop = true;
            this.rbListViewDetails.Text = "Details";
            this.rbListViewDetails.UseVisualStyleBackColor = true;
            this.rbListViewDetails.CheckedChanged += new System.EventHandler(this.rbListViewDetails_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(599, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "View";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 525);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Students Manager";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtbID;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtbPhoneNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtbLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader StudentName;
        private System.Windows.Forms.ColumnHeader Level;
        private System.Windows.Forms.ColumnHeader PhoneNumber;
        private System.Windows.Forms.ColumnHeader Gender;
        private System.Windows.Forms.ColumnHeader BirthDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbListViewLargeIcon;
        private System.Windows.Forms.RadioButton rbListViewDetails;
        private System.Windows.Forms.RadioButton rbListViewTiles;
        private System.Windows.Forms.RadioButton rbListViewList;
        private System.Windows.Forms.RadioButton rbListViewSmallIcon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

