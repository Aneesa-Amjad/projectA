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
    public partial class Project : Form
    {
        public Project()
        {
            InitializeComponent();
            string pro = "select * from project";
            SqlConnection connection = new SqlConnection(conStr);
            SqlDataAdapter com = new SqlDataAdapter();
            com.SelectCommand = new SqlCommand(pro, connection);
            DataTable data = new DataTable();
            com.Fill(data);
            BindingSource n = new BindingSource();
            n.DataSource = data;
            projectdata.DataSource = n;
        }
        public string conStr = "Data Source=DESKTOP-CMKQCBQ;Initial Catalog=ProjectA;Integrated Security=True";
        private void cmdprojectenter_Click(object sender, EventArgs e)
        {
            string Title = txttitle.Text;
            string Description = txtdescription.Text;
            SqlConnection connection = new SqlConnection(conStr);
            connection.Open();
            if (connection.State == ConnectionState.Open)
            {
                string q = "insert into Project(Title,Description) values('" + txttitle.Text + "','" + txtdescription.Text + "' )";
                SqlCommand cmd = new SqlCommand(q, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Entered");
            }
            string pro = "select * from Project";
            SqlDataAdapter com = new SqlDataAdapter();
            com.SelectCommand = new SqlCommand(pro, connection);
            DataTable data = new DataTable();
            com.Fill(data);
            BindingSource n = new BindingSource();
            n.DataSource = data;
            projectdata.DataSource = n;
            txttitle.Text = "";
            txtdescription.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            this.Hide();
        }

        private void projectdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ( e.ColumnIndex==0 )
            {
                
                SqlConnection connection = new SqlConnection(conStr);
                connection.Open();
                string q = "delete from Project where Title = '" + projectdata.Rows[e.RowIndex].Cells[4].Value.ToString() + "' ";
                SqlCommand cmd = new SqlCommand(q, connection);
                cmd.ExecuteNonQuery();
                string pro = "select * from project";
                SqlConnection conn = new SqlConnection(conStr);
                SqlDataAdapter com = new SqlDataAdapter();
                com.SelectCommand = new SqlCommand(pro, conn);
                DataTable data = new DataTable();
                com.Fill(data);
                BindingSource n = new BindingSource();
                n.DataSource = data;
                projectdata.DataSource = n;
                MessageBox.Show("Delete");
            }
        }
    }
}
