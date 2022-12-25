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


namespace guestregistration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ROG\SQLEXPRESS;Initial Catalog=guestregistrationDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[register]
           ([Firstname]
           ,[Midname]
           ,[Lastname]
           ,[Gender]
           ,[Email]
           ,[Organization]
           ,[Address])
     VALUES
           ('" + txtFirstname.Text + "', '" + txtMidname.Text + "', '" + txtLastname.Text + "', '" + txtEmail.Text + "', '" + txtOrganization.Text + "', '" + txtAddress.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successful");



        }
    }
}
