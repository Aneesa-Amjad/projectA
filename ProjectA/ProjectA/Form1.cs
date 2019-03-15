using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace ProjectA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string combine = "select Person.FirstName, Person.LastName, Person.Contact, Person.Email, Person.DateOfBirth, Student.RegistrationNo From Person inner join Student on Person.Id = Student.Id";
            SqlConnection connection = new SqlConnection(conStr);
            SqlDataAdapter com = new SqlDataAdapter();
            com.SelectCommand = new SqlCommand(combine, connection);
            DataTable data = new DataTable();
            com.Fill(data);
            BindingSource n = new BindingSource();
            n.DataSource = data;
            PersonInfo.DataSource = n;
        }
        public string conStr = "Data Source=DESKTOP-CMKQCBQ;Initial Catalog=ProjectA;Integrated Security=True";
        private void cmdregister_Click(object sender, EventArgs e)
        {
            string FirstName = txtfirst.Text;
            string LastName = txtlast.Text;
            string Contact = txtcontact.Text;
            string Email = txtemail.Text;
            string RegNo = txtregno.Text;
            DateTime DOB = dtDOB.Value;
            MessageBox.Show(dtDOB.Value.ToString());
            string Gender = comboBox1.Text;
            SqlConnection connection = new SqlConnection(conStr);
            connection.Open();
            string conv = comboBox1.SelectedItem.ToString();
            string gendervalue = "select id from lookup where category = 'Gender' and value ='" + conv + "'";
            SqlCommand genderInt = new SqlCommand(gendervalue, connection);
            int value = 0;
            SqlDataReader reader = genderInt.ExecuteReader();
            while(reader.Read())
            {
                value = int.Parse(reader[0].ToString());
            }
            reader.Close();
                if (connection.State == ConnectionState.Open)
                {
                    string q = "insert into Person(FirstName,LastName,Contact,Email,DateOfBirth,Gender) values('" + txtfirst.Text + "','" + txtlast.Text + "','" + txtcontact.Text + "','" + txtemail.Text + "', NULL ,'" + value + "' )";
                    SqlCommand cmd = new SqlCommand(q, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student is Registered");
                }
            string getregno = "select * from person";
            SqlDataAdapter rdr = new SqlDataAdapter();
            rdr.SelectCommand = new SqlCommand(getregno, connection);
            DataTable dt = new DataTable();
            rdr.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                if (row[3].ToString() == txtcontact.Text && row[4].ToString() == txtemail.Text)
                {
                    int a = Convert.ToInt32(row[0].ToString());
                    if (connection.State == ConnectionState.Open)
                    {
                        string i = "insert into Student(Id,RegistrationNo) values('" + a + "','" + txtregno.Text + "' )";
                        SqlCommand cmd = new SqlCommand(i, connection);
                        cmd.ExecuteNonQuery();
                    }

                }
            }
            string combine = "select Person.FirstName, Person.LastName, Person.Contact, Person.Email, Person.DateOfBirth, Student.RegistrationNo From Person inner join Student on Person.Id = Student.Id";
            SqlConnection con = new SqlConnection(conStr);
            SqlDataAdapter com = new SqlDataAdapter();
            com.SelectCommand = new SqlCommand(combine, con);
            DataTable data = new DataTable();
            com.Fill(data);
            BindingSource n = new BindingSource();
            n.DataSource = data;
            PersonInfo.DataSource = n;
            txtfirst.Text = "";
            txtlast.Text = "";
            txtcontact.Text = "";
            txtemail.Text = "";
            txtregno.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            this.Hide();
        }
    }
}
