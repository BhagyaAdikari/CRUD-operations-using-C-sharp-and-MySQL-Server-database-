
namespace CRUD_in_C_Sharp
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            txt_studID = new TextBox();
            label1 = new Label();
            cbo_Class = new ComboBox();
            label2 = new Label();
            txt_FatherName = new TextBox();
            label3 = new Label();
            txt_stuName = new TextBox();
            dtp_DOB = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txt_phone = new TextBox();
            txt_address = new TextBox();
            btn_Save = new Button();
            btn_Update = new Button();
            btn_Delete = new Button();
            label8 = new Label();
            txt_search = new TextBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Class = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1810, 63);
            panel1.TabIndex = 0;
            // 
            // txt_studID
            // 
            txt_studID.Location = new Point(214, 105);
            txt_studID.Name = "txt_studID";
            txt_studID.Size = new Size(496, 27);
            txt_studID.TabIndex = 0;
            txt_studID.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 108);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 1;
            label1.Text = "Student ID";
            // 
            // cbo_Class
            // 
            cbo_Class.FormattingEnabled = true;
            cbo_Class.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cbo_Class.Location = new Point(214, 281);
            cbo_Class.Name = "cbo_Class";
            cbo_Class.Size = new Size(496, 28);
            cbo_Class.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 227);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 3;
            label2.Text = "Father Name";
            label2.Click += label2_Click;
            // 
            // txt_FatherName
            // 
            txt_FatherName.Location = new Point(214, 220);
            txt_FatherName.Name = "txt_FatherName";
            txt_FatherName.Size = new Size(496, 27);
            txt_FatherName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 162);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 5;
            label3.Text = "Student Name";
            // 
            // txt_stuName
            // 
            txt_stuName.Location = new Point(214, 159);
            txt_stuName.Name = "txt_stuName";
            txt_stuName.Size = new Size(496, 27);
            txt_stuName.TabIndex = 4;
            txt_stuName.TextChanged += textBox3_TextChanged;
            // 
            // dtp_DOB
            // 
            dtp_DOB.Location = new Point(214, 337);
            dtp_DOB.Name = "dtp_DOB";
            dtp_DOB.Size = new Size(496, 27);
            dtp_DOB.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(94, 289);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 7;
            label4.Text = "Class";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(94, 344);
            label5.Name = "label5";
            label5.Size = new Size(98, 20);
            label5.TabIndex = 8;
            label5.Text = "Date Of Birth";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(94, 397);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 10;
            label6.Text = "Address";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(94, 488);
            label7.Name = "label7";
            label7.Size = new Size(78, 20);
            label7.TabIndex = 12;
            label7.Text = "Phone No";
            // 
            // txt_phone
            // 
            txt_phone.Location = new Point(214, 481);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(496, 27);
            txt_phone.TabIndex = 13;
            // 
            // txt_address
            // 
            txt_address.BackColor = SystemColors.ButtonHighlight;
            txt_address.Location = new Point(214, 381);
            txt_address.Multiline = true;
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(496, 71);
            txt_address.TabIndex = 14;
            // 
            // btn_Save
            // 
            btn_Save.BackColor = SystemColors.Highlight;
            btn_Save.ForeColor = SystemColors.ControlLightLight;
            btn_Save.Location = new Point(57, 553);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(174, 50);
            btn_Save.TabIndex = 15;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = false;
            btn_Save.Click += button1_Click;
            // 
            // btn_Update
            // 
            btn_Update.BackColor = Color.Gold;
            btn_Update.ForeColor = SystemColors.ControlLightLight;
            btn_Update.Location = new Point(286, 553);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(174, 50);
            btn_Update.TabIndex = 16;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = false;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.BackColor = Color.Crimson;
            btn_Delete.ForeColor = SystemColors.ControlLightLight;
            btn_Delete.Location = new Point(516, 553);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(174, 50);
            btn_Delete.TabIndex = 17;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = false;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(744, 112);
            label8.Name = "label8";
            label8.Size = new Size(55, 20);
            label8.TabIndex = 19;
            label8.Text = "Search";
            // 
            // txt_search
            // 
            txt_search.Location = new Point(864, 109);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(261, 27);
            txt_search.TabIndex = 18;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column6, Class, Column7, Column8 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(753, 162);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(994, 478);
            dataGridView1.TabIndex = 20;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "#";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 47;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column2.HeaderText = "Rool No";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 94;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Name";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column4.HeaderText = "Father Name";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 126;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.Format = "D";
            dataGridViewCellStyle1.NullValue = null;
            Column6.DefaultCellStyle = dataGridViewCellStyle1;
            Column6.HeaderText = "DOB";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 69;
            // 
            // Class
            // 
            Class.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            Class.HeaderText = "Column5";
            Class.MinimumWidth = 6;
            Class.Name = "Class";
            Class.ReadOnly = true;
            Class.Width = 6;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column7.HeaderText = "Address";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 92;
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column8.HeaderText = "Phone Number";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 143;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1812, 624);
            Controls.Add(dataGridView1);
            Controls.Add(label8);
            Controls.Add(txt_search);
            Controls.Add(btn_Delete);
            Controls.Add(btn_Update);
            Controls.Add(btn_Save);
            Controls.Add(txt_address);
            Controls.Add(txt_phone);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dtp_DOB);
            Controls.Add(label3);
            Controls.Add(txt_stuName);
            Controls.Add(label2);
            Controls.Add(txt_FatherName);
            Controls.Add(cbo_Class);
            Controls.Add(label1);
            Controls.Add(txt_studID);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CRUD in C#";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = txt_studID.Text;
        }


        private void label4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        
            private void button1_Click(object sender, EventArgs e)
        {
            // Implement the functionality here
            btn_save_click(sender, e);
            MessageBox.Show("Button clicked!");
        }


        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        

        #endregion

        private Panel panel1;
        private TextBox txt_studID;
        private Label label1;
        private ComboBox cbo_Class;
        private Label label2;
        private TextBox txt_FatherName;
        private Label label3;
        private TextBox txt_stuName;
        private DateTimePicker dtp_DOB;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txt_phone;
        private TextBox txt_address;
        private Button btn_Save;
        private Button btn_Update;
        private Button btn_Delete;
        private Label label8;
        private TextBox txt_search;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Class;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
    }
}
