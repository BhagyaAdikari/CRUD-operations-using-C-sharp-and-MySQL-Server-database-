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
            panel1 = new Panel();
            textBox1 = new TextBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label8 = new Label();
            textBox6 = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1486, 63);
            panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(214, 105);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(496, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            comboBox1.Location = new Point(214, 281);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(496, 28);
            comboBox1.TabIndex = 0;
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
            // textBox2
            // 
            textBox2.Location = new Point(214, 220);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(496, 27);
            textBox2.TabIndex = 2;
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
            // textBox3
            // 
            textBox3.Location = new Point(214, 159);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(496, 27);
            textBox3.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(214, 337);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(496, 27);
            dateTimePicker1.TabIndex = 6;
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
            // textBox4
            // 
            textBox4.Location = new Point(214, 481);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(496, 27);
            textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.ButtonHighlight;
            textBox5.Location = new Point(214, 381);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(496, 71);
            textBox5.TabIndex = 14;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(57, 553);
            button1.Name = "button1";
            button1.Size = new Size(174, 50);
            button1.TabIndex = 15;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Gold;
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(286, 553);
            button2.Name = "button2";
            button2.Size = new Size(174, 50);
            button2.TabIndex = 16;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Crimson;
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(516, 553);
            button3.Name = "button3";
            button3.Size = new Size(174, 50);
            button3.TabIndex = 17;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
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
            // textBox6
            // 
            textBox6.Location = new Point(864, 109);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(261, 27);
            textBox6.TabIndex = 18;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(753, 162);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(733, 478);
            dataGridView1.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1639, 624);
            Controls.Add(dataGridView1);
            Controls.Add(label8);
            Controls.Add(textBox6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CRUD in C#";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label8;
        private TextBox textBox6;
        private DataGridView dataGridView1;
    }
}
