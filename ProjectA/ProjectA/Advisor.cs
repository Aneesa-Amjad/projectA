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

namespace ProjectA
{
    public partial class Advisor : Form
    {
        public Advisor()
        {
            InitializeComponent();
            string combine = "select Person.FirstName, Person.LastName, Person.Contact, Person.Email, Person.DateOfBirth, Advisor.Designation, Advisor.Salary From Person inner join Advisor on Person.Id = Advisor.Id";
            SqlConnection connection = new SqlConnection(conStr);
            SqlDataAdapter com = new SqlDataAdapter();
            com.SelectCommand = new SqlCommand(combine, connection);
            DataTable data = new DataTable();
            com.Fill(data);
            BindingSource n = new BindingSource();
            n.DataSource = data;
            Advisordata.DataSource = n;
        }
        public string conStr = "Data Source=DESKTOP-CMKQCBQ;Initial Catalog=ProjectA;Integrated Security=True";
        private void cmdadvisorenter_Click(object sender, EventArgs e)
        {
            string FirstName = txtfirst.Text;
            string LastName = txtlast.Text;
            string Contact = txtcontact.Text;
            string Email = txtemail.Text;
            DateTime DOB = dtDOB.Value;
            MessageBox.Show(dtDOB.Value.ToString());
            string Gender = comboBox2.Text;
            string Salary = txtsalary.Text;
            string Designation = comboBox1.Text;
            SqlConnection connection = new SqlConnection(conStr);
            connection.Open();
            string conv = comboBox1.SelectedItem.ToString();
            string advisorvalue = "select id from lookup where Category = 'DESIGNATION' and value ='" + conv + "'";
            SqlCommand advisorInt = new SqlCommand(advisorvalue, connection);
            int val = 0;
            SqlDataReader reader = advisorInt.ExecuteReader();
            while (reader.Read())
            {
                val = int.Parse(reader[0].ToString());
            }
            reader.Close();
            string combo = comboBox2.SelectedItem.ToString();
            string gendervalue = "select id from lookup where category = 'Gender' and value ='" + combo + "'";
            SqlCommand genderInt = new SqlCommand(gendervalue, connection);
            int value = 0;
            SqlDataReader read = genderInt.ExecuteReader();
            while (read.Read())
            {
                value = int.Parse(read[0].ToString());
            }
            read.Close();
                if (connection.State == ConnectionState.Open)
            {
                string a = "insert into Person(FirstName,LastName,Contact,Email,DateOfBirth,Gender) values('" + txtfirst.Text + "','" + txtlast.Text + "','" + txtcontact.Text + "','" + txtemail.Text + "', NULL ,'" + value + "' )";
                SqlCommand cod = new SqlCommand(a, connection);
                cod.ExecuteNonQuery();
                
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
                    int b = Convert.ToInt32(row[0].ToString());
                    if (connection.State == ConnectionState.Open)
                    {
                        string i = "insert into Advisor(Id,Designation,Salary) values('" + b + "','" + val + "','" + txtsalary.Text + "' )";
                        SqlCommand cmd = new SqlCommand(i, connection);
                        cmd.ExecuteNonQuery();
                    }

                }
            }
            string combine = "select Person.FirstName, Person.LastName, Person.Contact, Person.Email, Person.DateOfBirth, Advisor.Designation, Advisor.Salary From Person inner join Advisor on Person.Id = Advisor.Id";
            SqlConnection con = new SqlConnection(conStr);
            SqlDataAdapter com = new SqlDataAdapter();
            com.SelectCommand = new SqlCommand(combine, con);
            DataTable data = new DataTable();
            com.Fill(data);
            BindingSource n = new BindingSource();
            n.DataSource = data;
            Advisordata.DataSource = n;
            txtfirst.Text = "";
            txtlast.Text = "";
            txtcontact.Text = "";
            txtemail.Text = "";
            txtsalary.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            this.Hide();
        }
    }
}
