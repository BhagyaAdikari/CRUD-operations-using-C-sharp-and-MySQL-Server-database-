using System.Collections.Generic;
using System.Net;
using System;
using MySql.Data.MySqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CRUD_in_C_Sharp
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader dr;
        int i = 0;

        dbconnection db = new dbconnection();
        public Form1()
        {
            InitializeComponent();
            conn = new MySqlConnection(db.dbconnect());

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadRecord();
            dataGridView1.RowTemplate.Height = 25;
        }

        public void LoadRecord()
        {
            dataGridView1.Rows.Clear();
            conn.Open();
            cmd = new MySqlCommand("SELECT * FROM `tb_curd`", conn);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1, dr["stuid"].ToString(), dr["stuname"].ToString(), dr["fathername"].ToString(), dr["class"].ToString(), dr["dob"].ToString(), dr["address"].ToString(), dr["phone"].ToString());
            }
            dr.Close();
            conn.Close();
        }

        public void ClearRecord()
        {
            txt_studID.Clear();
            txt_stuName.Clear();
            txt_FatherName.Clear();
            txt_address.Clear();
            txt_phone.Clear();
            cbo_Class.SelectedIndex = -1;
            dtp_DOB.Value = DateTime.Now;
        }

        private void btn_save_click(object sender, EventArgs e)
        {
            if ((txt_studID.Text == string.Empty) || (txt_stuName.Text == string.Empty) || (txt_FatherName.Text == string.Empty) || (txt_address.Text == string.Empty) || (txt_phone.Text == string.Empty) || (cbo_Class.Text == string.Empty))
            {
                MessageBox.Show("Please fill all the fields", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string date1 = dtp_DOB.Value.ToString("yyyy-MM-dd");
                conn.Open();
                cmd = new MySqlCommand("INSERT INTO `tb_curd`( `stuid`, `stuname`, `fathername`, `class`, `dob`, `address`, `phone`) VALUES(@stuid, @stuname, @fathername, @class, @dob, @address, @phone)", conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@stuid", txt_studID.Text);
                cmd.Parameters.AddWithValue("@stuname", txt_stuName.Text);
                cmd.Parameters.AddWithValue("@fathername", txt_FatherName.Text);
                cmd.Parameters.AddWithValue("@address", txt_address.Text);
                cmd.Parameters.AddWithValue("@class", cbo_Class.Text);
                cmd.Parameters.AddWithValue("@dob", date1);
                cmd.Parameters.AddWithValue("@phone", txt_phone.Text);
                i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Record Save Success ! ", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Record Save Failed ! ", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                conn.Close();
                LoadRecord();
                ClearRecord();
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            //Update

            string date1 = dtp_DOB.Value.ToString("yyyy-MM-dd");
            conn.Open();
            cmd = new MySqlCommand("UPDATE `tb_curd` SET `stuname`=@stuname,`fathername`=@fathername,`class`=@class,`dob`=@dob,`address`=@address,`phone`=@phone WHERE `stuid`=@stuid", conn);
            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@stuname", txt_stuName.Text);
            cmd.Parameters.AddWithValue("@fathername", txt_FatherName.Text);
            cmd.Parameters.AddWithValue("@address", txt_address.Text);
            cmd.Parameters.AddWithValue("@class", cbo_Class.Text);
            cmd.Parameters.AddWithValue("@dob", date1);
            cmd.Parameters.AddWithValue("@phone", txt_phone.Text);
            cmd.Parameters.AddWithValue("@stuid", txt_studID.Text);
            i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Record Update Success ! ", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Record Update Failed ! ", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            conn.Close();
            LoadRecord();
            ClearRecord();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            //Delete
            conn.Open();
            cmd = new MySqlCommand("Delete from  `tb_curd`  WHERE `stuid`=@stuid", conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@stuid", txt_studID.Text);

            i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Record Delete Success ! ", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Record Delete Failed ! ", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            conn.Close();
            LoadRecord();
            ClearRecord();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_studID.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_stuName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_FatherName.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cbo_Class.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dtp_DOB.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_address.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txt_phone.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }
    }
}
